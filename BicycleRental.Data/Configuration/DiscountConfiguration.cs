using BicycleRental.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BicycleRental.WebAPI.Configuration;

public class DiscountConfiguration : IEntityTypeConfiguration<Discount>
{
    public void Configure(EntityTypeBuilder<Discount> builder)
    {
        builder.ToTable("discounts");

        builder.HasKey(u => u.IdDiscount);

        builder.Property(u => u.Name_discount).IsRequired();
        builder.Property(u => u.Percent).IsRequired();
        builder.Property(u => u.Allowed).IsRequired();
    }
}