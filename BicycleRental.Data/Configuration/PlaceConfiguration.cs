using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using BicycleRental.Domain.Entities;

namespace BicycleRental.WebAPI.Configuration;

/// <summary>
/// Конфигурация сущности Place для EFC.
/// Определяет правила для отображения Place в бд.
/// включая ключи, связи и ограничения.
/// </summary>
public class PlaceConfiguration : IEntityTypeConfiguration<Place>
{
    /// <summary>
    /// Метод для конфигурации сущностей
    /// </summary>
    /// <param name="builder">объект типа</param>
    public void Configure(EntityTypeBuilder<Place> builder)
    {
        builder.ToTable("places");

        builder.HasKey(u => u.IdPlace);
        
        builder.HasOne(u => u.Rents).WithOne(r => r.Places).HasForeignKey<Rent>(d => d.IdPlace);
        builder.Property(u => u.Distance).IsRequired();
        builder.Property(u => u.NamePlace).IsRequired();
        builder.Property(u => u.ChoosePlace).IsRequired();
    }
}