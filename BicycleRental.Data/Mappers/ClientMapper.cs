using BicycleRental.Domain.Entities;
using BicycleRental.WebAPI.Models;

namespace BicycleRental.WebAPI.Mapping;

public static class ClientMapper
{
    public static Client ToDomain(this ClientDb db)
    {
        return new Client
        {
            IdClient = db.IdClient,
            FirstName = db.FirstName,
            LastName = db.LastName,
            Surname = db.Surname,
            RentCount = db.RentCount,
            DateOfBirth = db.DateOfBirth
        };
    }

    public static ClientDb ToDb(this Client client)
    {
        return new ClientDb
        {
            IdClient = client.IdClient,
            FirstName = client.FirstName,
            LastName = client.LastName,
            Surname = client.Surname,
            RentCount = client.RentCount,
            DateOfBirth = client.DateOfBirth
        };
    }
}