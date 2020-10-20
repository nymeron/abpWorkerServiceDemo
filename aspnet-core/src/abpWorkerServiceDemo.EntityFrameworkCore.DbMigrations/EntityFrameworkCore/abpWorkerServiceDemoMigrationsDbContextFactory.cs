using System.IO;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace abpWorkerServiceDemo.EntityFrameworkCore
{
    /* This class is needed for EF Core console commands
     * (like Add-Migration and Update-Database commands) */
    public class abpWorkerServiceDemoMigrationsDbContextFactory : IDesignTimeDbContextFactory<abpWorkerServiceDemoMigrationsDbContext>
    {
        public abpWorkerServiceDemoMigrationsDbContext CreateDbContext(string[] args)
        {
            abpWorkerServiceDemoEfCoreEntityExtensionMappings.Configure();

            var configuration = BuildConfiguration();

            var builder = new DbContextOptionsBuilder<abpWorkerServiceDemoMigrationsDbContext>()
                .UseSqlServer(configuration.GetConnectionString("Default"));

            return new abpWorkerServiceDemoMigrationsDbContext(builder.Options);
        }

        private static IConfigurationRoot BuildConfiguration()
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(Path.Combine(Directory.GetCurrentDirectory(), "../abpWorkerServiceDemo.DbMigrator/"))
                .AddJsonFile("appsettings.json", optional: false);

            return builder.Build();
        }
    }
}
