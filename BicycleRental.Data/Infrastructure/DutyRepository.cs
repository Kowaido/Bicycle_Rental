using BicycleRental.Domain.Entities;
using BicycleRental.Domain.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace BicycleRental.WebAPI.Infrastructure;

public class DutyRepository : IDutyRepository
{
    private readonly ApplicationDbContext _dbContext;

    public DutyRepository(ApplicationDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    public async Task<Duty?> GetByIdAsync(int id)
    {
        return await _dbContext.Duty.FindAsync(id);
    }

    public async Task<IEnumerable<Duty>> GetAllAsync()
    {
        return await _dbContext.Duty.ToListAsync();
    }

    public async Task AddAsync(Duty duty)
    {
        await _dbContext.Duty.AddAsync(duty);
        await _dbContext.SaveChangesAsync();
    }

    public async Task UpdateAsync(Duty duty)
    {
        _dbContext.Duty.Update(duty);
        await _dbContext.SaveChangesAsync();
    }

    public async Task DeleteAsync(int id)
    {
        var duty = await _dbContext.Duty.FindAsync(id);
        if (duty != null)
        {
            _dbContext.Duty.Remove(duty);
            await _dbContext.SaveChangesAsync();
        }
    }
}