using Microsoft.EntityFrameworkCore;
using Migrations.Models;

namespace Migrations.Data.EntityConfiguration
{
    public class ProffesorEntityConfiguration : IEntityTypeConfiguration<Proffesor>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Proffesor> builder)
        {
            builder.ToTable(nameof(Proffesor), Schema.UniversitySchemaName);
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Name).IsRequired();
        }
    }
}
