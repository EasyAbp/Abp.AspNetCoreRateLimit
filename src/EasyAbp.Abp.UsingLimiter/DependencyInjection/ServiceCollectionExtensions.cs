using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Linq;
using AspNetCoreRateLimit;

namespace EasyAbp.Abp.UsingLimiter.DependencyInjection
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddLimiterService<TRateLimitCounterStore>(this IServiceCollection services,Action<AbpLimiterBuilder> builder) where TRateLimitCounterStore: IRateLimitCounterStore
        {
            var service = services.First(x => x.ServiceType == typeof(IConfiguration));
            var configuration = (IConfiguration)service.ImplementationInstance;
            var bucketBuild = new AbpLimiterBuilder(services, configuration);
            services.AddSingleton(typeof(IRateLimitCounterStore),typeof(TRateLimitCounterStore));
            builder(bucketBuild);
            return services;
        }
    }
}
