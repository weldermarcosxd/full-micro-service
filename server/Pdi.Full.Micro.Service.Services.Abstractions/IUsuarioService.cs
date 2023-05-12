using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Pdi.Full.Micro.Service.Entities;

namespace Pdi.Full.Micro.Service.Services.Abstractions
{
    public interface IUsuarioService
    {
        Task<IEnumerable<Usuario>> ObterAsync(CancellationToken cancellationToken);
        Task<Usuario> ObterAsync(string nomeDeUsuario, CancellationToken cancellationToken);
        Task<Usuario> AdicionarAsync(Usuario usuarioNovo, CancellationToken cancellationToken);
        Task<Usuario> AtualizarAsync(string nomeDeUsuario, Usuario usuario, CancellationToken cancellationToken);
        Task<bool> RemoverAsync(string nomeDeUsuario, CancellationToken cancellationToken);
    }
}