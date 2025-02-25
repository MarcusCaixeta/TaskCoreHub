using Microsoft.EntityFrameworkCore;
using TaskCoreHub.Core.Entitites;

namespace TaskCoreHub.Infrastructure.Persistence.Configurations
{
    public class UserConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<User> builder)
        {
            builder.HasKey(propertyNames => propertyNames.Id);
        }
    }
}
