using abpWorkerServiceDemo.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Domain.Repositories;
using Volo.Abp.Domain.Services;
using Volo.Abp.Identity;

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

    }
}
