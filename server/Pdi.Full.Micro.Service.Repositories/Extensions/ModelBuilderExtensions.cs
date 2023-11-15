using System;
using Microsoft.EntityFrameworkCore;
using Pdi.Full.Micro.Service.Entities.Models;
using Pdi.Full.Micro.Service.Repositories.Fakers;

namespace Pdi.Full.Micro.Service.Repositories.Extensions
{
    internal static class ModelBuilderExtensions
    {
        internal static void Seed(this ModelBuilder modelBuilder)
        {
            Console.WriteLine($"---------------------------------------------------- Inserindo Dados Iniciais ----------------------------------------------------");
            modelBuilder.Entity<Produto>().HasData(ProdutoFaker.Faker().Generate(1_000));
        }
    }
}