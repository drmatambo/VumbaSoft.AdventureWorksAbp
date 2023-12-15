using VumbaSoft.AdventureWorksAbp.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace VumbaSoft.AdventureWorksAbp.Permissions;

public class AdventureWorksAbpPermissionDefinitionProvider : PermissionDefinitionProvider
{
    public override void Define(IPermissionDefinitionContext context)
    {
        var myGroup = context.AddGroup(AdventureWorksAbpPermissions.GroupName);
        //Define your own permissions here. Example:
        //myGroup.AddPermission(AdventureWorksAbpPermissions.MyPermission1, L("Permission:MyPermission1"));
    }

    private static LocalizableString L(string name)
    {
        return LocalizableString.Create<AdventureWorksAbpResource>(name);
    }
}
