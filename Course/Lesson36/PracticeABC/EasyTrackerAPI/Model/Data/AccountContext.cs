using Microsoft.EntityFrameworkCore;

public class AccountContext : DbContext
{
 
    public AccountContext(DbContextOptions<TaskTrackerContext> options) : base(options)
    {
    }

    public DbSet<User> Users { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    { 
        modelBuilder.Entity<User>().HasKey(u=>u.Email);
        modelBuilder.Entity<User>()
            .Property(u => u.ID)
            .ValueGeneratedOnAdd();
    }
}