using BicycleRental.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BicycleRental.WebAPI.Configuration;

public class RentConfiguration : IEntityTypeConfiguration<Rent>
{
    public void Configure(EntityTypeBuilder<Rent> builder)
    {
        builder.ToTable("rents");

        builder.HasKey(u => u.IdRent);

        builder.HasOne(u => u.Bikes).WithMany(r => r.Rent).HasForeignKey(dd => dd.IdRent);
        builder.HasOne(u => u.Discounts).WithOne(r => r.Rents).HasForeignKey<Discount>(dd => dd.IdRent);
        builder.Property(u => u.DataRent).IsRequired();
        builder.Property(u => u.RentTime).IsRequired();
    }
}