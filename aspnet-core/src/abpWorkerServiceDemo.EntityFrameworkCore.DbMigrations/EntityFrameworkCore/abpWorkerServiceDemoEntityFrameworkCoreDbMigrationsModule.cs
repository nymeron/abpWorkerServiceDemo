using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.Modularity;

namespace abpWorkerServiceDemo.EntityFrameworkCore
{
    [DependsOn(
        typeof(abpWorkerServiceDemoEntityFrameworkCoreModule)
        )]
    public class abpWorkerServiceDemoEntityFrameworkCoreDbMigrationsModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            context.Services.AddAbpDbContext<abpWorkerServiceDemoMigrationsDbContext>();
        }
    }
}
