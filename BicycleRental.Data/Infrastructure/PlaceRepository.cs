using BicycleRental.Domain.Entities;
using BicycleRental.Domain.Interfaces;
using BicycleRental.WebAPI.Models;
using Microsoft.EntityFrameworkCore;
using Place = BicycleRental.Domain.Entities.Place;

namespace BicycleRental.WebAPI.Infrastructure;

public class PlaceRepository : IPlaceRepository
{
    private readonly ApplicationDbContext _context;

    public PlaceRepository(ApplicationDbContext context)
    {
        _context = context;
    }

    public async Task<Place?> GetByIdAsync(int id)
    {
        return await _context.Place.FindAsync(id);
    }

    public async Task<IEnumerable<Place>> GetAllAsync()
    {
        return await _context.Place.ToListAsync();
    }

    public async Task AddAsync(Place place)
    {
        await _context.Place.AddAsync(place);
        await _context.SaveChangesAsync();
    }

    public async Task UpdateAsync(Place place)
    {
        _context.Place.Update(place);
        await _context.SaveChangesAsync();
    }

    public async Task DeleteAsync(int id)
    {
        var place = await _context.Place.FindAsync(id);
        if (place != null)
        {
            _context.Place.Remove(place);
            await _context.SaveChangesAsync();
        }
    }
}