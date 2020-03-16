using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.Http.Client;
using Volo.Abp.Modularity;

namespace EasyAbp.Abp.UsingLimiter
{
    [DependsOn(
        typeof(UsingLimiterApplicationContractsModule),
        typeof(AbpHttpClientModule))]
    public class UsingLimiterHttpApiClientModule : AbpModule
    {
        public const string RemoteServiceName = "UsingLimiter";

        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            context.Services.AddHttpClientProxies(
                typeof(UsingLimiterApplicationContractsModule).Assembly,
                RemoteServiceName
            );
        }
    }
}
