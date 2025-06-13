namespace BicycleRental.Domain.Entities;

public class Bike
{
    public int IdBike { get; set; }
    public string Marka { get; set; }
    public int Count { get; set; }
    public int Number { get; set; }
    public List<Repair> Repair { get; set; }
    public List<Rent> Rent { get; set; }
}