using System.Threading;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Pdi.Full.Micro.Service.Entities;
using Pdi.Full.Micro.Service.Services.Abstractions;

namespace Pdi.Full.Micro.Service.WebApi.Controllers
{
    [Route("api/[controller]")]
    [Authorize]
    [ApiController]
    public class AcessoController : ControllerBase
    {
        private readonly IUsuarioService _usuarioService;
        private readonly ITokenService _tokenService;

        public AcessoController(IUsuarioService usuarioService, ITokenService tokenService)
        {
            _usuarioService = usuarioService;
            _tokenService = tokenService;
        }
        
        [HttpPost]
        [Route("login")]
        [AllowAnonymous]
        public async Task<ActionResult<dynamic>> Authenticate([FromBody]Usuario login, CancellationToken cancellationToken)
        {
            var usuario = await _usuarioService.ObterAsync(login.NomeDeUsuario, cancellationToken);

            if (usuario == null)
                return BadRequest(new { message = "Usuário ou senha inválidos" });

            var token = _tokenService.GerarToken(usuario);
            usuario.Senha = "";
            return new { user = usuario, token };
        }

        [HttpGet]
        public async Task<IActionResult> Get(CancellationToken cancellationToken)
        {
            cancellationToken.ThrowIfCancellationRequested();
            
            var usuarios = await _usuarioService.ObterAsync(cancellationToken);
            return Ok(usuarios);
        }

        [Authorize]
        [HttpGet("{nomeDeUsuario}", Name = "Get")]
        public async Task<IActionResult> Get(string nomeDeUsuario,CancellationToken cancellationToken)
        {
            cancellationToken.ThrowIfCancellationRequested();
            
            var usuario = await _usuarioService.ObterAsync(nomeDeUsuario, cancellationToken);
            return usuario is null ? (IActionResult)NotFound() : Ok(usuario);
        }

        [HttpPost]
        public async Task<IActionResult> Post([FromBody] Usuario usuarioNovo, CancellationToken cancellationToken)
        {
            cancellationToken.ThrowIfCancellationRequested();
            
            var usuarioAdicionado = await _usuarioService.AdicionarAsync(usuarioNovo, cancellationToken);
            return Created(usuarioNovo.NomeDeUsuario, usuarioAdicionado);
        }

        [HttpPut("{nomeDeUsuario}")]
        public async Task<IActionResult> Put(string nomeDeUsuario, [FromBody] Usuario usuarioAlterado, CancellationToken cancellationToken)
        {
            cancellationToken.ThrowIfCancellationRequested();

            var usuarioAtualizado = await _usuarioService.AtualizarAsync(nomeDeUsuario, usuarioAlterado, cancellationToken);

            return Ok(usuarioAtualizado);
        }

        [HttpDelete("{nomeDeUsuario}")]
        public async Task<IActionResult> Delete(string nomeDeUsuario, CancellationToken cancellationToken)
        {
            cancellationToken.ThrowIfCancellationRequested();

            var removido = await _usuarioService.RemoverAsync(nomeDeUsuario, cancellationToken);

            if (removido) return NoContent();
            
            return BadRequest();
        }
    }
}
