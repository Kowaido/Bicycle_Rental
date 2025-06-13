using BicycleRental.Domain.Entities;

namespace BicycleRental.Domain.Interfaces;

public interface IPlaceRepository
{
    Task<Place?> GetByIdAsync(int id);
    Task<IEnumerable<Place>> GetAllAsync();
    Task AddAsync(Place place);
    Task UpdateAsync(Place place);
    Task DeleteAsync(int id);
}