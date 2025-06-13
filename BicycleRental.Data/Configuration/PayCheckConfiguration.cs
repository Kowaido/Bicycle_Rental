using BicycleRental.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BicycleRental.WebAPI.Configuration;

public class PayCheckConfiguration : IEntityTypeConfiguration<PayCheck>
{
    public void Configure(EntityTypeBuilder<PayCheck> builder)
    {
        builder.ToTable("pay_chek");

        builder.HasKey(u => u.IdPaycheck);

        builder.HasOne(u => u.Duties).WithMany(r => r.PayCheck).HasForeignKey(dd => dd.IdPaycheck);
    }
}