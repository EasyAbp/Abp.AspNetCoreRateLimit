using Volo.Abp.Modularity;

namespace EasyAbp.Abp.UsingLimiter
{
    [DependsOn(
        typeof(UsingLimiterApplicationModule),
        typeof(UsingLimiterDomainTestModule)
        )]
    public class UsingLimiterApplicationTestModule : AbpModule
    {

    }
}
