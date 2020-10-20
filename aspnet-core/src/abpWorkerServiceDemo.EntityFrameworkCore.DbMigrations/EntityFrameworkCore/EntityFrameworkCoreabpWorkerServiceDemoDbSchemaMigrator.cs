using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using abpWorkerServiceDemo.Data;
using Volo.Abp.DependencyInjection;

namespace abpWorkerServiceDemo.EntityFrameworkCore
{
    public class EntityFrameworkCoreabpWorkerServiceDemoDbSchemaMigrator
        : IabpWorkerServiceDemoDbSchemaMigrator, ITransientDependency
    {
        private readonly IServiceProvider _serviceProvider;

        public EntityFrameworkCoreabpWorkerServiceDemoDbSchemaMigrator(
            IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
        }

        public async Task MigrateAsync()
        {
            /* We intentionally resolving the abpWorkerServiceDemoMigrationsDbContext
             * from IServiceProvider (instead of directly injecting it)
             * to properly get the connection string of the current tenant in the
             * current scope.
             */

            await _serviceProvider
                .GetRequiredService<abpWorkerServiceDemoMigrationsDbContext>()
                .Database
                .MigrateAsync();
        }
    }
}