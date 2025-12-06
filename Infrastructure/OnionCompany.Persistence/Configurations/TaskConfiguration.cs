using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace OnionCompany.Persistence.Configurations
{
    public class TaskConfiguration : BaseConfiguration<OnionCompany.Domain.Entities.Task>
    {
        public override void Configure(EntityTypeBuilder<OnionCompany.Domain.Entities.Task> builder)
        {
            base.Configure(builder);
            builder.Property(x => x.Title).IsRequired().HasMaxLength(200);
            builder.Property(x => x.Description).HasMaxLength(1000);
            builder.Property(x => x.DueDate).IsRequired();
            builder.Property(x => x.IsCompleted).IsRequired();
            
            builder.HasOne(x => x.Project)
                .WithMany(x => x.Tasks)
                .HasForeignKey(x => x.ProjectId);
                
            builder.HasOne(x => x.AssignedToEmployee)
                .WithMany(x => x.Tasks)
                .HasForeignKey(x => x.AssignedToEmployeeId)
                .IsRequired(false);
        }
    }
}



