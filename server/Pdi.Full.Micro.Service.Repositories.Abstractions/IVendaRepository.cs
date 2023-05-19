using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Pdi.Full.Micro.Service.Entities.Models;

namespace Pdi.Full.Micro.Service.Repositories.Abstractions
{
    public interface IVendaRepository
    {
        Task<IEnumerable<Venda>> ObterAsync(CancellationToken cancellationToken);
        Task<Venda> ObterAsync(Guid id, CancellationToken cancellationToken);
        Task<Venda> Adicionar(Venda venda, CancellationToken cancellationToken);
        Task<Venda> RemoverAsync(Guid id, CancellationToken cancellationToken);
    }
}