using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Pdi.Full.Micro.Service.Entities.Models;
using Pdi.Full.Micro.Service.Repositories.Abstractions;
using Pdi.Full.Micro.Service.Repositories.Contexts;

namespace Pdi.Full.Micro.Service.Repositories
{
    public class ProdutoRepository : IProdutoRepository
    {
        private readonly FullServiceDbContext _context;

        public ProdutoRepository(FullServiceDbContext context)
        {
            _context = context;
        }
        
        public async Task<IEnumerable<Produto>> Obter(CancellationToken cancellationToken) => await _context.Produtos.ToListAsync(cancellationToken);

        public async Task<Produto> Obter(Guid id,CancellationToken cancellationToken) => await _context.Produtos.FindAsync(new object[]{ id }, cancellationToken);

        public async Task Atualizar(Guid id, Produto produto, CancellationToken cancellationToken)
        {
            _context.Entry(produto).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync(cancellationToken);
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!await ProdutoExistsAsync(id, cancellationToken))
                {
                    throw;
                }
            }
        }

        public async Task<Produto> Adicionar(Produto produto, CancellationToken cancellationToken)
        {
            await _context.Produtos.AddAsync(produto, cancellationToken);
            await _context.SaveChangesAsync(cancellationToken);

            return produto;
        }

        public async Task<bool> Remover(Guid id, CancellationToken cancellationToken)
        {
            var produto = await _context.Produtos.FindAsync(id, cancellationToken);
            _context.Produtos.Remove(produto);
            await _context.SaveChangesAsync(cancellationToken);

            return await ProdutoExistsAsync(id, cancellationToken);
        }

        private async Task<bool> ProdutoExistsAsync(Guid id, CancellationToken cancellationToken) => await _context.Produtos.AnyAsync(e => e.Id == id, cancellationToken);
    }
}