using Microsoft.EntityFrameworkCore;

namespace Homework
{
    public class ToadContext : DbContext
    {
        public DbSet<Toad> Toads { get; set; }

        public ToadContext(DbContextOptions<ToadContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Toad>().HasKey("Name");
        }
    }
}
