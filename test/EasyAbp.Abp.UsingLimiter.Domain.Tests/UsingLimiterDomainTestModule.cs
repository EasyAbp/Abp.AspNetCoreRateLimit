using EasyAbp.Abp.UsingLimiter.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace EasyAbp.Abp.UsingLimiter
{
    /* Domain tests are configured to use the EF Core provider.
     * You can switch to MongoDB, however your domain tests should be
     * database independent anyway.
     */
    [DependsOn(
        typeof(UsingLimiterEntityFrameworkCoreTestModule)
        )]
    public class UsingLimiterDomainTestModule : AbpModule
    {
        
    }
}
