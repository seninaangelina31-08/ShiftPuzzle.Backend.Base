using Microsoft.EntityFrameworkCore;

public class AccountContext : DbContext
{

    public AccountContext(DbContextOptions<AccountContext> options) : base(options)
    {
    }

    public DbSet<TrackerTask> TrackerTasks { get; set; }
    public DbSet<User> Users { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    { 
         modelBuilder.Entity<TrackerTask>().HasKey(task=>task.ID);
    }
}