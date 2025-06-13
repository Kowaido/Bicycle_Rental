using BicycleRental.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using BicycleRental.Domain.Interfaces;

namespace BicycleRental.WebAPI.Infrastructure;

public class BikeRepository : IBikeRepository
{
    private readonly ApplicationDbContext _context;

    public BikeRepository(ApplicationDbContext context)
    {
        _context = context;
    }

    public async Task<Bike?> GetByIdAsync(int id)
    {
        return await _context.Bike.FindAsync(id);
    }

    public async Task<IEnumerable<Bike>> GetAllAsync()
    {
        return await _context.Bike.ToListAsync();
    }

    public async Task AddAsync(Bike bike)
    {
        await _context.Bike.AddAsync(bike);
        await _context.SaveChangesAsync();
    }

    public async Task UpdateAsync(Bike bike)
    {
        _context.Bike.Update(bike);
        await _context.SaveChangesAsync();
    }

    public async Task DeleteAsync(int id)
    {
        var bike = await _context.Bike.FindAsync(id);
        if (bike != null)
        {
            _context.Bike.Remove(bike);
            await _context.SaveChangesAsync();
        }
    }
}