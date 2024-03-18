using EasyTracker;

public class TaskRepository : ITaskRepository
{
    private readonly TaskTrackerContext _context;

    public TaskRepository(TaskTrackerContext context)
    {
        _context = context;
    }

    public void AddTask(TrackerTask task)
    {
        _context.TrackerTasks.Add(task);
        _context.SaveChanges();
    }

    public void DeleteTask(TrackerTask taskId)
    {
        var task = _context.TrackerTasks.FirstOrDefault(t => t.ID == taskId.ID);
        if (task != null)
        {
            _context.TrackerTasks.Remove(task);
            _context.SaveChanges();
        }
    }

    public List<TrackerTask> GetAllTasks()
    {
        return _context.TrackerTasks.ToList();
    }

    public TrackerTask GetTaskById(int taskId)
    {
        return _context.TrackerTasks.FirstOrDefault(t => t.ID == taskId);
    }

    public void FinishTask(int id)
    {
        var task = _context.TrackerTasks.FirstOrDefault(t => t.ID == id);
        if (task != null)
        {   
            task.IsComplete = true;
            _context.TrackerTasks.Update(task);
            _context.SaveChanges();
        }
    }
}