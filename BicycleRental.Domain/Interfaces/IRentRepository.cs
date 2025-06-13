using BicycleRental.Domain.Entities;

namespace BicycleRental.Domain.Interfaces;

public interface IRentRepository
{
    Task<Rent?> GetByIdAsync(int id);
    Task<IEnumerable<Rent>> GetAllAsync();
    Task AddAsync(Rent rent);
    Task UpdateAsync(Rent rent);
    Task DeleteAsync(int id);
}