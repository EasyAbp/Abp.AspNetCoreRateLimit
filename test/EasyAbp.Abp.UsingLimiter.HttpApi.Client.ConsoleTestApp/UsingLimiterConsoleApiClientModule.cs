using Volo.Abp.Http.Client.IdentityModel;
using Volo.Abp.Modularity;

namespace EasyAbp.Abp.UsingLimiter
{
    [DependsOn(
        typeof(UsingLimiterHttpApiClientModule),
        typeof(AbpHttpClientIdentityModelModule)
        )]
    public class UsingLimiterConsoleApiClientModule : AbpModule
    {
        
    }
}
