using Microsoft.EntityFrameworkCore.Metadata.Builders;
using OnionCompany.Domain.Entities;

namespace OnionCompany.Persistence.Configurations
{
    public class ProjectConfiguration : BaseConfiguration<Project>
    {
        public override void Configure(EntityTypeBuilder<Project> builder)
        {
            base.Configure(builder);
            builder.Property(x => x.Name).IsRequired().HasMaxLength(150);
            builder.Property(x => x.Description).HasMaxLength(500);
            builder.Property(x => x.StartDate).IsRequired();
        }
    }
}


