using AspNetCoreRateLimit;
using EasyAbp.Abp.AspNetCoreRateLimit.DependencyInjection;
using Microsoft.Extensions.DependencyInjection;

namespace EasyAbp.Abp.AspNetCoreRateLimit.Client.DependencyInjection
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddLimiterClientService<TPolicyStore>(this IAbpLimiterBuilder builder)where TPolicyStore: IClientPolicyStore
        {
            return AddLimiterClientService<TPolicyStore>(builder.Services);
        }

        public static IServiceCollection AddLimiterClientService<TPolicyStore>(this IServiceCollection services) where TPolicyStore : IClientPolicyStore
        {
            services.AddSingleton(typeof(IClientPolicyStore), typeof(TPolicyStore));
            return services;
        }
    }
}
