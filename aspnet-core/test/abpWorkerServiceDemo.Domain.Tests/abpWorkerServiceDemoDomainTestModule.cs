using abpWorkerServiceDemo.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace abpWorkerServiceDemo
{
    [DependsOn(
        typeof(abpWorkerServiceDemoEntityFrameworkCoreTestModule)
        )]
    public class abpWorkerServiceDemoDomainTestModule : AbpModule
    {

    }
}