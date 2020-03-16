using Volo.Abp.Modularity;
using Volo.Abp.Localization;
using EasyAbp.Abp.UsingLimiter.Localization;
using Volo.Abp.Localization.ExceptionHandling;
using Volo.Abp.Validation;
using Volo.Abp.Validation.Localization;
using Volo.Abp.VirtualFileSystem;

namespace EasyAbp.Abp.UsingLimiter
{
    [DependsOn(
        typeof(AbpValidationModule)
    )]
    public class UsingLimiterDomainSharedModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            Configure<AbpVirtualFileSystemOptions>(options =>
            {
                options.FileSets.AddEmbedded<UsingLimiterDomainSharedModule>("EasyAbp.Abp.UsingLimiter");
            });

            Configure<AbpLocalizationOptions>(options =>
            {
                options.Resources
                    .Add<UsingLimiterResource>("en")
                    .AddBaseTypes(typeof(AbpValidationResource))
                    .AddVirtualJson("/Localization/UsingLimiter");
            });

            Configure<AbpExceptionLocalizationOptions>(options =>
            {
                options.MapCodeNamespace("UsingLimiter", typeof(UsingLimiterResource));
            });
        }
    }
}
