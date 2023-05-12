using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Pdi.Full.Micro.Service.Entities;

namespace Pdi.Full.Micro.Service.Repositories.Abstractions
{
    public interface IUsuarioRepository
    {
        Task<IEnumerable<Usuario>> ObterAsync(CancellationToken cancellationToken);
        Task<Usuario> ObterAsync(string nomeDeUsuario, CancellationToken cancellationToken);
        Task<Usuario> AdicionarAsync(Usuario novoUsuario, CancellationToken cancellationToken);
        Task<Usuario> AtualizarAsync(Usuario usuarioAtualizado, CancellationToken cancellationToken);
        Task<bool> RemoverAsync(string nomeDeUsuario, CancellationToken cancellationToken);
    }
}