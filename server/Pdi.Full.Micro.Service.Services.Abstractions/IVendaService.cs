using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Pdi.Full.Micro.Service.Entities.Models;

namespace Pdi.Full.Micro.Service.Services.Abstractions
{
    public interface IVendaService
    {
        Task<IEnumerable<Venda>> ObterAsync(CancellationToken cancellationToken);
        Task<Venda> ObterAsync(Guid id, CancellationToken cancellationToken);
        Task<Venda> CadastrarAsync(Venda venda, CancellationToken cancellationToken);
        Task<Venda> EstornarAsync(Guid id, CancellationToken cancellationToken);
    }
}