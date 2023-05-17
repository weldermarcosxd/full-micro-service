using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Pdi.Full.Micro.Service.Entities.Models;
using Pdi.Full.Micro.Service.Messages;

namespace Pdi.Full.Micro.Service.Services.Abstractions
{
    public interface IProdutoService
    {
        Task<IEnumerable<Produto>> ObterAsync(CancellationToken cancellationToken);
        Task<Produto> ObterAsync(Guid produtoId, CancellationToken cancellationToken);
        Task<Produto> AdicionarAsync(Produto produto, CancellationToken cancellationToken);
        Task<Produto> AtualizarAsync(Guid id, Produto produto, CancellationToken cancellationToken);
        Task<bool> RemoverAsync(Guid id, CancellationToken cancellationToken);
        Task AtualizarEstoqueAsync(DeducaoDeEstoqueMessage deducaoDeEstoqueMessage, CancellationToken cancellationToken);
    }
}