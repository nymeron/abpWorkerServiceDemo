using abpWorkerServiceDemo.Demo;
using Microsoft.EntityFrameworkCore;
using Volo.Abp;
using Volo.Abp.EntityFrameworkCore.Modeling;

namespace abpWorkerServiceDemo.EntityFrameworkCore
{
    public static class abpWorkerServiceDemoDbContextModelCreatingExtensions
    {
        public static void ConfigureabpWorkerServiceDemo(this ModelBuilder builder)
        {
            Check.NotNull(builder, nameof(builder));

            /* Configure your own tables/entities inside here */

            builder.Entity<DemoEntity>(b =>
            {
                b.ToTable(abpWorkerServiceDemoConsts.DbTablePrefix + "DemoEntities", abpWorkerServiceDemoConsts.DbSchema);
                b.ConfigureByConvention(); //auto configure for the base class props
                //...
            });
        }
    }
}