using JetBrains.Annotations;
using Volo.Abp.MongoDB;

namespace EasyAbp.Abp.UsingLimiter.MongoDB
{
    public class UsingLimiterMongoModelBuilderConfigurationOptions : AbpMongoModelBuilderConfigurationOptions
    {
        public UsingLimiterMongoModelBuilderConfigurationOptions(
            [NotNull] string collectionPrefix = "")
            : base(collectionPrefix)
        {
        }
    }
}