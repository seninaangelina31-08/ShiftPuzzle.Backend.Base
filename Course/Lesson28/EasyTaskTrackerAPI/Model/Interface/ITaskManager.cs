public interface ITaskManager
{
    List<TrackerTask> GetAllTasks();
    TrackerTask GetTaskById(int taskId);
    void AddTask(TrackerTask task);
    void DeleteTask(TrackerTask taskId);
}

public class TaskManager : ITaskManager
{
    private ITaskRepository _taskRepository;
    public TaskManager(ITaskRepository taskRepository)
    {
        _taskRepository = taskRepository;
    }
    public void AddTask(TrackerTask task)
    {
        _taskRepository.AddTask(task);
    }

    public List<TrackerTask> GetAllTasks()
    {
        return _taskRepository.GetAllTasks();
    }
    public TrackerTask GetTaskById(int taskId)
    {
        return _taskRepository.GetTaskById(taskId);
    }
    public void DeleteTask(TrackerTask taskId)
    {
        _taskRepository.DeleteTask(taskId);
    }
}