using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Uzum.Domain.Entities;

namespace MyUzum.Infrastructure.EntityTypeConfiguration
{
    public class UserEntityTypeConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.HasKey(x=>x.Id);

            builder.Property(p=>p.UserName)
                .HasMaxLength(30)
                .IsRequired();

            builder.HasIndex(p=>p.UserName)
                .IsUnique();
        }
    }
}
