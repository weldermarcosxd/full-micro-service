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
    public class VendaRepository : IVendaRepository
    {
        private readonly FullServiceDbContext _context;

        public VendaRepository(FullServiceDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Venda>> ObterAsync(CancellationToken cancellationToken)
            => await _context.Vendas.ToListAsync(cancellationToken);

        public async Task<Venda> ObterAsync(Guid id, CancellationToken cancellationToken)
            => await _context.Vendas.FindAsync(id, cancellationToken);

        public async Task<Venda> Adicionar(Venda venda, CancellationToken cancellationToken)
        {
            await _context.Vendas.AddAsync(venda, cancellationToken);
            await _context.SaveChangesAsync(cancellationToken);

            return venda;
        }

        public async Task<Venda> RemoverAsync(Guid id, CancellationToken cancellationToken)
        {
            var venda = new Venda { Id = id };
            _context.Attach(venda);
            _context.Vendas.Remove(venda);
            await _context.SaveChangesAsync(cancellationToken);

            return venda;
        }
    }
}