using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Uzum.Domain.Entities;

namespace MyUzum.Infrastructure.EntityTypeConfiguration
{
    public class BrandEntityTypeConfiguration : IEntityTypeConfiguration<Brand>
    {
        public void Configure(EntityTypeBuilder<Brand> builder)
        {
            builder.HasKey(x => x.Id);

            builder.Property(x => x.Name)
                .IsRequired();
        }
    }
}
