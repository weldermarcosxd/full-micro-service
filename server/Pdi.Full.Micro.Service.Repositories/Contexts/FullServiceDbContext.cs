using System;
using Microsoft.EntityFrameworkCore;
using Pdi.Full.Micro.Service.Entities.Models;
using Pdi.Full.Micro.Service.Repositories.Extensions;

namespace Pdi.Full.Micro.Service.Repositories.Contexts
{
    public class FullServiceDbContext : DbContext
    {
        private readonly string _dbPath;
        
        public FullServiceDbContext()
        {
            var pasta = Environment.SpecialFolder.LocalApplicationData;
            var path = Environment.GetFolderPath(pasta);
            _dbPath = System.IO.Path.Join(path, "full-service.db");
        }
        
        protected override void OnConfiguring(DbContextOptionsBuilder options)
            => options.UseSqlite($"Data Source={_dbPath}", b => b.MigrationsAssembly("Pdi.Full.Micro.Service.WebApi"));

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(FullServiceDbContext).Assembly);
            
            Console.WriteLine("****************" + Environment.GetEnvironmentVariable("Enviroment"));
            modelBuilder.Seed();
        }

        public DbSet<Produto> Produtos { get; set; }
        public DbSet<Venda> Vendas { get; set; }
        public DbSet<ItemDaVenda> ItensDasVendas { get; set; }
    }
}