using AspNetCoreRateLimit;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Nito.AsyncEx.Synchronous;
using System;

namespace EasyAbp.Abp.AspNetCoreRateLimit.Ip
{
    /// <summary>
    ///     Extends <see cref="IHostBuilder"/> with Limiter configuration methods.
    /// </summary>
    public static class AbpLimiterHostBuilderExtensions
    {
        /// <summary>
        ///     Sets Ip Limiter provider  
        /// </summary>
        /// <param name="builder">The host builder to configure.</param>
        /// <returns>The host builder.</returns>
        public static IHostBuilder UseAspNetCoreRateLimitIp(this IHostBuilder builder)
        {
            if (builder == null) throw new ArgumentNullException(nameof(builder));
            builder.ConfigureServices((_, services) =>
            {
                var provider = services.BuildServiceProvider();
                using var scope = provider.CreateScope();
                // get the IpPolicyStore instance
                var ipPolicyStore = scope.ServiceProvider.GetRequiredService<IIpPolicyStore>();
                // seed IP data from appsettingsi
                ipPolicyStore.SeedAsync().WaitAndUnwrapException();
            });
            return builder;
        }
    }
}
