using Cadastro.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Cadastro.Data.Configurations;

public class UserMap : IEntityTypeConfiguration<User>
{
    public void Configure(EntityTypeBuilder<User> builder)
    {
       builder.ToTable("User");
       builder.HasKey(u => u.UserId);
       builder.Property(u => u.UserId) .ValueGeneratedOnAdd();
       builder.Property(u => u.Name) .IsRequired().HasMaxLength(100);
       builder.Property(u => u.DateTime).IsRequired(false);
    }
}
