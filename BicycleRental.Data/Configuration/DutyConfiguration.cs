using BicycleRental.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BicycleRental.WebAPI.Configuration;

public class DutyConfiguration : IEntityTypeConfiguration<Duty>
{
    public void Configure(EntityTypeBuilder<Duty> builder)
    {
        builder.ToTable("dutys");

        builder.HasKey(u => u.IdDuty);

        builder.HasOne(u => u.Clients).WithMany(r => r.Duty).HasForeignKey(c => c.IdDuty);
        builder.Property(u => u.SumDuty).IsRequired();
        builder.Property(u => u.Status).IsRequired();
        builder.Property(u => u.DateDuty).IsRequired();
    }
}