using Volo.Abp.AspNetCore.Mvc.UI.Theme.Shared.Components;
using Volo.Abp.DependencyInjection;

namespace EasyAbp.Abp.UsingLimiter
{
    [Dependency(ReplaceServices = true)]
    public class UsingLimiterBrandingProvider : DefaultBrandingProvider
    {
        public override string AppName => "UsingLimiter";
    }
}
