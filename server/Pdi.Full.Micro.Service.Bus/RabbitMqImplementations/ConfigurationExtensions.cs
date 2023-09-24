using Microsoft.Extensions.Configuration;

namespace Pdi.Full.Micro.Service.Bus.RabbitMqImplementations
{
    public static class ConfigurationExtensions
    {
        public static string ObterMessageBrokerInstance(this IConfiguration configuration)
            => configuration.GetValue("MESSAGE_QUEUE_SERVER", string.Empty);         
    }
}