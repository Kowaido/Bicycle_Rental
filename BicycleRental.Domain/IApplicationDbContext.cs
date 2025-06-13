using BicycleRental.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace BicycleRental.Domain;

public interface IApplicationDbContext
{
    DbSet<Bike> Bike { get; }
    DbSet<Client> Client { get; }
    DbSet<Discount> Discount { get; }
    DbSet<Duty> Duty { get; }
    DbSet<Employee> Employee { get; }
    DbSet<PayCheck> PayCheck { get; }
    DbSet<Place> Place { get; }
    DbSet<Rent> Rent { get; }
    DbSet<Rents_accept> Rents_accept { get; }
    DbSet<Repair> Repair { get; }
    DbSet<Stoping> Stoping { get; }
    DbSet<User> User { get; }
    
    Task<int> SaveChangesAsync(CancellationToken cancellationToken = default);
}