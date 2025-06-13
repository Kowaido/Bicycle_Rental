using BicycleRental.Domain.Entities;
using BicycleRental.Domain.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace BicycleRental.WebAPI.Infrastructure;

public class EmployeeRepository : IEmployeeRepository
{
    private ApplicationDbContext _context;

    public EmployeeRepository(ApplicationDbContext context)
    {
        _context = context;
    }

    public async Task<Employee?> GetByIdAsync(int id)
    {
        return await _context.Employee.FindAsync(id);
    }

    public async Task<IEnumerable<Employee>> GetAllAsync()
    {
        return await _context.Employee.ToListAsync();
    }

    public async Task AddAsync(Employee employeedb)
    {
        await _context.Employee.AddAsync(employeedb);
        await _context.SaveChangesAsync();
    }

    public async Task UpdateAsync(Employee employeedb)
    {
        _context.Employee.Update(employeedb);
        await _context.SaveChangesAsync();
    }

    public async Task DeleteAsync(int id)
    {
        var employee = await _context.Employee.FindAsync(id);
        if (employee != null)
        {
            _context.Employee.Remove(employee);
            await _context.SaveChangesAsync();
        }
    }
}