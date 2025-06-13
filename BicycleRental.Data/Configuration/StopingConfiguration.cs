using BicycleRental.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BicycleRental.WebAPI.Configuration;

public class StopingConfiguration : IEntityTypeConfiguration<Stoping>
{
    public void Configure(EntityTypeBuilder<Stoping> builder)
    {
        builder.ToTable("stopings");

        builder.HasKey(u => u.IdStop);

        builder.HasOne(u => u.Places).WithMany(r => r.Stoping).HasForeignKey(d => d.IdStop);
        builder.Property(u => u.Count).HasDefaultValue(0).IsRequired();
        builder.Property(u => u.ArrivalDate).IsRequired();
        builder.Property(u => u.DepartureDate).IsRequired();
    }
}