using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TaskCoreHub.Core.Entitites;

namespace TaskCoreHub.Infrastructure.Persistence.Configurations
{
    public class ReasonConfiguration : IEntityTypeConfiguration<Reason>
    {
        public void Configure(EntityTypeBuilder<Reason> builder)
        {
            builder.HasKey(propertyNames => propertyNames.Id);
        }
    }
}
