using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TestArchitecture.DA.Entities;

namespace TestArchitecture.DA.Configurations
{
    public class HomeworkConfiguration : IEntityTypeConfiguration<Homework>
    {
        public void Configure(EntityTypeBuilder<Homework> builder)
        {
            builder.HasKey(x => x.Id);

            builder.Property(x => x.Title).HasMaxLength(500).IsRequired();
            builder.Property(x => x.Description).HasMaxLength(2000);
            builder.Property(x => x.Link).HasMaxLength(1000);

            builder.HasOne(x => x.Lesson)
                .WithOne(x => x.Homework)
                .OnDelete(DeleteBehavior.NoAction)
                .HasPrincipalKey<Homework>(x => x.LessonId)
                .IsRequired();
        }
    }
}