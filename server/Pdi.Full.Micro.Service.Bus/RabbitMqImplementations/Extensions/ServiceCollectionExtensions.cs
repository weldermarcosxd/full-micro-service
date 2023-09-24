using MassTransit;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Pdi.Full.Micro.Service.Bus.RabbitMqImplementations.Extensions
{
    public static class ServiceCollectionExtensions
    {
        public static void AdicionarRabbitMq(this IServiceCollection services, IConfiguration configuration)
        {
            var messageBrokerInstance = configuration.ObterMessageBrokerInstance();

            services.AddMassTransit(x =>
            {
                x.SetKebabCaseEndpointNameFormatter();
                x.AddConsumers(typeof(Bus).Assembly);
                x.UsingRabbitMq((context, cfg) =>
                {
                    cfg.Host(messageBrokerInstance);
                    cfg.ConfigureEndpoints(context);
                });
            });
        }
    }
}