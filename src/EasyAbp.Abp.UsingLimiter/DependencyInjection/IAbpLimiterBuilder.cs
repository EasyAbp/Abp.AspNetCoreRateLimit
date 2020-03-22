using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace EasyAbp.Abp.UsingLimiter.DependencyInjection
{
    public interface IAbpLimiterBuilder
    {
        IServiceCollection Services { get; }

        IConfiguration Configuration { get; }
    }
}
