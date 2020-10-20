using abpWorkerServiceDemo.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.Autofac;
using Volo.Abp.Data;
using Volo.Abp.Modularity;

namespace abpWorkerServiceDemo.WorkerService
{
    [DependsOn(
        typeof(AbpAutofacModule),
        typeof(abpWorkerServiceDemoApplicationContractsModule),
        typeof(abpWorkerServiceDemoDomainModule),
        typeof(abpWorkerServiceDemoEntityFrameworkCoreModule)
    )]
    public class WorkerServiceAppModule: AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            var config = context.Services.GetConfiguration();
            Configure<AbpDbConnectionOptions>(options =>
            {
                options.ConnectionStrings.Default = config.GetConnectionString("Default");
            });

            context.Services.AddScoped<IWorker, Worker>();
            context.Services.AddHostedService<WorkerServiceAppStart>();
        }
    }
}
