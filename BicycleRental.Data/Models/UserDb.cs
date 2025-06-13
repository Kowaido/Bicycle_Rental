using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BicycleRental.WebAPI.Models;

/// <summary>
/// Модель пользователей для БД
/// </summary>
[Table("users")]
public class UserDb
{
    /// <summary>
    /// Первичный ключ
    /// </summary>
    [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int IdUser { get; set; }
    
    /// <summary>
    /// Внешний ключ клиентов
    /// </summary>
    [ForeignKey("id_client")]
    public List<ClientDb> Clients { get; set; }
    
    /// <summary>
    /// Внешний ключ работников
    /// </summary>
    [ForeignKey("id_employee")]
    public List<EmployeeDb> Employees { get; set; }
    
    /// <summary>
    /// Имя пользователя
    /// </summary>
    [Required(ErrorMessage = "Имя пользователя не корректное"), Column("username")]
    public string Username { get; set; }
    
    /// <summary>
    /// Пароль пользователя
    /// </summary>
    [Required(ErrorMessage = "Некорректный пароль"), Column("hass_pass")]
    public string HashedPassword { get; set; }
    
    /// <summary>
    /// Email-почта пользователя
    /// </summary>
    [Required(ErrorMessage = "Некорректная почта"), Column("email")]
    public string Email { get; set; }
}