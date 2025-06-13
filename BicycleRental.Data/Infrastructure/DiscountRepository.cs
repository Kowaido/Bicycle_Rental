using BicycleRental.Domain.Interfaces;
using BicycleRental.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace BicycleRental.WebAPI.Infrastructure;

public class DiscountRepository : IDiscountRepository
{
    private readonly ApplicationDbContext _context;

    public DiscountRepository(ApplicationDbContext context)
    {
        _context = context;
    }

    public async Task<Discount?> GetByIdAsync(int id)
    {
        return await _context.Discount.FindAsync(id);
    }

    public async Task<IEnumerable<Discount>> GetAllAsync()
    {
        return await _context.Discount.ToListAsync();
    }

    public async Task AddAsync(Discount discount)
    {
        await _context.Discount.AddAsync(discount);
        await _context.SaveChangesAsync();
    }

    public async Task UpdateAsync(Discount discount)
    {
        _context.Discount.Update(discount);
        await _context.SaveChangesAsync();
    }

    public async Task DeleteAsync(int id)
    {
        var discount = await _context.Discount.FindAsync(id);
        if (discount != null)
        {
            _context.Discount.Remove(discount);
            await _context.SaveChangesAsync();
        }
    }
}