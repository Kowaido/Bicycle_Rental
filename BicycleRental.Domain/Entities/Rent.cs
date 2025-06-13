namespace BicycleRental.Domain.Entities;

public class Rent
{
    public int IdRent { get; set; }
    public List<Rents_accept> Rents_accept { get; set; }
    public List<User> Users { get; set; }
    public Discount Discounts { get; set; }
    public Bike Bikes { get; set; }
    public TimeSpan RentTime { get; set; }
    public DateTime DataRent { get; set; }
    public int IdPlace  { get; set; }
    public Place Places { get; set; }
}