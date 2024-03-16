public interface ITaskRepository
{
    List<TrackerTask> GetAllTasks();
    TrackerTask GetTaskById(int taskId);

    void AddTask(TrackerTask task);
    void DeleteTask(int taskId);
}
public class TaskRepository : ITaskRepository
{
    private readonly TaskContext _context;

    public TaskRepository(TaskContext context)
    {
        _context = context;
    }

    public void AddTask(TrackerTask task)
    {
        _context.TrackerTasks.Add(task);
        _context.SaveChanges();
    }

    public void DeleteTask(int taskId)
    {
        var task = _context.TrackerTasks.FirstOrDefault(tt => tt.ID == taskId);

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
        return _context.TrackerTasks.FirstOrDefault(tt => tt.ID == taskId);
    }
}
