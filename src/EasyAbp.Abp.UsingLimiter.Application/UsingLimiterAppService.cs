using EasyAbp.Abp.UsingLimiter.Localization;
using Volo.Abp.Application.Services;

namespace EasyAbp.Abp.UsingLimiter
{
    public abstract class UsingLimiterAppService : ApplicationService
    {
        protected UsingLimiterAppService()
        {
            LocalizationResource = typeof(UsingLimiterResource);
            ObjectMapperContext = typeof(UsingLimiterApplicationModule);
        }
    }
}
