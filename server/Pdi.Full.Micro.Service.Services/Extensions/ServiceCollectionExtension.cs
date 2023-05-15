using Microsoft.Extensions.DependencyInjection;
using Pdi.Full.Micro.Service.Services.Abstractions;
using Pdi.Full.Micro.Service.Services.Tokens;

namespace Pdi.Full.Micro.Service.Services.Extensions
{
    public static class ServiceCollectionExtension
    {
        public static void AdicionarServicos(this IServiceCollection services)
        {
            services.AddScoped<IUsuarioService, UsuarioService>();
            services.AddScoped<ITokenService, TokenService>();
        }
    }
}