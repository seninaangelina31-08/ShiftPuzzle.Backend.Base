using EasyTracker;

public interface ITaskRepository
{
    List<TrackerTask> GetAllTasks();
    TrackerTask GetTaskById(int taskId);
    void AddTask(TrackerTask task); 
    void DeleteTask(TrackerTask taskId);
    void FinishTask(int id);
} 