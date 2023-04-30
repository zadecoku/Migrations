using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Migrations.Models;

namespace Migrations.Data.EntityConfiguration
{
    public class EmployeeEntityConfiguration : IEntityTypeConfiguration<Employee>
    {
        public void Configure(EntityTypeBuilder<Employee> builder)
        {
            builder.ToTable(nameof(Employee), Schema.UniversitySchemaName);
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Name).IsRequired();
        }

    }
}
