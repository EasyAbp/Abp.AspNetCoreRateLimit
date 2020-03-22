using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace EasyAbp.Abp.UsingLimiter.DependencyInjection
{
    public class AbpLimiterBuilder : IAbpLimiterBuilder
    {
        public IServiceCollection Services { get; private set; }
        public IConfiguration Configuration { get; private set; }

        public AbpLimiterBuilder(IServiceCollection services,IConfiguration configurationRoot)
        {
            Configuration = configurationRoot;
            Services = services;
        }
    }
}
