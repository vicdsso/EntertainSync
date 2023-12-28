using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using EntertainSync.Models;

namespace EntertainSync.Data
{
    public class Contexto : DbContext
    {
        public DbSet<Add> Adds { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                // Obtenha a configuração do arquivo appsettings.json
                IConfigurationRoot configuration = new ConfigurationBuilder()
                    .SetBasePath(AppDomain.CurrentDomain.BaseDirectory)
                    .AddJsonFile("appsettings.json")
                    .Build();

                // Configure a string de conexão
                string connectionString = configuration.GetConnectionString("DefaultConnection");

                // Use a string de conexão configurada
                optionsBuilder.UseSqlServer(connectionString);
            }
        }
    }
}
