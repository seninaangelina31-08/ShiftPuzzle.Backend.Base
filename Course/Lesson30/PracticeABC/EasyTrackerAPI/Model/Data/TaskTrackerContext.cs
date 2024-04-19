using Microsoft.EntityFrameworkCore;

public class TaskContext : DbContext
{

    public TaskContext(DbContextOptions<TaskContext> options) : base(options) { }

    public DbSet<TrackerTask> TrackerTasks { get; set; } = null!;
    public DbSet<User> Users { get; set; } = null!;

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<TrackerTask>().HasKey(t => t.ID);
        modelBuilder.Entity<User>().HasKey(u => u.ID);

        modelBuilder.Entity<TrackerTask>()
        .HasOne(t => t.AssignedUser)
        .WithMany(u => u.Tasks);
    }
}