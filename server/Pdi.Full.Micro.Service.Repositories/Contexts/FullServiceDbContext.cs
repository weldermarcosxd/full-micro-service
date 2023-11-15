using System;
using Microsoft.EntityFrameworkCore;
using Pdi.Full.Micro.Service.Entities.Models;
using Pdi.Full.Micro.Service.Repositories.Extensions;

namespace Pdi.Full.Micro.Service.Repositories.Contexts
{
    public abstract class FullServiceDbContext : DbContext
    {        
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(FullServiceDbContext).Assembly);

            Console.WriteLine("****************" + Environment.GetEnvironmentVariable("ASPNETCORE_ENVIRONMENT"));
            // modelBuilder.Seed();
        }

        public DbSet<Produto> Produtos { get; set; }
        public DbSet<Venda> Vendas { get; set; }
        public DbSet<ItemDaVenda> ItensDasVendas { get; set; }
    }
}