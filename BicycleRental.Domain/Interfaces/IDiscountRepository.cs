using BicycleRental.Domain.Entities;

namespace BicycleRental.Domain.Interfaces;

public interface IDiscountRepository
{
    Task<Discount?> GetByIdAsync(int id);
    Task<IEnumerable<Discount>> GetAllAsync();
    Task AddAsync(Discount discount);
    Task UpdateAsync(Discount discount);
    Task DeleteAsync(int id);
}