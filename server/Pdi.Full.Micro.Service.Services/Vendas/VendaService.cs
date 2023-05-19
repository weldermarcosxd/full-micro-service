using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using MassTransit;
using Pdi.Full.Micro.Service.Entities.Models;
using Pdi.Full.Micro.Service.Messages;
using Pdi.Full.Micro.Service.Repositories.Abstractions;
using Pdi.Full.Micro.Service.Services.Abstractions;

namespace Pdi.Full.Micro.Service.Services.Vendas
{
    public class VendaService : IVendaService
    {
        private readonly IVendaRepository _vendaRepository;
        private readonly IPublishEndpoint _publishEndpoint;

        public VendaService(IVendaRepository vendaRepository, IPublishEndpoint publishEndpoint)
        {
            _vendaRepository = vendaRepository;
            _publishEndpoint = publishEndpoint;
        }

        public async Task<IEnumerable<Venda>> ObterAsync(CancellationToken cancellationToken)
            =>  await _vendaRepository.ObterAsync(cancellationToken);

        public async Task<Venda> ObterAsync(Guid id, CancellationToken cancellationToken)
            => await _vendaRepository.ObterAsync(id, cancellationToken);

        public async Task<Venda> CadastrarAsync(Venda venda, CancellationToken cancellationToken)
        {
            cancellationToken.ThrowIfCancellationRequested();
            
            if (venda.Sequencial == decimal.Zero)
            {
                var vendas = await _vendaRepository.ObterAsync(cancellationToken);
                venda.Sequencial = vendas.Any() ? (vendas.Max(x => x.Sequencial) + 1) : 1;
                var sequencial = 0;
                foreach (var item in venda.Itens)
                    item.Sequencial = ++sequencial;
            }

            await _vendaRepository.Adicionar(venda, cancellationToken);

            foreach (var itemDaVenda in venda.Itens)
            {
                var deducaoDeEstoqueMessage = new DeducaoDeEstoqueMessage { Quantidade = itemDaVenda.Quantidade, ProdutoId = itemDaVenda.ProdutoId };
                await _publishEndpoint.Publish(deducaoDeEstoqueMessage, cancellationToken);
            }
            
            return venda;
        }

        public async Task<Venda> EstornarAsync(Guid id, CancellationToken cancellationToken)
        {
            cancellationToken.ThrowIfCancellationRequested();

            return await _vendaRepository.RemoverAsync(id, cancellationToken);
        }
    }
}