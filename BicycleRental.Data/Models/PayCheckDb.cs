using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BicycleRental.WebAPI.Models;

/// <summary>
/// Модель проверки оплаты для БД
/// </summary>
[Table("pay_chek")]
public class PayCheckDb
{
    /// <summary>
    /// Первичный ключ
    /// </summary>
    [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int IdPaycheck { get; set; }
    
    /// <summary>
    /// Вторичный ключ задолжности
    /// </summary>
    [ForeignKey("duty_id")]
    public List<DutyDb> Duties { get; set; }
}