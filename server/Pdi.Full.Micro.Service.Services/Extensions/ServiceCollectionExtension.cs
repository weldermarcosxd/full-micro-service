using Microsoft.Extensions.DependencyInjection;
using Pdi.Full.Micro.Service.Repositories.Abstractions;
using Pdi.Full.Micro.Service.Services.Abstractions;

namespace Pdi.Full.Micro.Service.Services.Extensions
{
    public static class ServiceCollectionExtension
    {
        public static void AdicionarServicos(this IServiceCollection services)
        {
            services.AddScoped<IUsuarioService, UsuarioService>();
        }
    }
}