using BicycleRental.Domain.Enums;

namespace BicycleRental.Domain.Entities;

public class Repair
{
    public int IdRepairBike { get; set; }
    public Bike Bikes { get; set; }
    public List<Employee> Employee { get; set; }
    public bool StatusBike { get; set; }
    public TypeRepairMode TypeRepair { get; set; }
    public string CommentRepair { get; set; }
}