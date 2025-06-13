using BicycleRental.Domain.Entities;
using BicycleRental.Domain.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace BicycleRental.WebAPI.Infrastructure;

public class PayCheckRepository : IPayCheckRepository
{
    private readonly ApplicationDbContext _context;

    public PayCheckRepository(ApplicationDbContext context)
    {
        _context = context;
    }

    public async Task<PayCheck?> GetByIdAsync(int id)
    {
        return await _context.PayCheck.FindAsync(id);
    }

    public async Task<IEnumerable<PayCheck>> GetAllAsync()
    {
        return await _context.PayCheck.ToListAsync();
    }

    public async Task AddAsync(PayCheck payCheck)
    {
        await _context.PayCheck.AddAsync(payCheck);
        await _context.SaveChangesAsync();
    }

    public async Task UpdateAsync(PayCheck payCheck)
    {
        _context.PayCheck.Update(payCheck);
        await _context.SaveChangesAsync();
    }

    public async Task DeleteAsync(int id)
    {
        var payCheck = await _context.PayCheck.FindAsync(id);
        if (payCheck != null)
        {
            _context.PayCheck.Remove(payCheck);
            await _context.SaveChangesAsync();
        }
    }
}