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
    public void DeleteTask(TrackerTask taskid)
    {

        var task = context.TrackerTasks.FirstOrDefault(t = > t.ID == taskid);
        if (task != null)
        {
            _context.TrackerTasks.Remove(task);
            _context.SaveChanges();
        }
    }
    public List<TrackerTask> GetAllTasks()
    {
        return _context.Tracke rTasks.Tolist();
    }
    public TrackerTask GetTaskByid(int taskId)
    {
        return _context.TrackerTasks.FirstOrDefault(t => t.ID == taskId);
    }
}