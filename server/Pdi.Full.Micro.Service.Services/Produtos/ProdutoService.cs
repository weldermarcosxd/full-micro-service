using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Pdi.Full.Micro.Service.Entities.Dtos;
using Pdi.Full.Micro.Service.Entities.Mapers;
using Pdi.Full.Micro.Service.Entities.Models;
using Pdi.Full.Micro.Service.Messages;
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

        public async Task<RespostaPaginada<IEnumerable<ProdutoDto>>> ObterAsync(FiltroDePaginacao filtro, CancellationToken cancellationToken)
        {
            cancellationToken.ThrowIfCancellationRequested();

            var query = _produtoRepository.ObterQueryable();

            var totalDeRegistros = await query.CountAsync(cancellationToken);
            var registroParaPular = (filtro.NumeroDaPagina - 1) * filtro.TamanhoDaPagina;

            var paginaDeRegistros = await query
                .Skip(registroParaPular)
                .Take(filtro.TamanhoDaPagina)
                .ProjetarParaDto()
                .ToListAsync(cancellationToken);
            
            return new RespostaPaginada<IEnumerable<ProdutoDto>>(paginaDeRegistros, filtro, totalDeRegistros);
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
                var produtos = _produtoRepository.ObterQueryable();
                produto.Sequencial = await produtos.MaxAsync(x => x.Sequencial, cancellationToken) + 1;
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

        public async Task AtualizarEstoqueAsync(DeducaoDeEstoqueMessage deducaoDeEstoqueMessage, CancellationToken cancellationToken)
        {
            cancellationToken.ThrowIfCancellationRequested();

            var produto = await _produtoRepository.Obter(deducaoDeEstoqueMessage.ProdutoId, cancellationToken);
            produto.QuantidadeEmEstoque -= deducaoDeEstoqueMessage.Quantidade;

            await _produtoRepository.Atualizar(produto.Id, produto, cancellationToken);
        }
    }
}