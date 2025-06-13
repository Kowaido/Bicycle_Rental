using BicycleRental.Domain.Entities;

namespace BicycleRental.Domain.Interfaces;

public interface IStopingRepository
{
    Task<Stoping?> GetByIdAsync(int id);
    Task<IEnumerable<Stoping>> GetAllAsync();
    Task AddAsync(Stoping stoping);
    Task UpdateAsync(Stoping stoping);
    Task DeleteAsync(int id);
}