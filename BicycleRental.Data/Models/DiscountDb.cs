using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using BicycleRental.Domain.Enums;

namespace BicycleRental.WebAPI.Models;

/// <summary>
/// Модель скидок для БД
/// </summary>
[Table("discounts")]
public class DiscountDb
{
    /// <summary>
    /// Первичный ключ
    /// </summary>
    [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int IdDiscount { get; set; }
    
    /// <summary>
    /// Название скидки
    /// </summary>
    [Required]
    [Column("name_dcount")]
    public string Name_discount { get; set; }
    
    /// <summary>
    /// Проценты скидки
    /// </summary>
    [Required]
    [Column("percent")]
    public double Percent { get; set; }
    
    /// <summary>
    /// Активация скидки
    /// </summary>
    public DiscountMode Allowed { get; set; }
}