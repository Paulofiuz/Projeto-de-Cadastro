using Cadastro.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Cadastro.Data.Configurations
{
    public class AddressMap : IEntityTypeConfiguration<Address>
    {
        public void Configure(EntityTypeBuilder<Address> builder)
        {
            builder.ToTable("Address");

            builder.HasKey(a => a.AddressId);
            builder.Property(a => a.AddressId).ValueGeneratedOnAdd();

            builder.Property(a => a.Street).IsRequired().HasMaxLength(200);
            builder.Property(a => a.City).IsRequired().HasMaxLength(100);
            builder.Property(a => a.State).IsRequired().HasMaxLength(100);
            builder.Property(a => a.PostalCode).IsRequired().HasMaxLength(20);
            builder.Property(a => a.Country).IsRequired().HasMaxLength(100);

            // Configuração do relacionamento um-para-um com User
            builder.HasOne(a => a.User)
                   .WithOne(u => u.Address)
                   .HasForeignKey<User>(u => u.AddressId);
        }
    }
}
