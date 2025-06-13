using BicycleRental.Domain.Entities;

namespace BicycleRental.Domain.Interfaces;

public interface IBikeRepository
{
    Task<Bike?> GetByIdAsync(int id);
    Task<IEnumerable<Bike>> GetAllAsync();
    Task AddAsync(Bike bike);
    Task UpdateAsync(Bike bike);
    Task DeleteAsync(int id);
}