using Microsoft.EntityFrameworkCore;
using Volo.Abp;

namespace abpWorkerServiceDemo.EntityFrameworkCore
{
    public static class abpWorkerServiceDemoDbContextModelCreatingExtensions
    {
        public static void ConfigureabpWorkerServiceDemo(this ModelBuilder builder)
        {
            Check.NotNull(builder, nameof(builder));

            /* Configure your own tables/entities inside here */

            //builder.Entity<YourEntity>(b =>
            //{
            //    b.ToTable(abpWorkerServiceDemoConsts.DbTablePrefix + "YourEntities", abpWorkerServiceDemoConsts.DbSchema);
            //    b.ConfigureByConvention(); //auto configure for the base class props
            //    //...
            //});
        }
    }
}