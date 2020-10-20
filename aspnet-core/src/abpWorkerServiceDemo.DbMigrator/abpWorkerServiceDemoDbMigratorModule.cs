using abpWorkerServiceDemo.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.BackgroundJobs;
using Volo.Abp.Modularity;

namespace abpWorkerServiceDemo.DbMigrator
{
    [DependsOn(
        typeof(AbpAutofacModule),
        typeof(abpWorkerServiceDemoEntityFrameworkCoreDbMigrationsModule),
        typeof(abpWorkerServiceDemoApplicationContractsModule)
        )]
    public class abpWorkerServiceDemoDbMigratorModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            Configure<AbpBackgroundJobOptions>(options => options.IsJobExecutionEnabled = false);
        }
    }
}
