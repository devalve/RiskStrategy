using Microsoft.EntityFrameworkCore;

namespace RiskStrategy.Models;

public class AppDbContext : DbContext
{
    public DbSet<Company> Companies { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseInMemoryDatabase("MyDatabase");
    }
}   