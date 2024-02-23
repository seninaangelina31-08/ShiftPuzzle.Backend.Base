namespace PracticeABC;

using Microsoft.EntityFrameworkCore;

public class ProductContext : DbContext
{
    public DbSet<Product> Products { get; set; }

    public ProductContext(DbContextOptions<ProductContext> options) : base(options) {}

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Product>().HasNoKey();
    }
}