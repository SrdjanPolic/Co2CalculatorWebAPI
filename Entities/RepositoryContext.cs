using Entities.Configuration;
using Entities.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Pomelo.EntityFrameworkCore.MySql.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class RepositoryContext : DbContext
    {
        protected readonly IConfiguration Configuration;

        public RepositoryContext()
        {
            
        }

        public RepositoryContext(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new CompanyConfiguration());
            modelBuilder.ApplyConfiguration(new EmployeeConfiguration());
        }

        public DbSet<Company> Companies { get; set; }
        public DbSet<Employee> Employees { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            // connect to mysql with connection string from app settings
            var connectionString = Configuration.GetConnectionString("ConnectionStringMySql");
            options.UseMySql(connectionString, ServerVersion.AutoDetect(connectionString),
                mySqlOptions =>
                {
                    mySqlOptions.EnableRetryOnFailure(
                        maxRetryCount: 10,
                        maxRetryDelay: TimeSpan.FromSeconds(30),
                        errorNumbersToAdd: null);

                    mySqlOptions.MigrationsAssembly("Co2CalculatorWebAPI");
                });

            // Throw an exception, if a schema is being used. This is the default.
            options.UseMySql(ServerVersion.AutoDetect(connectionString), b => b.SchemaBehavior(MySqlSchemaBehavior.Throw));

            // Silently ignore any schema definitions.
            options.UseMySql(ServerVersion.AutoDetect(connectionString), b => b.SchemaBehavior(MySqlSchemaBehavior.Ignore));

            // Use the specified translator delegate to translate from an input schema and object name to
            // an output object name whenever a schema is being used.
            options.UseMySql(ServerVersion.AutoDetect(connectionString), b => b.SchemaBehavior(MySqlSchemaBehavior.Translate,
            (schema, entity) => $"{schema ?? "dbo"}_{entity}"));
        }
    }
}
