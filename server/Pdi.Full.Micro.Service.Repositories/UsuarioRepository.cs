using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Pdi.Full.Micro.Service.Entities;
using Pdi.Full.Micro.Service.Repositories.Abstractions;

namespace Pdi.Full.Micro.Service.Repositories
{
    public class UsuarioRepository : IUsuarioRepository
    {
        private IEnumerable<Usuario> _usuarios = new List<Usuario>();

        public async Task<IEnumerable<Usuario>> ObterAsync(CancellationToken cancellationToken)
        {
            cancellationToken.ThrowIfCancellationRequested();
            
            if (_usuarios.Count() == decimal.Zero) PreencherUsuarios();
            return await Task.FromResult(_usuarios);
        }

        public async Task<Usuario> ObterAsync(string nomeDeUsuario, CancellationToken cancellationToken)
        {
            cancellationToken.ThrowIfCancellationRequested();
            
            if (_usuarios.Count() == decimal.Zero) PreencherUsuarios();

            return await Task.FromResult(_usuarios.FirstOrDefault(x => x.NomeDeUsuario == nomeDeUsuario));
        }

        public async Task<Usuario> AdicionarAsync(Usuario novoUsuario, CancellationToken cancellationToken)
        {
            cancellationToken.ThrowIfCancellationRequested();
            
            _usuarios = _usuarios.Append(novoUsuario);

            return await Task.FromResult(novoUsuario);
        }

        public async Task<Usuario> AtualizarAsync(Usuario usuarioAtualizado, CancellationToken cancellationToken)
        {
            cancellationToken.ThrowIfCancellationRequested();

            var usuariosNaoAfetados = _usuarios.Where(x => x.NomeDeUsuario != usuarioAtualizado.NomeDeUsuario);
            _usuarios = usuariosNaoAfetados.Append(usuarioAtualizado);

            return await Task.FromResult(usuarioAtualizado);
        }

        public async Task<bool> RemoverAsync(string nomeDeUsuario, CancellationToken cancellationToken)
        {
            cancellationToken.ThrowIfCancellationRequested();

            _usuarios = _usuarios.Where(x => x.NomeDeUsuario != nomeDeUsuario);

            return await Task.FromResult(_usuarios.All(x => x.NomeDeUsuario != nomeDeUsuario));
        }

        private void PreencherUsuarios()
        {
            _usuarios = _usuarios.Append(new Usuario { Email = "admin@softplan.com.br", NomeDeUsuario = "admin", Senha = "admin", Role = "admin"});
            _usuarios = _usuarios.Append(new Usuario { Email = "user@softplan.com.br", NomeDeUsuario = "user", Senha = "user", Role = "user"});
            _usuarios = _usuarios.Append(new Usuario { Email = "guest@softplan.com.br", NomeDeUsuario = "guest", Senha = "guest", Role = "user"});
        }
    }
}