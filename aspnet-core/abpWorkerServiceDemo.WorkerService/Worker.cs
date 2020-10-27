using abpWorkerServiceDemo.Demo;
using Microsoft.Extensions.Logging;
using System;
using System.Threading.Tasks;

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
            try
            {
                _logger.LogInformation("Worker running at: {time}", DateTimeOffset.Now);
                await _domainDemoService.TestMethod();

                await _domainDemoService.TestBreakMethod();
            }
            catch (Exception w)
            {
                _logger.LogError(w, "Worker encountered exception");
            }
        }
    }
}
