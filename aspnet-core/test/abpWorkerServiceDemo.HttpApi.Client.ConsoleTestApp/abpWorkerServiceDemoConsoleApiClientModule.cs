using Volo.Abp.Http.Client.IdentityModel;
using Volo.Abp.Modularity;

namespace abpWorkerServiceDemo.HttpApi.Client.ConsoleTestApp
{
    [DependsOn(
        typeof(abpWorkerServiceDemoHttpApiClientModule),
        typeof(AbpHttpClientIdentityModelModule)
        )]
    public class abpWorkerServiceDemoConsoleApiClientModule : AbpModule
    {
        
    }
}
