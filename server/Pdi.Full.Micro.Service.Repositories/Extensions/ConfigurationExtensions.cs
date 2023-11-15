using Microsoft.Extensions.Configuration;

namespace Pdi.Full.Micro.Service.Bus.RabbitMqImplementations
{
    public static class ConfigurationExtensions
    {
        public static string ObterStringDeConexaoPostgres(this IConfiguration configuration)
            => configuration.GetSection("POSTGRES_CONNECTION_STRING")?.Value ?? string.Empty;         
    }
}