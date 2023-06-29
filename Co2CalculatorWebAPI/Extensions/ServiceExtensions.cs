using Contracts;
using Entities;
using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Co2CalculatorWebAPI.Extensions
{
    public static class ServiceExtensions
    {
        public static void ConfigureCors(this IServiceCollection services) =>
             services.AddCors(options =>
             {
                 options.AddPolicy("CorsPolicy", builder =>
                     builder.AllowAnyOrigin()
                     .AllowAnyMethod()
                     .AllowAnyHeader());
             });

        public static void ConfigureIISIntegration(this IServiceCollection services) =>
            services.Configure<IISOptions>(options =>
            {

            });

        //public static void ConfigureLoggerService(this IServiceCollection services) =>
        //    services.AddScoped<ILoggerManager, LoggerManager>();

        public static void ConfigureSqlContext(this IServiceCollection services, IConfiguration configuration) =>
          services.AddDbContext<RepositoryContext>(options =>
            options.UseMySql(configuration.GetConnectionString("ConnectionStringMySql"), 
                ServerVersion.AutoDetect(configuration.GetConnectionString("ConnectionStringMySql")),
                    mySqlOptions =>
                    {
                        mySqlOptions.EnableRetryOnFailure(
                            maxRetryCount: 10,
                            maxRetryDelay: TimeSpan.FromSeconds(30),
                            errorNumbersToAdd: null);

                        mySqlOptions.MigrationsAssembly("Co2CalculatorWebAPI");
                    }));

        public static void ConfigureRepositoryManager(this IServiceCollection services) =>
           services.AddScoped<IRepositoryManager, RepositoryManager>();

    }
}
