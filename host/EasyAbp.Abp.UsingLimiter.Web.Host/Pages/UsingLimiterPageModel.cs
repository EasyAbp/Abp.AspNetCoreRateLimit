using EasyAbp.Abp.UsingLimiter.Localization;
using Volo.Abp.AspNetCore.Mvc.UI.RazorPages;

namespace EasyAbp.Abp.UsingLimiter.Pages
{
    public abstract class UsingLimiterPageModel : AbpPageModel
    {
        protected UsingLimiterPageModel()
        {
            LocalizationResourceType = typeof(UsingLimiterResource);
        }
    }
}