using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TaskCoreHub.Core.Entitites;

namespace TaskCoreHub.Infrastructure.Persistence.Configurations
{
    public class StatusDemandConfiguration : IEntityTypeConfiguration<StatusDemand>
    {
        public void Configure(EntityTypeBuilder<StatusDemand> builder)
        {
            builder.HasKey(propertyNames => propertyNames.Id);
        }
    }
}
