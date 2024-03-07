
public interface ITaskManager
{
    List<TrackerTask> GetAllTasks();
    TrackerTask GetTaskByid(int taskId);
    void AddTask(TrackerTask task);
    void DeleteTask(TrackerTask taskId);
}

