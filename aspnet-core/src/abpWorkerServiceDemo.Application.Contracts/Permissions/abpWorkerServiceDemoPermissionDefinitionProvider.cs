using abpWorkerServiceDemo.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace abpWorkerServiceDemo.Permissions
{
    public class abpWorkerServiceDemoPermissionDefinitionProvider : PermissionDefinitionProvider
    {
        public override void Define(IPermissionDefinitionContext context)
        {
            var myGroup = context.AddGroup(abpWorkerServiceDemoPermissions.GroupName);

            //Define your own permissions here. Example:
            //myGroup.AddPermission(abpWorkerServiceDemoPermissions.MyPermission1, L("Permission:MyPermission1"));
        }

        private static LocalizableString L(string name)
        {
            return LocalizableString.Create<abpWorkerServiceDemoResource>(name);
        }
    }
}
