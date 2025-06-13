using BicycleRental.Domain.Entities;
using BicycleRental.WebAPI.Models;

namespace BicycleRental.WebAPI.Mapping;

public static class DiscountMapper
{
    public static Discount ToDomain(this DiscountDb db)
    {
        return new Discount
        {
            IdDiscount = db.IdDiscount,
            Name_discount = db.Name_discount,
            Percent = db.Percent,
            Allowed = db.Allowed
        };
    }

    public static DiscountDb ToDb(this Discount discount)
    {
        return new DiscountDb
        {
            IdDiscount = discount.IdDiscount,
            Name_discount = discount.Name_discount,
            Percent = discount.Percent,
            Allowed = discount.Allowed
        };
    }
}