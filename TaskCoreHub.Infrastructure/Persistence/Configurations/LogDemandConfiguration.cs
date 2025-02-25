using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TaskCoreHub.Core.Entitites;

namespace TaskCoreHub.Infrastructure.Persistence.Configurations
{
    public class LogDemandConfiguration : IEntityTypeConfiguration<LogDemand>
    {
        public void Configure(EntityTypeBuilder<LogDemand> builder)
        {
            builder.HasKey(propertyNames => propertyNames.Id);
        }
    }
}
