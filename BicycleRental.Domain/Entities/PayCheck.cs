namespace BicycleRental.Domain.Entities;

public class PayCheck
{
    public int IdPaycheck { get; set; }
    public Duty Duties { get; set; }
    public List<Employee> Employee { get; set; }
}