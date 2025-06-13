using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using BicycleRental.Domain.Enums;

namespace BicycleRental.WebAPI.Models;


/// <summary>
/// Модель ремонта велосипедов для БД
/// </summary>
[Table("repair_bikes")]
public class RepairDb
{
    /// <summary>
    /// Первичный ключ
    /// </summary>
    [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int IdRepairBike { get; set; }
    
    /// <summary>
    /// Внешний ключ велосипедов
    /// </summary>
    [ForeignKey("bike_id")]
    public List<BikeDb> Bikes { get; set; }
    
    /// <summary>
    /// Статус велосипеда(на ремонте|после ремонта|перед ремонтом)
    /// </summary>
    [Required, Column("status_bike")]
    public bool StatusBike { get; set; }
    
    /// <summary>
    /// Тип ремонта велосипеда
    /// </summary>
    [Required, Column("type_repair")]
    public TypeRepairMode TypeRepair { get; set; }
    
    /// <summary>
    /// Коментарий, оставленный во время ремонта
    /// </summary>
    [Required, Column("comment_repair")]
    public string CommentRepair { get; set; }
}