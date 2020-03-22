using AspNetCoreRateLimit;
using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.Modularity;

namespace EasyAbp.Abp.UsingLimiter
{
    public class AbpLimiterModule: AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            context.Services.AddSingleton<IRateLimitConfiguration, RateLimitConfiguration>();
        }
    }
}
