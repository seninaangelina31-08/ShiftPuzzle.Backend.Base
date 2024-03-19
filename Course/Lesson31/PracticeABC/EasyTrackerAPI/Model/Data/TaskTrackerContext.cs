using Microsoft.EntityFrameworkCore;

public class TaskTrackerContext : DbContext
{
    public TaskTrackerContext()
    {
    }
    public TaskTrackerContext(DbContextOptions<TaskTrackerContext> options) : base(options)
    {
    }

    public DbSet<TrackerTask> TrackerTasks { get; set; }
    public DbSet<User> Users { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {  
        modelBuilder.Entity<TrackerTask>().HasKey(task=>task.ID);  
        modelBuilder.Entity<User>().HasKey(u => u.ID);

        modelBuilder.Entity<TrackerTask>()
        .HasOne(t => t.AssignedUser);
    }
   
}