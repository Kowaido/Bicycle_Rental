using BicycleRental.Domain.Entities;
using BicycleRental.Domain.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace BicycleRental.WebAPI.Infrastructure;

public class StopingRepository : IStopingRepository
{
    private ApplicationDbContext _context;

    public StopingRepository(ApplicationDbContext context)
    {
        _context = context;
    }

    public async Task<Stoping?> GetByIdAsync(int id)
    {
        return await _context.Stoping.FindAsync(id);
    }

    public async Task<IEnumerable<Stoping>> GetAllAsync()
    {
        return await _context.Stoping.ToListAsync();
    }

    public async Task AddAsync(Stoping stoping)
    {
        await _context.Stoping.AddAsync(stoping);
        await _context.SaveChangesAsync();
    }

    public async Task UpdateAsync(Stoping stoping)
    {
        _context.Stoping.Update(stoping);
        await _context.SaveChangesAsync();
    }

    public async Task DeleteAsync(int id)
    {
        var stoping = await _context.Stoping.FindAsync(id);
        if (stoping != null)
        {
            _context.Stoping.Remove(stoping);
            await _context.SaveChangesAsync();
        }
    }
}