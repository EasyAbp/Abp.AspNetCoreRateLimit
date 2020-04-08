using AspNetCoreRateLimit;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Nito.AsyncEx.Synchronous;
using System;
using static EasyAbp.Abp.AspNetCoreRateLimit.RateLimitType;

namespace EasyAbp.Abp.AspNetCoreRateLimit
{
    /// <summary>
    ///     Extends <see cref="IHostBuilder"/> with Limiter configuration methods.
    /// </summary>
    public static class AbpLimiterHostBuilderExtensions
    {
        /// <summary>
        ///     Sets Limiter provider  
        /// </summary>
        /// <param name="builder">The host builder to configure.</param>
        /// <param name="type"></param>
        /// <returns>The host builder.</returns>
        public static IHostBuilder UseAbpLimiter(this IHostBuilder builder, RateLimitType type) {
            if (builder == null) throw new ArgumentNullException(nameof(builder));
            builder.ConfigureServices((_, services) =>
            {
                var provider = services.BuildServiceProvider();
                using var scope = provider.CreateScope();
                if (type == All || type == Client)
                {
                    // get the ClientPolicyStore instance
                    var clientPolicyStore = scope.ServiceProvider.GetRequiredService<IClientPolicyStore>();
                    //seed Client data from appsettings
                    clientPolicyStore.SeedAsync().WaitAndUnwrapException();
                }
                if (type == All || type == IP)
                {
                    // get the IpPolicyStore instance
                    var ipPolicyStore = scope.ServiceProvider.GetRequiredService<IIpPolicyStore>();
                    // seed IP data from appsettingsi
                    ipPolicyStore.SeedAsync().WaitAndUnwrapException();
                }
            });
            return builder;
        }
   
    }
}
