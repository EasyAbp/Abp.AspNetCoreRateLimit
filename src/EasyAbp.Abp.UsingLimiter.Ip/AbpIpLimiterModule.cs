using AspNetCoreRateLimit;
using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.Modularity;

namespace EasyAbp.Abp.UsingLimiter.Ip
{
    public class AbpIpLimiterModule: AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            var configuration = context.Services.GetConfiguration();
            // configure ip rate limiting middle-ware
            context.Services.Configure<IpRateLimitOptions>(configuration.GetSection("IpRateLimiting"));
            context.Services.Configure<IpRateLimitPolicies>(configuration.GetSection("IpRateLimitPolicies"));
   
        }
    }
}
