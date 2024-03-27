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

    public void DeleteTask(int taskid)
    {   
        _context.TrackerTasks.Where(t => t.ID == taskid).ToList().ForEach(t => _context.TrackerTasks.Remove(t));
        _context.SaveChanges(); 
    }

    public List<TrackerTask> GetAllTasks()
    {
        return _context.TrackerTasks.ToList();
    }

    public TrackerTask GetTaskById(int taskId)
    {
        return _context.TrackerTasks.FirstOrDefault(t => t.ID == taskId);
    }
    public void CompleteTask(int id)
    {
        var task = this.GetAllTasks().FirstOrDefault(task => task.ID == id);
        if (task)
        {
            task.IsComplete = true;
            _context.SaveChanges();
            Console.WriteLine($"Задача с ID = {id} завершена");
        }
        else
        {
            Console.WriteLine($"Задачи с ID = {id} нет");
        }
    }
}