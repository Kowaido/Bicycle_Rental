using BicycleRental.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BicycleRental.WebAPI.Configuration;

public class RepairConfiguration : IEntityTypeConfiguration<Repair>
{
    public void Configure(EntityTypeBuilder<Repair> builder)
    {
        builder.ToTable("repairs");

        builder.HasKey(u => u.IdRepairBike);
        builder.HasOne(u => u.Bikes).WithMany(r => r.Repair).HasForeignKey(dd => dd.IdRepairBike);
        builder.Property(u => u.CommentRepair).IsRequired();
        builder.Property(u => u.TypeRepair).IsRequired().HasMaxLength(25);
        builder.Property(u => u.StatusBike).IsRequired();
    }
}