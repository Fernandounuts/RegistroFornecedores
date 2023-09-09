using CustomerRegistration.Models;
using Microsoft.EntityFrameworkCore;

namespace CustomerRegistration.Infra.Data; 
public class AppDbContext : DbContext{
    public DbSet<Supplier> Suppliers { get; set; }
    public DbSet<Adress> Adresses { get; set; }
    public DbSet<Country> Countries { get; set; }

    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

}
