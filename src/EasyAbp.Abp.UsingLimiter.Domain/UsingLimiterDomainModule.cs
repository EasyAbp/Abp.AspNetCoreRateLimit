using Volo.Abp.Modularity;

namespace EasyAbp.Abp.UsingLimiter
{
    [DependsOn(
        typeof(UsingLimiterDomainSharedModule)
        )]
    public class UsingLimiterDomainModule : AbpModule
    {

    }
}
