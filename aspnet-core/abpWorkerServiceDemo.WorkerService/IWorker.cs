using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace abpWorkerServiceDemo.WorkerService
{
    public interface IWorker: ITransientDependency
    {
        Task DoWork();
    }
}
