using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BicycleRental.WebAPI.Models;

/// <summary>
/// Модель Велосипедов для БД
/// </summary>
[Table("bikes")]
public class BikeDb
{
    /// <summary>
    /// Первичный ключ
    /// </summary>
    [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int IdBike { get; set; }
    
    /// <summary>
    /// Марка велосипеда
    /// </summary>
    [Required]
    [MaxLength(30)]
    [Column("marka")]
    public string Marka { get; set; }
    
    /// <summary>
    /// Количество велосипедов
    /// </summary>
    [Required]
    [DefaultValue(0)]
    [Column("count")]
    public int Count { get; set; }
    
    /// <summary>
    /// Номер велосипеда
    /// </summary>
    [Required]
    [MaxLength(50)]
    [Column("number")]
    public int Number { get; set; }
}