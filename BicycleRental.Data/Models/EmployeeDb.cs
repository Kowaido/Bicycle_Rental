using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BicycleRental.WebAPI.Models;

/// <summary>
/// Модель работника для БД
/// </summary>
[Table("employees")]
public class EmployeeDb
{
    /// <summary>
    /// Первичный ключ
    /// </summary>
    [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int IdEmployee { get; set; }
    
    /// <summary>
    /// Имя работника
    /// </summary>
    [Required, Column("firstname")]
    public string First_Name { get; set; }
    
    /// <summary>
    /// Фамилия работника
    /// </summary>
    [Required, Column("lastname")]
    public string Last_Name { get; set; }
    
    /// <summary>
    /// Отчество работника(необязательно)
    /// </summary>
    [Required, Column("surname")]
    public string Surname { get; set; }
    
    /// <summary>
    /// Дата рождения работника
    /// </summary>
    [Required, Column("dateofbirth")]
    public DateTime DateOfBirth { get; set; }
    
    /// <summary>
    /// Внешний ключ принятой аренды
    /// </summary>
    [ForeignKey("rentacc_id")]
    public List<Rents_acceptDb> Rents_accept { get; set; }
    
    /// <summary>
    /// Внешний ключ ремонта велосипеда
    /// </summary>
    [ForeignKey("rep_id")]
    public List<RepairDb> Repair_Bike { get; set; }
    
    /// <summary>
    /// Внешний ключ проверки оплаты
    /// </summary>
    [ForeignKey("paych_id")]
    public List<PayCheckDb> PayCheckBike { get; set; }
}