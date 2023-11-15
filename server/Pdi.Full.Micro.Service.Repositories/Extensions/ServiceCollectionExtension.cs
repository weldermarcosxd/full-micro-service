using System;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Pdi.Full.Micro.Service.Repositories.Abstractions;
using Pdi.Full.Micro.Service.Repositories.Contexts;

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

        public static void AdicionarDbContextPorProvider(this IServiceCollection services, IConfiguration configuration)
        {
            var provider = configuration.GetSection("DATABASE_PROVIDER")?.Value ?? "Sqlite";
            if(provider == "Sqlite") 
            {
                services.AddScoped<FullServiceDbContext, SqliteFullServiceDbContext>();
                services.AddDbContext<SqliteFullServiceDbContext>();
            }

            else if(provider == "Postgres") 
            {
                services.AddScoped<FullServiceDbContext, PostgresFullServiceDbContext>();
                services.AddDbContext<PostgresFullServiceDbContext>();
            }
            
            else throw new Exception($"Unsupported provider: {provider}");
        }
    }
}