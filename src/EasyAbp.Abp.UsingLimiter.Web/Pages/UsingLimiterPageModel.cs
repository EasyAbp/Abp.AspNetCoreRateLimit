using EasyAbp.Abp.UsingLimiter.Localization;
using Volo.Abp.AspNetCore.Mvc.UI.RazorPages;

namespace EasyAbp.Abp.UsingLimiter.Web.Pages
{
    /* Inherit your PageModel classes from this class.
     */
    public abstract class UsingLimiterPageModel : AbpPageModel
    {
        protected UsingLimiterPageModel()
        {
            LocalizationResourceType = typeof(UsingLimiterResource);
            ObjectMapperContext = typeof(UsingLimiterWebModule);
        }
    }
}