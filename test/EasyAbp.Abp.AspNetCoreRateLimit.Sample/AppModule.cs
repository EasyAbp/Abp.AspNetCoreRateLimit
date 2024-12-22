using AspNetCoreRateLimit;
using EasyAbp.Abp.AspNetCoreRateLimit.Client;
using EasyAbp.Abp.AspNetCoreRateLimit.Client.DependencyInjection;
using EasyAbp.Abp.AspNetCoreRateLimit.DependencyInjection;
using EasyAbp.Abp.AspNetCoreRateLimit.Ip;
using EasyAbp.Abp.AspNetCoreRateLimit.Ip.DependencyInjection;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.Hosting;
using Volo.Abp;
using Volo.Abp.AspNetCore.Mvc;
using Volo.Abp.Autofac;
using Volo.Abp.Modularity;

namespace EasyAbp.Abp.AspNetCoreRateLimit.Sample
{
    [DependsOn(
        typeof(AbpClientLimiterModule),  
        typeof(AbpIpLimiterModule),
        typeof(AbpAutofacModule),
         typeof(AbpAspNetCoreMvcModule)
       )]
    public class AppModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
               context.Services.AddLimiterService<MemoryCacheRateLimitCounterStore>(service =>
                {
                    service.AddLimiterIpService<MemoryCacheIpPolicyStore>();
                    service.AddLimiterClientService<MemoryCacheClientPolicyStore>();
                });
        }

        public override void OnApplicationInitialization(ApplicationInitializationContext context)
        {
            var app = context.GetApplicationBuilder();
            var env = context.GetEnvironment();
            app.UseIpRateLimiting();
            app.UseClientRateLimiting();
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Error");
            }

            app.MapAbpStaticAssets();
            app.UseRouting();
            app.UseConfiguredEndpoints();
        }
    }
}
