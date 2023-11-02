using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;
using Pdi.Full.Micro.Service.WebApi.Extensions;

namespace Pdi.Full.Micro.Service.WebApi
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var host = CreateHostBuilder(args).Build();

            host.AtualizarBancoDeDados();

            host.Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder => { webBuilder.UseStartup<Startup>(); });
    }
}