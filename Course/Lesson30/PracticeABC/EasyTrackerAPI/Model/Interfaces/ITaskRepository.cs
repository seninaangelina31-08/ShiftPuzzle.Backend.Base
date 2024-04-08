
//> ПОДСКАЗКА:

//Нужно создать метод обработки в TaskRepository, где изменяется состояние свойства IsComplete. 

public interface ITaskRepository
{
    List<TrackerTask> GetAllTasks();
    TrackerTask GetTaskById(int taskId);
    void AddTask(TrackerTask task); 
    
    void DeleteTask(int taskId);
} 