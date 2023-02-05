using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Uzum.Domain.Entities;
using Uzum.Domain.Enums;

namespace MyUzum.Infrastructure.EntityTypeConfiguration
{
    public class UserEntityTypeConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.HasKey(x => x.Id);

            builder.Property(p => p.UserName)
                .HasMaxLength(30)
                .IsRequired();

            builder.HasIndex(p => p.UserName)
                .IsUnique();

            builder.HasData(new User()
            {
                Id = 1,
                UserName = "Xolmatov",
                PasswordHash = "9BD03CFAE8781CB5C1A8BD30600EA03274C5DF36FE5A04F490DE133AEED7503E0FEECDAF0A42A26E1A82DB8CC4C2AF4664F9841604D82DD636B4166CDBA962AE",
                FullName = "Xolmatov Abdurahim",
                PhoneNumber = "994779050",
                Role = UserRole.Admin                                
            });
        }
    }
}
