namespace BicycleRental.Domain.Entities;

public class Place
{
    public int IdPlace { get; set; }
    public string NamePlace { get; set; }
    public double Distance { get; set; }
    public Rent Rents { get; set; }
    public bool ChoosePlace { get; set; }
    public List<Stoping> Stoping { get; set; }
}