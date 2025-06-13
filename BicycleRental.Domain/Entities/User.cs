namespace BicycleRental.Domain.Entities;

public class User
{
    public int IdUser { get; set; }
    public Client Clients { get; set; }
    public Employee Employees { get; set; }
    public string Username { get; set; }
    public string HashedPassword { get; set; }
    public string Email { get; set; }
    public Rent Rents { get; set; }
}