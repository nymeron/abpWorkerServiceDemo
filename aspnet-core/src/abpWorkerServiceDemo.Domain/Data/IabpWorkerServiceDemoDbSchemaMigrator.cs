using System.Threading.Tasks;

namespace abpWorkerServiceDemo.Data
{
    public interface IabpWorkerServiceDemoDbSchemaMigrator
    {
        Task MigrateAsync();
    }
}
