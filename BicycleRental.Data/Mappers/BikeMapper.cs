using BicycleRental.Domain.Entities;
using BicycleRental.WebAPI.Models;

namespace BicycleRental.WebAPI.Mapping;

public static class BikeMapper
{
    public static Bike ToDomain(this BikeDb db)
    {
        return new Bike
        {
            IdBike = db.IdBike,
            Count = db.Count,
            Marka = db.Marka,
            Number = db.Number
        };
    }

    public static BikeDb ToDb(this Bike domain)
    {
        return new BikeDb
        {
            IdBike = domain.IdBike,
            Count = domain.Count,
            Marka = domain.Marka,
            Number = domain.Number
        };
    }
}