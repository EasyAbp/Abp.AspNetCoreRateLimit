using System;
using Microsoft.EntityFrameworkCore;
using Volo.Abp;

namespace EasyAbp.Abp.UsingLimiter.EntityFrameworkCore
{
    public static class UsingLimiterDbContextModelCreatingExtensions
    {
        public static void ConfigureUsingLimiter(
            this ModelBuilder builder,
            Action<UsingLimiterModelBuilderConfigurationOptions> optionsAction = null)
        {
            Check.NotNull(builder, nameof(builder));

            var options = new UsingLimiterModelBuilderConfigurationOptions(
                UsingLimiterDbProperties.DbTablePrefix,
                UsingLimiterDbProperties.DbSchema
            );

            optionsAction?.Invoke(options);

            /* Configure all entities here. Example:

            builder.Entity<Question>(b =>
            {
                //Configure table & schema name
                b.ToTable(options.TablePrefix + "Questions", options.Schema);
            
                b.ConfigureFullAuditedAggregateRoot();
            
                //Properties
                b.Property(q => q.Title).IsRequired().HasMaxLength(QuestionConsts.MaxTitleLength);
                
                //Relations
                b.HasMany(question => question.Tags).WithOne().HasForeignKey(qt => qt.QuestionId);

                //Indexes
                b.HasIndex(q => q.CreationTime);
            });
            */
        }
    }
}