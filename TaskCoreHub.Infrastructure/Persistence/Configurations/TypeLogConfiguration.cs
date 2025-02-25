using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TaskCoreHub.Core.Entitites;

namespace TaskCoreHub.Infrastructure.Persistence.Configurations
{
    public class TypeLogConfiguration : IEntityTypeConfiguration<TypeLog>
    {
        public void Configure(EntityTypeBuilder<TypeLog> builder)
        {
            builder.HasKey(propertyNames => propertyNames.Id);
        }
    }
}
