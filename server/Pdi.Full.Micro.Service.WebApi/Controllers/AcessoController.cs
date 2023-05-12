using System.Threading;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Pdi.Full.Micro.Service.Entities;
using Pdi.Full.Micro.Service.Services.Abstractions;

namespace Pdi.Full.Micro.Service.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AcessoController : ControllerBase
    {
        private readonly IUsuarioService _usuarioService;

        public AcessoController(IUsuarioService usuarioService)
        {
            _usuarioService = usuarioService;
        }

        [HttpGet]
        public async Task<IActionResult> Get(CancellationToken cancellationToken)
        {
            cancellationToken.ThrowIfCancellationRequested();
            
            var usuarios = await _usuarioService.ObterAsync(cancellationToken);
            return Ok(usuarios);
        }

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
