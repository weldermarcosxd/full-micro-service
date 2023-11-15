using System;
using Microsoft.EntityFrameworkCore;

namespace Pdi.Full.Micro.Service.Repositories.Contexts
{
    public class SqliteFullServiceDbContext : FullServiceDbContext
    {
        private readonly string _dbPath;

        public SqliteFullServiceDbContext()
        {
            var pasta = Environment.CurrentDirectory;
            _dbPath = System.IO.Path.Join(pasta, "full-service.db");
        }
        
        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlite($"Data Source={_dbPath}", b => b.MigrationsAssembly("Pdi.Full.Micro.Service.WebApi"));
        }
    }
}