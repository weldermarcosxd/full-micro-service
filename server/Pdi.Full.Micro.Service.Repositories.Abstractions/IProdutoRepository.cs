
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Pdi.Full.Micro.Service.Entities.Models;

namespace Pdi.Full.Micro.Service.Repositories.Abstractions
{
    public interface IProdutoRepository
    {
        Task<IEnumerable<Produto>> Obter(CancellationToken cancellationToken);
        Task<Produto> Obter(Guid id, CancellationToken cancellationToken);
        Task Atualizar(Guid id, Produto produto, CancellationToken cancellationToken);
        Task<Produto> Adicionar(Produto produto, CancellationToken cancellationToken);
        Task<bool> Remover(Guid id, CancellationToken cancellationToken);
    }
}