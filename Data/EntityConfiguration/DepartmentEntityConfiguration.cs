using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Migrations.Models;

namespace Migrations.Data.EntityConfiguration
{
    public class DepartmentEntityConfiguration : IEntityTypeConfiguration<Department>
    {
        public void Configure(EntityTypeBuilder<Department> builder)
        {
            builder.ToTable(nameof(Department), Schema.UniversitySchemaName);
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Name)
                   .IsRequired();
            builder.HasMany(x => x.Proffesor)
                   .WithOne(x=>x.Department)
                   .HasForeignKey(x=>x.DepartmentId);

        }


    }
}
