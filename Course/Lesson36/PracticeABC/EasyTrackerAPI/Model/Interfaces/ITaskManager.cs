public interface ITaskManager
{
    List<TrackerTask> GetAllTasks();
    TrackerTask GetTaskById(int taskId);
    void AddTask(TrackerTask task);
    void DeleteTask(int taskId);

    void Complete(int id);
    void RegisterAccount(User account); 
    User GetAccount(string accountName);
    List<User> GetAccounts(); 
    bool VerifyAccount(string email, string password);

}