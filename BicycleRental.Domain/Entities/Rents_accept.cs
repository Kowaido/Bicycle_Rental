namespace BicycleRental.Domain.Entities;

public class Rents_accept
{
    public Rent Rents { get; set; }
    public int IdRentAccept { get; set; }
    public bool Accepted { get; set; }
    public int IdEmployee  { get; set; }
    public List<Employee> Employee { get; set; }
}