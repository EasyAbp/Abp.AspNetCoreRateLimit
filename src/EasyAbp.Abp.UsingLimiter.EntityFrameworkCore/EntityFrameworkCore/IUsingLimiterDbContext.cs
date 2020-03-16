using Volo.Abp.Data;
using Volo.Abp.EntityFrameworkCore;

namespace EasyAbp.Abp.UsingLimiter.EntityFrameworkCore
{
    [ConnectionStringName(UsingLimiterDbProperties.ConnectionStringName)]
    public interface IUsingLimiterDbContext : IEfCoreDbContext
    {
        /* Add DbSet for each Aggregate Root here. Example:
         * DbSet<Question> Questions { get; }
         */
    }
}