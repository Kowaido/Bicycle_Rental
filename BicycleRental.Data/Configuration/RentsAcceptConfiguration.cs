using BicycleRental.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BicycleRental.WebAPI.Configuration;

public class RentsAcceptConfiguration : IEntityTypeConfiguration<Rents_accept>
{
    public void Configure(EntityTypeBuilder<Rents_accept> builder)
    {
        builder.ToTable("rents_accept");

        builder.HasKey(u => u.IdRentAccept);

        builder.HasOne(u => u.Rents).WithMany(r => r.Rents_accept).HasForeignKey(r => r.IdRentAccept);
        builder.Property(u => u.Accepted);
    }
}