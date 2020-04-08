using AspNetCoreRateLimit;
using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.Modularity;

namespace EasyAbp.Abp.AspNetCoreRateLimit.Client
{
    [DependsOn(typeof(AbpLimiterModule))]
    public class AbpClientLimiterModule: AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            var configuration = context.Services.GetConfiguration();
            // configure client rate limiting middleware
            context.Services.Configure<ClientRateLimitOptions>(configuration.GetSection("ClientRateLimiting"));
            context.Services.Configure<ClientRateLimitPolicies>(configuration.GetSection("ClientRateLimitPolicies"));
        }

    }
}
