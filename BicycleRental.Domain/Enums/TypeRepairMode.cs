using System.ComponentModel;

namespace BicycleRental.Domain.Enums;

/// <summary>
/// TODO: Перечесление типов ремонта
/// </summary>
public enum TypeRepairMode
{
   [Description("Обслуживании и небольшой ремонт")]
   RepLittleAndServe = 0,
   [Description("Ремонт рам и вилок")]
   RepFrameForks = 1,
   [Description("Ремонт трансмисии")]
   RepTransmistria = 2,
   [Description("Ремонт тормозов")]
   RepStopSystem = 3,
   [Description("Ремонт колёс")]
   RepWheel = 4,
   [Description("Другие виды ремонта")]
   RepAnother = 5
}