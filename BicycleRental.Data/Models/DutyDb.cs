using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using BicycleRental.Domain.Enums;

namespace BicycleRental.WebAPI.Models;

/// <summary>
/// Модель задолжностей для БД
/// </summary>
[Table("dutys")]
public class DutyDb
{
    /// <summary>
    /// Дата задолжности
    /// </summary>
    [Required]
    [Column("date_duty")]
    public DateTime DateDuty { get; set; }
    
    /// <summary>
    /// Внешний ключ клиента
    /// </summary>
    [ForeignKey("id_client")]
    public List<ClientDb> Clients { get; set; }
    
    /// <summary>
    /// Сумма задолжности
    /// </summary>
    [Required]
    [Column("sum_duty")]
    public decimal SumDuty { get; set; }
    
    /// <summary>
    /// Статус задолжности
    /// </summary>
    [Required]
    [Column("status")]
    public DutyMode Status { get; set; }
    
    /// <summary>
    /// Первичный ключ
    /// </summary>
    [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int IdDuty { get; set; }
}