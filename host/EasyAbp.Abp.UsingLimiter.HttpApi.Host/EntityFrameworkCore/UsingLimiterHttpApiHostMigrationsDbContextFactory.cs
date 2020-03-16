using System.IO;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace EasyAbp.Abp.UsingLimiter.EntityFrameworkCore
{
    public class UsingLimiterHttpApiHostMigrationsDbContextFactory : IDesignTimeDbContextFactory<UsingLimiterHttpApiHostMigrationsDbContext>
    {
        public UsingLimiterHttpApiHostMigrationsDbContext CreateDbContext(string[] args)
        {
            var configuration = BuildConfiguration();

            var builder = new DbContextOptionsBuilder<UsingLimiterHttpApiHostMigrationsDbContext>()
                .UseSqlServer(configuration.GetConnectionString("UsingLimiter"));

            return new UsingLimiterHttpApiHostMigrationsDbContext(builder.Options);
        }

        private static IConfigurationRoot BuildConfiguration()
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", optional: false);

            return builder.Build();
        }
    }
}
