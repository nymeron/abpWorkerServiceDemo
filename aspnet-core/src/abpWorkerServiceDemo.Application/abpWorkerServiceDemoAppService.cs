using System;
using System.Collections.Generic;
using System.Text;
using abpWorkerServiceDemo.Localization;
using Volo.Abp.Application.Services;

namespace abpWorkerServiceDemo
{
    /* Inherit your application services from this class.
     */
    public abstract class abpWorkerServiceDemoAppService : ApplicationService
    {
        protected abpWorkerServiceDemoAppService()
        {
            LocalizationResource = typeof(abpWorkerServiceDemoResource);
        }
    }
}
