using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Pdi.Full.Micro.Service.Entities.Dtos;
using Pdi.Full.Micro.Service.Entities.Models;
using Pdi.Full.Micro.Service.Services.Abstractions;

namespace Pdi.Full.Micro.Service.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProdutoController : ControllerBase
    {
        private readonly IProdutoService _produtoService;

        public ProdutoController(IProdutoService produtoService)
        {
            _produtoService = produtoService;
        }

        [HttpGet]
        public async Task<ActionResult<RespostaPaginada<ProdutoDto>>> GetProdutos([FromQuery] FiltroDePaginacao filtro, CancellationToken cancellationToken)
        {
            var filtroLimitado = new FiltroDePaginacao(filtro.NumeroDaPagina, filtro.TamanhoDaPagina);
            var produtos = await _produtoService.ObterAsync(filtroLimitado, cancellationToken);
            return Ok(produtos);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Produto>> GetProduto(Guid id, CancellationToken cancellationToken)
        {
            var produto = await _produtoService.ObterAsync(id, cancellationToken);

            if (produto == null)
                return NotFound();

            return Ok(produto);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> PutProduto(Guid id, Produto produto, CancellationToken cancellationToken)
        {
            if (id != produto.Id)
                return BadRequest();

            await _produtoService.AtualizarAsync(id, produto, cancellationToken);

            return Ok();
        }

        [HttpPost]
        public async Task<ActionResult<Produto>> PostProduto(Produto produto, CancellationToken cancellationToken)
        {
            await _produtoService.AdicionarAsync(produto, cancellationToken);

            return CreatedAtAction("GetProduto", new { id = produto.Id }, produto);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<Produto>> DeleteProduto(Guid id, CancellationToken cancellationToken)
        {
            await _produtoService.RemoverAsync(id, cancellationToken);

            return NoContent();
        }
    }
}
