using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Pdi.Full.Micro.Service.Entities.Models;
using Pdi.Full.Micro.Service.Services.Abstractions;

namespace Pdi.Full.Micro.Service.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class VendaController : ControllerBase
    {
        private readonly IVendaService _vendaService;

        public VendaController(IVendaService vendaService)
        {
            _vendaService = vendaService;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Venda>>> GetVendas(CancellationToken cancellationToken)
        {
            var vendas = await _vendaService.ObterAsync(cancellationToken);

            return Ok(vendas);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Venda>> GetVenda(Guid id, CancellationToken cancellationToken)
        {
            var venda = await _vendaService.ObterAsync(id, cancellationToken);

            if (venda == null)
            {
                return NotFound();
            }

            return Ok(venda);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> PutVenda(Guid id, CancellationToken cancellationToken)
        {
            var venda = await _vendaService.EstornarAsync(id, cancellationToken);

            return Ok(venda);
        }

        [HttpPost]
        public async Task<ActionResult<Venda>> PostVenda(Venda venda, CancellationToken cancellationToken)
        {
            await _vendaService.CadastrarAsync(venda, cancellationToken);
            
            return CreatedAtAction("GetVenda", new { id = venda.Id }, venda);
        }
    }
}
