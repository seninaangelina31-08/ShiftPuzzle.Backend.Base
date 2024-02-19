using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using PracticeABC;


public class ProductContext: DbContext {
    public DbSet<Product> Products {get; set;}

    public ProductContext(DbContextOptions<ProductContext> options): base(options) {}
    protected override void OnModelCreating(ModelBuilder modelBuilder) {
        modelBuilder.Entity<Product>().HasNoKey();
    }
}