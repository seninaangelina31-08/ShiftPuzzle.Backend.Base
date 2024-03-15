using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Internal;

public class TaskTrackerContext : DbContext
{
 
    public TaskTrackerContext(DbContextOptions<TaskTrackerContext> options): base(options) {}
    public DbSet<TrackerTask> TrackerTasks {get; set;}
    public DbSet<User> Users {get; set;}

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<TrackerTask>().HasKey(t=>t.ID);
        modelBuilder.Entity<User>().HasKey(u=>u.ID);

        modelBuilder.Entity<TrackerTask>().HasOne(t => t.AssignedUser).WithMany(u => u.Tasks);
    }
}