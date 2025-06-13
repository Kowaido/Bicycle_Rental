using BicycleRental.Domain.Interfaces;
using BicycleRental.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace BicycleRental.WebAPI.Infrastructure;

public class ClientRepository : IClientRepository
{
    private readonly ApplicationDbContext _context;

    public ClientRepository(ApplicationDbContext context)
    {
        _context = context;
    }

    public async Task<Client?> GetByIdAsync(int id)
    {
        return await _context.Client.FindAsync(id);
    }

    public async Task<IEnumerable<Client>> GetAllAsync()
    {
        return await _context.Client.ToListAsync();
    }

    public async Task AddAsync(Client client)
    {
        await _context.Client.AddAsync(client);
        await _context.SaveChangesAsync();
    }

    public async Task UpdateAsync(Client client)
    {
        _context.Update(client);
        await _context.SaveChangesAsync();
    }

    public async Task DeleteAsync(int id)
    {
        var client = await _context.Client.FindAsync(id);
        if (client != null)
        {
            _context.Client.Remove(client);
            await _context.SaveChangesAsync();
        }
    }
}