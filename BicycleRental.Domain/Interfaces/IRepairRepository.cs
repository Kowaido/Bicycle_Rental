using BicycleRental.Domain.Entities;

namespace BicycleRental.Domain.Interfaces;

public interface IRepairRepository
{
    Task<Repair?> GetByIdAsync(int id);
    Task<IEnumerable<Repair>> GetAllAsync();
    Task AddAsync(Repair repair);
    Task UpdateAsync(Repair repair);
    Task DeleteAsync(int id);
}