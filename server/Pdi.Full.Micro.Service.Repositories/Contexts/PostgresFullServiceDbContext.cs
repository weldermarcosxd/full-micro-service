using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Pdi.Full.Micro.Service.Bus.RabbitMqImplementations;

namespace Pdi.Full.Micro.Service.Repositories.Contexts
{
    public class PostgresFullServiceDbContext : FullServiceDbContext
    {
        private readonly IConfiguration _configuration;
        public PostgresFullServiceDbContext(IConfiguration configuration)
        {
            _configuration = configuration;
        }
        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.LogTo(Console.WriteLine);
            options.EnableSensitiveDataLogging();
            var stringDeConexao = _configuration.ObterStringDeConexaoPostgres();
            options.UseNpgsql(stringDeConexao, b => b.MigrationsAssembly("Pdi.Full.Micro.Service.WebApi"));
        }
    }
}