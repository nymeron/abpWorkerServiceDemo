using Volo.Abp.Modularity;

namespace abpWorkerServiceDemo
{
    [DependsOn(
        typeof(abpWorkerServiceDemoApplicationModule),
        typeof(abpWorkerServiceDemoDomainTestModule)
        )]
    public class abpWorkerServiceDemoApplicationTestModule : AbpModule
    {

    }
}