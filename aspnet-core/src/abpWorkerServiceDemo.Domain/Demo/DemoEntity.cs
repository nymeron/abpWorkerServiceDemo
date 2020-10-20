using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Domain.Entities;

namespace abpWorkerServiceDemo.Demo
{
    public class DemoEntity: Entity<Guid>
    {
        public string Name { get; set; }
    }
}
