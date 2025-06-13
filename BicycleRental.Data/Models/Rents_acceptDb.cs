using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BicycleRental.WebAPI.Models;

/// <summary>
/// Модель принятых аренд для БД
/// </summary>
[Table("rents_accepts")]
public class Rents_acceptDb
{
    /// <summary>
    /// Вторичный ключ аренды
    /// </summary>
    [ForeignKey("rent_id")]
    public List<RentDb> Rents { get; set; }
    
    /// <summary>
    /// Первичный ключ
    /// </summary>
    [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int IdRentAccept { get; set; }
    
    /// <summary>
    /// Принятие аренды
    /// </summary>
    [Required, Column("accept")]
    public bool Accepted { get; set; }
}