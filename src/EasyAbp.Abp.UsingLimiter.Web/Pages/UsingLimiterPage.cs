using Microsoft.AspNetCore.Mvc.Localization;
using Microsoft.AspNetCore.Mvc.Razor.Internal;
using EasyAbp.Abp.UsingLimiter.Localization;
using Volo.Abp.AspNetCore.Mvc.UI.RazorPages;

namespace EasyAbp.Abp.UsingLimiter.Web.Pages
{
    /* Inherit your UI Pages from this class. To do that, add this line to your Pages (.cshtml files under the Page folder):
     * @inherits EasyAbp.Abp.UsingLimiter.Web.Pages.UsingLimiterPage
     */
    public abstract class UsingLimiterPage : AbpPage
    {
        [RazorInject]
        public IHtmlLocalizer<UsingLimiterResource> L { get; set; }
    }
}
