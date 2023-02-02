using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Uzum.Domain.Entities;

namespace MyUzum.Infrastructure.EntityTypeConfiguration
{
    public class BoughtProductEntityTypeConfiguration : IEntityTypeConfiguration<BoughtProduct>
    {
        public void Configure(EntityTypeBuilder<BoughtProduct> builder)
        {
            builder.HasKey(x => x.Id);

            builder.HasOne(x => x.ShopProduct)
                .WithMany(x => x.BoughtProducts)
                .HasForeignKey(x => x.ShopProductId);

            builder.HasOne(x => x.Contract)
                .WithMany(x => x.BoughtProducts)
                .HasForeignKey(x => x.ContractId);
        }
    }
}
