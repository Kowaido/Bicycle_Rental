using BicycleRental.Domain.Entities;
using BicycleRental.Domain.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace BicycleRental.WebAPI.Infrastructure;

public class RentRepository : IRentRepository
{
    private ApplicationDbContext _context;

    public RentRepository(ApplicationDbContext context)
    {
        _context = context;
    }

    public async Task<Rent?> GetByIdAsync(int id)
    {
        return await _context.Rent.FindAsync(id);
    }

    public async Task<IEnumerable<Rent>> GetAllAsync()
    {
        return await _context.Rent.ToListAsync();
    }

    public async Task AddAsync(Rent rent)
    {
        await _context.Rent.AddAsync(rent);
        await _context.SaveChangesAsync();
    }

    public async Task UpdateAsync(Rent rent)
    {
        _context.Rent.Update(rent);
        await _context.SaveChangesAsync();
    }

    public async Task DeleteAsync(int id)
    {
        var rent = await _context.Rent.FindAsync(id);
        if (rent != null)
        {
            _context.Rent.Remove(rent);
            await _context.SaveChangesAsync();
        }
    }
}