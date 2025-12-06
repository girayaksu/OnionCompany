using Microsoft.EntityFrameworkCore.Metadata.Builders;
using OnionCompany.Domain.Entities;

namespace OnionCompany.Persistence.Configurations
{
    public class DepartmentConfiguration : BaseConfiguration<Department>
    {
        public override void Configure(EntityTypeBuilder<Department> builder)
        {
            base.Configure(builder);
            builder.Property(x => x.Name).IsRequired().HasMaxLength(100);
            builder.Property(x => x.Location).HasMaxLength(200);
        }
    }
}


