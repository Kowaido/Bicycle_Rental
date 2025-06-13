namespace BicycleRental.Domain.Entities;

public class Stoping
{
    public int IdStop { get; set; }
    public Place Places { get; set; }
    public DateTime ArrivalDate { get; set; }
    public DateTime DepartureDate { get; set; }
    public int Count { get; set; }
}