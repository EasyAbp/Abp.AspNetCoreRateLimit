using EasyAbp.Abp.UsingLimiter.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace EasyAbp.Abp.UsingLimiter.Authorization
{
    public class UsingLimiterPermissionDefinitionProvider : PermissionDefinitionProvider
    {
        public override void Define(IPermissionDefinitionContext context)
        {
            //var moduleGroup = context.AddGroup(UsingLimiterPermissions.GroupName, L("Permission:UsingLimiter"));
        }

        private static LocalizableString L(string name)
        {
            return LocalizableString.Create<UsingLimiterResource>(name);
        }
    }
}