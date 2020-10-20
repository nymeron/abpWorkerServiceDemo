using System;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Volo.Abp;

namespace abpWorkerServiceDemo.WorkerService
{
    public class WorkerServiceAppStart : BackgroundService
    {
        private readonly ILogger<WorkerServiceAppStart> _logger;
        private readonly IAbpApplicationWithExternalServiceProvider _application;
        private readonly IServiceProvider _serviceProvider;
        private readonly IServiceScopeFactory _serviceScopeFactory;

        public WorkerServiceAppStart(
            ILogger<WorkerServiceAppStart> logger,
            IAbpApplicationWithExternalServiceProvider application,
            IServiceProvider serviceProvider,
            IServiceScopeFactory serviceScopeFactory
            )
        {
            _application = application;
            _serviceProvider = serviceProvider;
            _serviceScopeFactory = serviceScopeFactory;
            _logger = logger;
        }

        public override Task StartAsync(CancellationToken cancellationToken)
        {
            _logger.LogInformation("Initialization ...");
            _application.Initialize(_serviceProvider);
            return base.StartAsync(cancellationToken);  
        }

        public override Task StopAsync(CancellationToken cancellationToken)
        {
            _logger.LogInformation("Shutdown...");
            _application.Shutdown();
            return base.StopAsync(cancellationToken);
        }

        protected override async Task ExecuteAsync(CancellationToken stoppingToken)
        {
            while (!stoppingToken.IsCancellationRequested)
            {
                var scope = _serviceScopeFactory.CreateScope();
                var worker = scope.ServiceProvider.GetRequiredService<Worker>();
                await worker.DoWork();
                await Task.Delay(5000, stoppingToken);
            }
        }
    }
}
