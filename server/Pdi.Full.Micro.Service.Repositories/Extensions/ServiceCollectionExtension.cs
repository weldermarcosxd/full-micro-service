using Microsoft.Extensions.DependencyInjection;
using Pdi.Full.Micro.Service.Repositories.Abstractions;

namespace Pdi.Full.Micro.Service.Repositories.Extensions
{
    public static class ServiceCollectionExtension
    {
        public static void AdicionarRepositorios(this IServiceCollection services)
        {
            services.AddSingleton<IUsuarioRepository, UsuarioRepository>();
            services.AddScoped<IProdutoRepository, ProdutoRepository>();
            services.AddScoped<IVendaRepository, VendaRepository>();
        }
    }
}