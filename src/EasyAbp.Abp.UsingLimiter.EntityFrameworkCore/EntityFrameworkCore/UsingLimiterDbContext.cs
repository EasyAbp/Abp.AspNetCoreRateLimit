using Microsoft.EntityFrameworkCore;
using Volo.Abp.Data;
using Volo.Abp.EntityFrameworkCore;

namespace EasyAbp.Abp.UsingLimiter.EntityFrameworkCore
{
    [ConnectionStringName(UsingLimiterDbProperties.ConnectionStringName)]
    public class UsingLimiterDbContext : AbpDbContext<UsingLimiterDbContext>, IUsingLimiterDbContext
    {
        /* Add DbSet for each Aggregate Root here. Example:
         * public DbSet<Question> Questions { get; set; }
         */

        public UsingLimiterDbContext(DbContextOptions<UsingLimiterDbContext> options) 
            : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.ConfigureUsingLimiter();
        }
    }
}