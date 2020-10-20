using abpWorkerServiceDemo.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace abpWorkerServiceDemo.Controllers
{
    /* Inherit your controllers from this class.
     */
    public abstract class abpWorkerServiceDemoController : AbpController
    {
        protected abpWorkerServiceDemoController()
        {
            LocalizationResource = typeof(abpWorkerServiceDemoResource);
        }
    }
}