using System.Threading.Tasks;
using Volo.Abp.Application.Services;

namespace abpWorkerServiceDemo.Demo
{
    public class DemoAppService: ApplicationService
    {
        private readonly DemoService demoService;

        public DemoAppService(DemoService demoService)
        {
            this.demoService = demoService;
        }

        public async Task GetDemoEntity()
        {
            await this.demoService.TestMethod();
        }

        public async Task GetDemoBreakEntity()
        {
            await this.demoService.TestBreakMethod();
        }
    }
}
