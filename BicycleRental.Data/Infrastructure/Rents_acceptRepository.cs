using BicycleRental.Domain.Entities;
using BicycleRental.Domain.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace BicycleRental.WebAPI.Infrastructure;

public class Rents_acceptRepository : IRents_acceptRepository
{
    private readonly ApplicationDbContext _context;

    public Rents_acceptRepository(ApplicationDbContext context)
    {
        _context = context;
    }

    public async Task<Rents_accept?> GetByIdAsync(int id)
    {
        return await _context.Rents_accept.FindAsync(id);
    }

    public async Task<IEnumerable<Rents_accept>> GetAllAsync()
    {
        return await _context.Rents_accept.ToListAsync();
    }

    public async Task AddAsync(Rents_accept rents_accept)
    {
        await _context.Rents_accept.AddAsync(rents_accept);
        await _context.SaveChangesAsync();
    }

    public async Task UpdateAsync(Rents_accept rents_accept)
    {
        _context.Rents_accept.Update(rents_accept);
        await _context.SaveChangesAsync();
    }

    public async Task DeleteAsync(int id)
    {
        var rents_accept = await _context.Rents_accept.FindAsync(id);
        if (rents_accept != null)
        {
            _context.Rents_accept.Remove(rents_accept);
            await _context.SaveChangesAsync();
        }
    }
}