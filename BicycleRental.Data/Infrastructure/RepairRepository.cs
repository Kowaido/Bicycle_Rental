using BicycleRental.Domain.Entities;
using BicycleRental.Domain.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace BicycleRental.WebAPI.Infrastructure;

public class RepairRepository : IRepairRepository
{
    private ApplicationDbContext _context;

    public RepairRepository(ApplicationDbContext context)
    {
        _context = context;
    }

    public async Task<Repair?> GetByIdAsync(int id)
    {
        return await _context.Repair.FindAsync(id);
    }

    public async Task<IEnumerable<Repair>> GetAllAsync()
    {
        return await _context.Repair.ToListAsync();
    }

    public async Task AddAsync(Repair entity)
    {
        await _context.Repair.AddAsync(entity);
        await _context.SaveChangesAsync();
    }

    public async Task UpdateAsync(Repair entity)
    {
        _context.Repair.Update(entity);
        await _context.SaveChangesAsync();
    }

    public async Task DeleteAsync(int id)
    {
        var repair = await _context.Repair.FindAsync(id);
        if (repair != null)
        {
            _context.Repair.Remove(repair);
            await _context.SaveChangesAsync();
        }
    }
}