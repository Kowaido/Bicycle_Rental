using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace BicycleRental.WebAPI;

public class DesingTimeDbContextFactory : IDesignTimeDbContextFactory<ApplicationDbContext>
{
    public ApplicationDbContext CreateDbContext(string[] args)
    {
        var optionsBuilder = new DbContextOptionsBuilder<ApplicationDbContext>();
        
        optionsBuilder.UseNpgsql("Host=localhost; Port=5432; Database=Bicycle Rental; Username=postgres; Password=1");

        return new ApplicationDbContext(optionsBuilder.Options);
    }
}