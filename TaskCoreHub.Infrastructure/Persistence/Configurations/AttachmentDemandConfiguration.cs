using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TaskCoreHub.Core.Entitites;

namespace TaskCoreHub.Infrastructure.Persistence.Configurations
{
    public class AttachmentDemandConfiguration : IEntityTypeConfiguration<AttachmentDemand>
    {
        public void Configure(EntityTypeBuilder<AttachmentDemand> builder)
        {
            builder.HasKey(propertyNames => propertyNames.Id);
        }
    }
}
