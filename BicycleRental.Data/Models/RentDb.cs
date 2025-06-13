using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BicycleRental.WebAPI.Models;

/// <summary>
/// Модель аренд для БД
/// </summary>
[Table("rents")]
public class RentDb
{
    /// <summary>
    /// Первичный ключ
    /// </summary>
    [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int IdRent { get; set; }
    
    /// <summary>
    /// Вторичный ключ пользователя
    /// </summary>
    [ForeignKey("id_user")]
    public List<UserDb> Users { get; set; }
    
    /// <summary>
    /// Вторичный ключ скидок
    /// </summary>
    [ForeignKey("discount_id")]
    public List<DiscountDb> Discounts { get; set; }
    
    /// <summary>
    /// Вторичный ключ велосипедов
    /// </summary>
    [ForeignKey("id_bike")]
    public List<BikeDb> Bikes { get; set; }
    
    /// <summary>
    /// Время аренды
    /// </summary>
    [Required, Column("rental_time")]
    public TimeSpan RentTime { get; set; }
    
    /// <summary>
    /// Дата аренды
    /// </summary>
    [Required, Column("data_rent")]
    public DateTime DataRent { get; set; }
    
    /// <summary>
    /// Вторичный ключ местности
    /// </summary>
    [ForeignKey("id_place")]
    public List<PlaceDb> Places { get; set; }
}