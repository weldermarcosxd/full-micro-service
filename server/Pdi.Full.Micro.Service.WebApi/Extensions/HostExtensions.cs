using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Pdi.Full.Micro.Service.Repositories.Contexts;

namespace Pdi.Full.Micro.Service.WebApi.Extensions
{
    public static class HostExtensions
    {
        public static void AtualizarBancoDeDados(this IHost host)
        {
            using var scope = host.Services.CreateScope();
            var db = scope.ServiceProvider.GetRequiredService<FullServiceDbContext>();
            db.Database.EnsureDeleted();
            db.Database.EnsureCreated();
        }
    }
}