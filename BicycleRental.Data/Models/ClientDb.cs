using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BicycleRental.WebAPI.Models;

/// <summary>
/// Модель клиентов для БД
/// </summary>
[Table("clients")]
public class ClientDb
{
    /// <summary>
    /// Первичный ключ
    /// </summary>
    [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int IdClient { get; set; }
    
    /// <summary>
    /// Имя клиента
    /// </summary>
    [Required]
    [Column("firstname")]
    public string FirstName { get; set; }
    
    /// <summary>
    /// Фамилия клиента
    /// </summary>
    [Required]
    [Column("lastname")]
    public string LastName { get; set; }
    
    /// <summary>
    /// Отчество клиента(необязательно)
    /// </summary>
    [Required]
    [Column("surname")]
    public string Surname { get; set; }
    
    /// <summary>
    /// Общее количество аренд
    /// </summary>
    [Required]
    [DefaultValue(0)]
    [Column("rent_count")]
    public int RentCount { get; set; }
    
    /// <summary>
    /// Дата рождения
    /// </summary>
    [Required]
    [Column("dob")]
    public DateTime DateOfBirth { get; set; }
}