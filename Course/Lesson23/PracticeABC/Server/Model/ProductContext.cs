using Microsoft.EntityFrameworkCore;
//А что тут надо сделать то?
namespace PracticeABC
{
    public class ProductContext : DbContext
    {
        public DbSet<Product> Products { get; set; }

        public ProductContext(DbContextOptions<ProductContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>().HasNoKey();
        }
    }
}
