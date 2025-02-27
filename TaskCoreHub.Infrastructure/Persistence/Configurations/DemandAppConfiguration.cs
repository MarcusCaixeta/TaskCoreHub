using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TaskCoreHub.Core.Entitites;

namespace TaskCoreHub.Infrastructure.Persistence.Configurations
{
    public class DemandAppConfiguration : IEntityTypeConfiguration<DemandApp>
    {
        public void Configure(EntityTypeBuilder<DemandApp> builder)
        {
            builder.HasKey(propertyNames => propertyNames.Id);
        }
    }
}
