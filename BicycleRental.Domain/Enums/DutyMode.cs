using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace BicycleRental.Domain.Enums;

/// <summary>
/// TODO: Перечисление режима задолжности
/// </summary>
public enum DutyMode
{
    /// <summary>
    /// Оплачено
    /// </summary>
    [Description("Оплачено")]
    payed = 0,
    
    /// <summary>
    /// Не оплачено
    /// </summary>
    [Description("Не оплачено")]
    not_payed = 1,
    
    /// <summary>
    /// Ожидание оплаты
    /// </summary>
    [Description("Ожидание оплаты")]
    waiting_paying = 2
}