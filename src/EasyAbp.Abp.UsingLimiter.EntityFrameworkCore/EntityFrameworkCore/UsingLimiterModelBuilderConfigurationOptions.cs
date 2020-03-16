using JetBrains.Annotations;
using Volo.Abp.EntityFrameworkCore.Modeling;

namespace EasyAbp.Abp.UsingLimiter.EntityFrameworkCore
{
    public class UsingLimiterModelBuilderConfigurationOptions : AbpModelBuilderConfigurationOptions
    {
        public UsingLimiterModelBuilderConfigurationOptions(
            [NotNull] string tablePrefix = "",
            [CanBeNull] string schema = null)
            : base(
                tablePrefix,
                schema)
        {

        }
    }
}