using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Uzum.Domain.Entities;

namespace MyUzum.Infrastructure.EntityTypeConfiguration
{
    public class CardEntityTypeConfiguration : IEntityTypeConfiguration<Card>
    {
        public void Configure(EntityTypeBuilder<Card> builder)
        {
            builder.HasKey(x => x.Id);

            builder.Property(x => x.CardNumber)
                .IsRequired();
        }
    }
}
