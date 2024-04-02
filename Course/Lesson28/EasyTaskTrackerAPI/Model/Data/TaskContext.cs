namespace EasyTaskTrackerAPI;
{
    
}using Microsoft.Entity.FrameworkCore;

public class TaskContext : DbContext
{
    public class TaskContext(DbContextOptions<TaskContext> options) : base(options){}

    public DbSet<TrackerTask> TrackerTasks {get; set; }
    protected override void OnModeCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<TrackerTask>().HasKey(t => t.ID)
    }
}