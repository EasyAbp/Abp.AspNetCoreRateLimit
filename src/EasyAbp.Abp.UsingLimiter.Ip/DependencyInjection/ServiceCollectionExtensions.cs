using AspNetCoreRateLimit;
using EasyAbp.Abp.UsingLimiter.DependencyInjection;
using Microsoft.Extensions.DependencyInjection;

namespace EasyAbp.Abp.UsingLimiter.Ip.DependencyInjection
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddLimiterIpService<TPolicyStore>(this IAbpLimiterBuilder builder) where TPolicyStore : IIpPolicyStore
        {
            return AddLimiterIpService<TPolicyStore>(builder.Services);
        }

        public static IServiceCollection AddLimiterIpService<TPolicyStore>(this IServiceCollection services) where TPolicyStore : IIpPolicyStore
        {
            services.AddSingleton(typeof(IIpPolicyStore), typeof(TPolicyStore));
            return services;
        }
    }
}
