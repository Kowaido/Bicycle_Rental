using BicycleRental.Domain.Entities;

namespace BicycleRental.Domain.Interfaces;

public interface IPayCheckRepository
{
    Task<PayCheck?> GetByIdAsync(int id);
    Task<IEnumerable<PayCheck>> GetAllAsync();
    Task AddAsync(PayCheck payCheck);
    Task UpdateAsync(PayCheck payCheck);
    Task DeleteAsync(int id);
}