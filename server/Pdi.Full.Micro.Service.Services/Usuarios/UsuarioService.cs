using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Pdi.Full.Micro.Service.Entities;
using Pdi.Full.Micro.Service.Repositories.Abstractions;
using Pdi.Full.Micro.Service.Services.Abstractions;

namespace Pdi.Full.Micro.Service.Services.Usuarios
{
    public class UsuarioService : IUsuarioService
    {
        private readonly IUsuarioRepository _usuarioRepository;
        
        public UsuarioService(IUsuarioRepository usuarioRepository)
        {
            _usuarioRepository = usuarioRepository;
        }

        public async Task<IEnumerable<Usuario>> ObterAsync(CancellationToken cancellationToken)
        {
            cancellationToken.ThrowIfCancellationRequested();
            
            return await _usuarioRepository.ObterAsync(cancellationToken);
        }

        public async Task<Usuario> ObterAsync(string nomeDeUsuario, CancellationToken cancellationToken)
        {
            cancellationToken.ThrowIfCancellationRequested();
            
            return await _usuarioRepository.ObterAsync(nomeDeUsuario, cancellationToken);
        }

        public async Task<Usuario> AdicionarAsync(Usuario usuarioNovo, CancellationToken cancellationToken)
        {
            cancellationToken.ThrowIfCancellationRequested();
            
            var usuarios = await _usuarioRepository.ObterAsync(cancellationToken);
            if (usuarios.Contains(usuarioNovo)) return usuarios.FirstOrDefault(x => x.NomeDeUsuario == usuarioNovo.NomeDeUsuario);
            await _usuarioRepository.AdicionarAsync(usuarioNovo, cancellationToken);
            return usuarioNovo;
        }

        public async Task<Usuario> AtualizarAsync(string nomeDeUsuario, Usuario usuario,
            CancellationToken cancellationToken)
        {
            cancellationToken.ThrowIfCancellationRequested();

            if (nomeDeUsuario != usuario.NomeDeUsuario) return default;
            
            var usuarios = await _usuarioRepository.ObterAsync(cancellationToken);
            if (usuarios.All(x => x.NomeDeUsuario != nomeDeUsuario)) return default;
            return await _usuarioRepository.AtualizarAsync(usuario, cancellationToken);
        }

        public async Task<bool> RemoverAsync(string nomeDeUsuario, CancellationToken cancellationToken)
        {
            cancellationToken.ThrowIfCancellationRequested();

            return await _usuarioRepository.RemoverAsync(nomeDeUsuario, cancellationToken);
        }
    }
}