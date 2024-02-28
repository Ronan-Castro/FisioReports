using FisioMetric.Data.Mapping;
using FisioMetric.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace FisioMetric.Data
{
    public class SqliteDbContext : DbContext
    {
        public DbSet<Paciente> Pacientes { get; set; }
        public DbSet<Avaliacao> Avaliacoes { get; set; }
        public DbSet<Evolucao> Evolucoes { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("FileName=fisioreports.db", option =>
            {
                option.MigrationsAssembly(Assembly.GetExecutingAssembly().FullName);
            });
            base.OnConfiguring(optionsBuilder);

            var loggerFactory = LoggerFactory.Create(builder =>
            {
                builder
                    .AddConsole();
                
            });

            optionsBuilder.EnableSensitiveDataLogging();

            optionsBuilder.UseLoggerFactory(loggerFactory);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new EvolucaoMap());
            modelBuilder.ApplyConfiguration(new AvaliacaoMap());
            modelBuilder.ApplyConfiguration(new PacientMap());
            base.OnModelCreating(modelBuilder);
        }
    }
}
