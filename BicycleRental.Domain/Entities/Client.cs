namespace BicycleRental.Domain.Entities;

public class Client
{
    public int IdClient { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Surname { get; set; }
    public int RentCount { get; set; }
    public DateTime DateOfBirth { get; set; }
    public List<Duty> Duty { get; set; }
    public List<User> Users { get; set; }
}