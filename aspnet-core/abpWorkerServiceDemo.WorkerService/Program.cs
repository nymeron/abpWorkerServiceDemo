using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Serilog;
using Serilog.Events;

namespace abpWorkerServiceDemo.WorkerService
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Log.Logger = new LoggerConfiguration()
                .MinimumLevel.Debug()
                .MinimumLevel.Override("Microsoft", LogEventLevel.Information)
                .MinimumLevel.Override("Volo.Abp", LogEventLevel.Information)
                .Enrich.FromLogContext()
                .WriteTo.Async(c => c.File(Path.Combine(Directory.GetCurrentDirectory(), "Logs/logs.txt")))
                .WriteTo.Async(c => c.Console())
                .CreateLogger();

            try
            {
                Log.Information("Start of worker service");
                CreateHostBuilder(args).Build().Run();
            }
            catch (Exception w)
            {
                Log.Fatal(w, "Host terminated unexpectedly");
            }
            finally
            {
                Log.CloseAndFlush();
            }
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .UseAutofac()
                .UseSerilog()
                .ConfigureServices((hostContext, services) =>
                {
                    //services.AddHostedService<WorkerServiceAppStart>();
                    services.AddApplication<WorkerServiceAppModule>();
                });
    }
}
