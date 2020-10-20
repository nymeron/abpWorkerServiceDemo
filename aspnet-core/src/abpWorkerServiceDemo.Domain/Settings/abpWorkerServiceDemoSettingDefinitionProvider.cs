using Volo.Abp.Settings;

namespace abpWorkerServiceDemo.Settings
{
    public class abpWorkerServiceDemoSettingDefinitionProvider : SettingDefinitionProvider
    {
        public override void Define(ISettingDefinitionContext context)
        {
            //Define your own settings here. Example:
            //context.Add(new SettingDefinition(abpWorkerServiceDemoSettings.MySetting1));
        }
    }
}
