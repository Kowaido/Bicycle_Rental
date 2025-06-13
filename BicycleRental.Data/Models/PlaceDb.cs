using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BicycleRental.WebAPI.Models;

/// <summary>
/// Модель мест для БД
/// </summary>
[Table("places")]
public class PlaceDb
{
    /// <summary>
    /// Первичный ключ
    /// </summary>
    [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int IdPlace { get; set; }
    
    /// <summary>
    /// Название местности
    /// </summary>
    [Required]
    [Column("name_place")]
    public string NamePlace { get; set; }
    
    /// <summary>
    /// Расстояние проеханое от начала пути
    /// </summary>
    [Required, Column("distance")]
    public double Distance { get; set; }
    
    /// <summary>
    /// Вторичный ключ аренды
    /// </summary>
    [ForeignKey("rent_id")]
    public List<RentDb> Rents { get; set; }
    
    /// <summary>
    /// Выбираемая местности
    /// </summary>
    [Required, Column("choose_place")]
    public bool ChoosePlace { get; set; }
}