namespace PracticeABC;

public class TaskRepository : ITaskRepository
{
    private readonly TaskContext _context;

    public TaskRepository(TaskContext context)
    {
        _context = context;
    }

    public List<TrackerTask> GetAllTasks()
    {
        return _context.TrackerTasks.ToList();
    }

    public void AddTask(TrackerTask task)
    {
        _context.TrackerTasks.Add(task);
        _context.SaveChanges();
    }

    public void DeleteTask(TrackerTask taskId)
    {
        var task = GetTaskById(taskId.ID);
        if (task != null)
        {
            _context.TrackerTasks.Remove(task);
            _context.SaveChanges();
        }
    }

    public TrackerTask GetTaskById(int taskId)
    {
        var task = _context.TrackerTasks.FirstOrDefault(t => t.ID == taskId);
        return task;
    }
}