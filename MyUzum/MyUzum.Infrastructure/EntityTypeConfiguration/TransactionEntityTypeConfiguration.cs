using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Uzum.Domain.Entities;

namespace MyUzum.Infrastructure.EntityTypeConfiguration
{
    public class TransactionEntityTypeConfiguration : IEntityTypeConfiguration<Transaction>
    {
        public void Configure(EntityTypeBuilder<Transaction> builder)
        {
            builder.HasKey(i => i.Id);

            builder.HasOne(x=>x.ShopProduct)
                .WithMany(w=>w.Transactions)
                .HasForeignKey(f=>f.ShopProductId);
        }
    }
}
