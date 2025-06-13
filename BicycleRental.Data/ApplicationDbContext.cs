using BicycleRental.Domain;
using BicycleRental.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace BicycleRental.WebAPI;

public class ApplicationDbContext : DbContext, IApplicationDbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) 
        : base(options) {}
    
    public DbSet<Bike> Bike { get; set; }
    public DbSet<Client> Client { get; set; }
    public DbSet<Discount> Discount { get; set; }
    public DbSet<Duty> Duty { get; set; }
    public DbSet<Employee> Employee { get; set; }
    public DbSet<PayCheck> PayCheck { get; set; }
    public DbSet<Place> Place { get; set; }
    public DbSet<Rent> Rent { get; set; }
    public DbSet<Rents_accept> Rents_accept { get; set; }
    public DbSet<Repair> Repair { get; set; }
    public DbSet<Stoping> Stoping { get; set; }
    public DbSet<User> User { get; set; }

    public Task<int> SaveChangesAsync(CancellationToken cancellationToken = new CancellationToken()) =>
        base.SaveChangesAsync(cancellationToken);

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfigurationsFromAssembly(typeof(ApplicationDbContext).Assembly);
    }
}