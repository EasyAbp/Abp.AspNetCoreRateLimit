using System;
using Volo.Abp;
using Volo.Abp.MongoDB;

namespace EasyAbp.Abp.UsingLimiter.MongoDB
{
    public static class UsingLimiterMongoDbContextExtensions
    {
        public static void ConfigureUsingLimiter(
            this IMongoModelBuilder builder,
            Action<AbpMongoModelBuilderConfigurationOptions> optionsAction = null)
        {
            Check.NotNull(builder, nameof(builder));

            var options = new UsingLimiterMongoModelBuilderConfigurationOptions(
                UsingLimiterDbProperties.DbTablePrefix
            );

            optionsAction?.Invoke(options);
        }
    }
}