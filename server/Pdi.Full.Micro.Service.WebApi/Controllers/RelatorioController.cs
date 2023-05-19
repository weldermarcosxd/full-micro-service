using System;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Pdi.Full.Micro.Service.Services.Abstractions;

namespace Pdi.Full.Micro.Service.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RelatorioController : ControllerBase
    {
        private readonly IRelatorioDeVendasService _relatorioDeVendasService;

        public RelatorioController(IRelatorioDeVendasService relatorioDeVendasService)
        {
            _relatorioDeVendasService = relatorioDeVendasService;
        }

        [HttpGet]
        public async Task<FileResult> Get(CancellationToken cancelationToken)
        {
            var relatorio = await _relatorioDeVendasService.ObterAsync(cancelationToken);
            return new FileContentResult(relatorio, "application/pdf");
        }
    }
}
