using System;
using System.Linq;
using System.Threading.Tasks;
using Volo.Abp.Domain.Repositories;
using Volo.Abp.Domain.Services;

namespace abpWorkerServiceDemo.Demo
{
    public class DemoService: DomainService
    {
        private readonly IRepository<DemoEntity, Guid> _demoEntitiesRepository;
        public DemoService(IRepository<DemoEntity, Guid> demoEntitiesRepository)
        {            
            _demoEntitiesRepository = demoEntitiesRepository;
        }

        public async Task TestMethod()
        {
            var entities = await _demoEntitiesRepository.GetListAsync();
        }
        public async Task TestBreakMethod()
        {           
            var entity = await AsyncExecuter.FirstOrDefaultAsync(_demoEntitiesRepository);
        }
    }
}
