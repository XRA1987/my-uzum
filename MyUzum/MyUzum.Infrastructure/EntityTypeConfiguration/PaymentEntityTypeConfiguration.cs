using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Uzum.Domain.Entities;

namespace MyUzum.Infrastructure.EntityTypeConfiguration
{
    public class PaymentEntityTypeConfiguration : IEntityTypeConfiguration<Payment>
    {
        public void Configure(EntityTypeBuilder<Payment> builder)
        {
            builder.HasKey(x => x.Id);

            builder.HasOne(x => x.Contract)
                .WithMany(x => x.Payments)
                .HasForeignKey(x => x.ContractId);

            builder.Property(x => x.IsPaid)
                .IsRequired();
        }
    }
}
