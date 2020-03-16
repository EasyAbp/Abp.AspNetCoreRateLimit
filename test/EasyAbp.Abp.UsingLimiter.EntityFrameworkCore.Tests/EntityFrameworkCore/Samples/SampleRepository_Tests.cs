using EasyAbp.Abp.UsingLimiter.Samples;

namespace EasyAbp.Abp.UsingLimiter.EntityFrameworkCore.Samples
{
    public class SampleRepository_Tests : SampleRepository_Tests<UsingLimiterEntityFrameworkCoreTestModule>
    {
        /* Don't write custom repository tests here, instead write to
         * the base class.
         * One exception can be some specific tests related to EF core.
         */
    }
}
