using Microsoft.AspNetCore.Mvc.Localization;
using Microsoft.AspNetCore.Mvc.Razor.Internal;
using EasyAbp.Abp.UsingLimiter.Localization;
using Volo.Abp.AspNetCore.Mvc.UI.RazorPages;

namespace EasyAbp.Abp.UsingLimiter.Pages
{
    public abstract class UsingLimiterPage : AbpPage
    {
        [RazorInject]
        public IHtmlLocalizer<UsingLimiterResource> L { get; set; }
    }
}
