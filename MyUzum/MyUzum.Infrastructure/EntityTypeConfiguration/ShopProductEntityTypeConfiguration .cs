using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Uzum.Domain.Entities;

namespace MyUzum.Infrastructure.EntityTypeConfiguration
{
    public class ShopProductEntityTypeConfiguration : IEntityTypeConfiguration<ShopProduct>
    {
        public void Configure(EntityTypeBuilder<ShopProduct> builder)
        {
            builder.HasKey(s=>s.Id);

            builder.HasOne(s => s.Product)
                .WithMany(s=>s.ShopProducts)
                .HasForeignKey(s => s.ProductId);

            builder.HasOne(s => s.Shop)
                .WithMany(s => s.ShopProducts)
                .HasForeignKey(s => s.ShopId);
        }
    }
}
