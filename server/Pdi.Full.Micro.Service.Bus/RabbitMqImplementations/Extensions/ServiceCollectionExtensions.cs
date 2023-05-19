using MassTransit;
using Microsoft.Extensions.DependencyInjection;

namespace Pdi.Full.Micro.Service.Bus.RabbitMqImplementations.Extensions
{
    public static class ServiceCollectionExtensions
    {
        public static void AdicionarRabbitMq(this IServiceCollection services)
        {
            services.AddMassTransit(x =>
            {
                x.SetKebabCaseEndpointNameFormatter();
                x.AddConsumers(typeof(Bus).Assembly);
                x.UsingRabbitMq((context, cfg) =>
                {
                    cfg.Host("localhost", "/", h =>
                    {
                        h.Username("guest");
                        h.Password("guest");
                    });
                    cfg.ConfigureEndpoints(context);
                });
            });
        }
    }
}