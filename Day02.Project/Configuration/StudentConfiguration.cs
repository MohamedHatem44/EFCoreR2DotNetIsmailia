using Day02.Project.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Day02.Project.Configuration
{
    public class StudentConfiguration : IEntityTypeConfiguration<Student>
    {
        // Fluent API
        public void Configure(EntityTypeBuilder<Student> builder)
        {
            builder.HasKey(s => s.StdId);
            builder.Property(s => s.StdName)
                .HasMaxLength(100)
                .IsRequired();
            builder.Property(s => s.Email)
                .HasMaxLength(100)
                .IsRequired(false);

            builder.HasOne(s => s.Department)
                .WithMany(d => d.Students)
                .HasForeignKey(s => s.DeptId);
        }
    }
}
