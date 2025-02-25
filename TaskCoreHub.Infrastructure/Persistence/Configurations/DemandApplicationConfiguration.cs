using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TaskCoreHub.Core.Entitites;

namespace TaskCoreHub.Infrastructure.Persistence.Configurations
{
    public class DemandApplicationConfiguration : IEntityTypeConfiguration<DemandApplication>
    {
        public void Configure(EntityTypeBuilder<DemandApplication> builder)
        {
            builder.HasKey(propertyNames => propertyNames.Id);
        }
    }
}
