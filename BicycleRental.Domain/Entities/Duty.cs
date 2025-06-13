using BicycleRental.Domain.Enums;

namespace BicycleRental.Domain.Entities;

public class Duty
{
    public DateTime DateDuty { get; set; }
    public Client Clients { get; set; }
    public List<PayCheck> PayCheck { get; set; }
    public decimal SumDuty { get; set; }
    public DutyMode Status { get; set; }
    public int IdDuty { get; set; }
}