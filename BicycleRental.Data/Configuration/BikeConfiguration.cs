using BicycleRental.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BicycleRental.WebAPI.Configuration;

public class BikeConfiguration : IEntityTypeConfiguration<Bike>
{
    public void Configure(EntityTypeBuilder<Bike> builder)
    {
        builder.ToTable("bikes");

        builder.HasKey(u => u.IdBike);
        
        builder.Property(u => u.Number).IsRequired().HasMaxLength(30);

        builder.Property(u => u.Count).IsRequired().HasDefaultValue(0);
        
        builder.Property(u => u.Marka).IsRequired().HasMaxLength(50);
    }
}