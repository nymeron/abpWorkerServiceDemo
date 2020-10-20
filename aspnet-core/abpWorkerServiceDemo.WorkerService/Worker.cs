using abpWorkerServiceDemo.Demo;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace abpWorkerServiceDemo.WorkerService
{
    public class Worker: IWorker
    {
        private readonly ILogger<Worker> _logger;
        private readonly DemoService _domainDemoService;

        public Worker(ILogger<Worker> logger,
            DemoService domainDemoService
        )
        {
            _logger = logger;
            _domainDemoService = domainDemoService;
        }

        public async Task DoWork()
        {
            _logger.LogInformation("Worker running at: {time}", DateTimeOffset.Now);
            await _domainDemoService.TestMethod();
        }
    }
}
