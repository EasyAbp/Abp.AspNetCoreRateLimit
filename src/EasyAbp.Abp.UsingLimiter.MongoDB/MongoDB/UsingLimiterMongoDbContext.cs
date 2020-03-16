using Volo.Abp.Data;
using Volo.Abp.MongoDB;

namespace EasyAbp.Abp.UsingLimiter.MongoDB
{
    [ConnectionStringName(UsingLimiterDbProperties.ConnectionStringName)]
    public class UsingLimiterMongoDbContext : AbpMongoDbContext, IUsingLimiterMongoDbContext
    {
        /* Add mongo collections here. Example:
         * public IMongoCollection<Question> Questions => Collection<Question>();
         */

        protected override void CreateModel(IMongoModelBuilder modelBuilder)
        {
            base.CreateModel(modelBuilder);

            modelBuilder.ConfigureUsingLimiter();
        }
    }
}