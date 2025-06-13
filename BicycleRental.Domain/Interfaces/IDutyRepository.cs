
using BicycleRental.Domain.Entities;

namespace BicycleRental.Domain.Interfaces;

public interface IDutyRepository
{
    Task<Duty?> GetByIdAsync(int id);
    Task<IEnumerable<Duty>> GetAllAsync();
    Task AddAsync(Duty duty);
    Task UpdateAsync(Duty duty);
    Task DeleteAsync(int id);
}