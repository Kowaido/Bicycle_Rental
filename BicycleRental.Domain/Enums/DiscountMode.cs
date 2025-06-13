using System.ComponentModel;

namespace BicycleRental.Domain.Enums;

/// <summary>
/// Режим определения применения скидки
/// </summary>
public enum DiscountMode
{
    /// <summary>
    /// Принимается
    /// </summary>
    [Description("Применима")]
    accept = 0,
    
    /// <summary>
    /// Не принимается
    /// </summary>
    [Description("Не применима")]
    notaccept = 1
}