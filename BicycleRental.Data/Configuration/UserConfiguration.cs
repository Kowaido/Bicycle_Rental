using BicycleRental.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BicycleRental.WebAPI.Configuration;

public class UserConfiguration : IEntityTypeConfiguration<User>
{
    public void Configure(EntityTypeBuilder<User> builder)
    {
        builder.ToTable("users");

        builder.HasKey(u => u.IdUser);
        builder.HasOne(u => u.Clients).WithMany(r => r.Users).HasForeignKey(d => d.IdUser);
        builder.HasOne(u => u.Employees).WithMany(r => r.Users).HasForeignKey(d => d.IdUser);
        builder.HasOne(u => u.Rents).WithMany(r => r.Users).HasForeignKey(d => d.IdUser);
        builder.Property(u => u.Username).HasMaxLength(15).IsRequired();
        builder.Property(u => u.HashedPassword).HasMaxLength(20).IsRequired();
        builder.Property(u => u.Email).HasMaxLength(30).IsRequired();
    }
}