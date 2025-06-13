using BicycleRental.Domain.Entities;

namespace BicycleRental.Domain.Interfaces;

public interface IRents_acceptRepository
{
    Task<Rents_accept?> GetByIdAsync(int id);
    Task<IEnumerable<Rents_accept>> GetAllAsync();
    Task AddAsync(Rents_accept rentsAccept);
    Task UpdateAsync(Rents_accept rentsAccept);
    Task DeleteAsync(int id);
}