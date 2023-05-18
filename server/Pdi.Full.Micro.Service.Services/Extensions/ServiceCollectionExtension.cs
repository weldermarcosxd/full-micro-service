using Microsoft.Extensions.DependencyInjection;
using Pdi.Full.Micro.Service.Services.Abstractions;
using Pdi.Full.Micro.Service.Services.Produtos;
using Pdi.Full.Micro.Service.Services.Relatorios;
using Pdi.Full.Micro.Service.Services.Tokens;
using Pdi.Full.Micro.Service.Services.Usuarios;
using Pdi.Full.Micro.Service.Services.Vendas;

namespace Pdi.Full.Micro.Service.Services.Extensions
{
    public static class ServiceCollectionExtension
    {
        public static void AdicionarServicos(this IServiceCollection services)
        {
            services.AddScoped<IUsuarioService, UsuarioService>();
            services.AddScoped<ITokenService, TokenService>();
            services.AddScoped<IProdutoService, ProdutoService>();
            services.AddScoped<IVendaService, VendaService>();
            services.AddScoped<IRelatorioDeVendasService, RelatorioDeVendasService>();
        }
    }
}