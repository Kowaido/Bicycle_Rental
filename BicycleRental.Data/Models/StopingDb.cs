using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BicycleRental.WebAPI.Models;


/// <summary>
/// Модель остановок для БД
/// </summary>
[Table("stopings")]
public class StopingDb
{
    /// <summary>
    /// Первичный ключ
    /// </summary>
    [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int IdStop { get; set; }
    
    /// <summary>
    /// Внешний ключ местностей
    /// </summary>
    [ForeignKey("place_id")]
    public List<PlaceDb> Places { get; set; }
    
    /// <summary>
    /// Дата отбытия
    /// </summary>
    [Required, Column("arriv_date")]
    public DateTime ArrivalDate { get; set; }
    
    /// <summary>
    /// Дата прибытия
    /// </summary>
    [Required, Column("depar_date")]
    public DateTime DepartureDate { get; set; }
    
    /// <summary>
    /// Количество остановок
    /// </summary>
    [Required, Column("count")]
    public int Count { get; set; }
}