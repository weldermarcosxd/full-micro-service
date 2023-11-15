using Microsoft.Extensions.Configuration;

namespace Pdi.Full.Micro.Service.Bus.RabbitMqImplementations
{
    public static class ConfigurationExtensions
    {
        public static string ObterMessageBrokerInstance(this IConfiguration configuration)
            => configuration.GetSection("MESSAGE_QUEUE_SERVER")?.Value ?? string.Empty;         
    }
}