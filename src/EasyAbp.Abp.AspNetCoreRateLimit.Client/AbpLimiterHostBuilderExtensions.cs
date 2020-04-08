using AspNetCoreRateLimit;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using Nito.AsyncEx.Synchronous;

namespace EasyAbp.Abp.UsingLimiter.Client
{
    /// <summary>
    ///     Extends <see cref="IHostBuilder"/> with Limiter configuration methods.
    /// </summary>
    public static class AbpLimiterHostBuilderExtensions
    {
        /// <summary>
        ///     Sets Client Limiter provider  
        /// </summary>
        /// <param name="builder">The host builder to configure.</param>
        /// <returns>The host builder.</returns>
        public static IHostBuilder UseAspNetCoreRateLimitClient(this IHostBuilder builder)
        {
            if (builder == null) throw new ArgumentNullException(nameof(builder));
            builder.ConfigureServices((_, services) =>
            {
                var provider = services.BuildServiceProvider();
                using var scope = provider.CreateScope();
                // get the ClientPolicyStore instance
                var clientPolicyStore = scope.ServiceProvider.GetRequiredService<IClientPolicyStore>();
                //seed Client data from appsettings
                clientPolicyStore.SeedAsync().WaitAndUnwrapException();
            });
            return builder;
        }
    }
}
