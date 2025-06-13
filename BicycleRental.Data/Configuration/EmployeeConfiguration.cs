using BicycleRental.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BicycleRental.WebAPI.Configuration
{
    public class EmployeeConfiguration : IEntityTypeConfiguration<Employee>
    {
        public void Configure(EntityTypeBuilder<Employee> builder)
        {
            builder.ToTable("employees");

            builder.HasKey(u => u.IdEmployee);

            builder.HasOne(u => u.Rents_accept).WithMany(r => r.Employee).HasForeignKey(dd => dd.IdEmployee);
            builder.HasOne(u => u.Repair_Bike).WithMany(r => r.Employee).HasForeignKey(dd => dd.IdEmployee);
            builder.HasOne(u => u.PayCheckBike).WithMany(r => r.Employee).HasForeignKey(dd => dd.IdEmployee);
            builder.Property(u => u.First_Name).IsRequired();
            builder.Property(u => u.Last_Name).IsRequired();
            builder.Property(u => u.Surname).IsRequired();
            builder.Property(u => u.DateOfBirth).IsRequired();
        }
    }
}
