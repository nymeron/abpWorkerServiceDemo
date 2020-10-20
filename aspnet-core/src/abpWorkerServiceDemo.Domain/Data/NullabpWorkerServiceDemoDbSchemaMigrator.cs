using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace abpWorkerServiceDemo.Data
{
    /* This is used if database provider does't define
     * IabpWorkerServiceDemoDbSchemaMigrator implementation.
     */
    public class NullabpWorkerServiceDemoDbSchemaMigrator : IabpWorkerServiceDemoDbSchemaMigrator, ITransientDependency
    {
        public Task MigrateAsync()
        {
            return Task.CompletedTask;
        }
    }
}