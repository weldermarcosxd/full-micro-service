using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Pdi.Full.Micro.Service.Entities.Models;
using Pdi.Full.Micro.Service.Repositories.Abstractions;
using Pdi.Full.Micro.Service.Services.Abstractions;

namespace Pdi.Full.Micro.Service.Services.Produtos
{
    public class ProdutoService : IProdutoService
    {
        private readonly IProdutoRepository _produtoRepository;

        public ProdutoService(IProdutoRepository produtoRepository)
        {
            _produtoRepository = produtoRepository;
        }

        public async Task<IEnumerable<Produto>> ObterAsync(CancellationToken cancellationToken)
        {
            cancellationToken.ThrowIfCancellationRequested();
            
            return await _produtoRepository.Obter(cancellationToken);
        }

        public async Task<Produto> ObterAsync(Guid produtoId, CancellationToken cancellationToken)
        {
            cancellationToken.ThrowIfCancellationRequested();

            return await _produtoRepository.Obter(produtoId, cancellationToken);
        }

        public async Task<Produto> AdicionarAsync(Produto produto, CancellationToken cancellationToken)
        {
            cancellationToken.ThrowIfCancellationRequested();

            if (produto.Sequencial == decimal.Zero)
            {
                var produtos = await _produtoRepository.Obter(cancellationToken);
                produto.Sequencial = produtos.Max(x => x.Sequencial) + 1;
            }
            
            await _produtoRepository.Adicionar(produto, cancellationToken);

            return produto;
        }

        public async Task<Produto> AtualizarAsync(Guid id, Produto produto, CancellationToken cancellationToken)
        {
            cancellationToken.ThrowIfCancellationRequested();

            await _produtoRepository.Atualizar(id, produto, cancellationToken);

            return produto;
        }

        public async Task<bool> RemoverAsync(Guid id, CancellationToken cancellationToken)
        {
            cancellationToken.ThrowIfCancellationRequested();
            
            return await _produtoRepository.Remover(id, cancellationToken);
        }
    }
}