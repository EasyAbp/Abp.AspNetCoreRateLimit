using Microsoft.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;

namespace EasyAbp.Abp.UsingLimiter.EntityFrameworkCore
{
    public class UsingLimiterHttpApiHostMigrationsDbContext : AbpDbContext<UsingLimiterHttpApiHostMigrationsDbContext>
    {
        public UsingLimiterHttpApiHostMigrationsDbContext(DbContextOptions<UsingLimiterHttpApiHostMigrationsDbContext> options)
            : base(options)
        {
        
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.ConfigureUsingLimiter();
        }
    }
}
