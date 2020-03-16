using EasyAbp.Abp.UsingLimiter.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace EasyAbp.Abp.UsingLimiter
{
    public abstract class UsingLimiterController : AbpController
    {
        protected UsingLimiterController()
        {
            LocalizationResource = typeof(UsingLimiterResource);
        }
    }
}
