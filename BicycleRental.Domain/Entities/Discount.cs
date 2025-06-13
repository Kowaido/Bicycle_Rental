using BicycleRental.Domain.Enums;

namespace BicycleRental.Domain.Entities;

public class Discount
{
    public int IdDiscount { get; set; }
    public string Name_discount { get; set; }
    public double Percent { get; set; }
    public DiscountMode Allowed { get; set; }
    public int IdRent { get; set; }
    public Rent Rents { get; set; }
}