
public class TaskManager : ITaskManager
{
    private ITaskRepository _taskRepository;
    private IAccountRepository _accountRepository;

    public TaskManager(ITaskRepository taskRepository, IAccountRepository accountRepository)
    {
        _taskRepository = taskRepository;
        _accountRepository = accountRepository;
    }   
    public void AddTask(TrackerTask task)
    { 
        _taskRepository.AddTask(task);
    }

    public void Complete(int id)
    {
        _taskRepository.Complete(id);
    }

    public void DeleteTask(int taskId)
    { 
        _taskRepository.DeleteTask(taskId);
    } 

    public List<TrackerTask> GetAllTasks()
    { 
        return _taskRepository.GetAllTasks();
    }

    public TrackerTask GetTaskById(int taskId)
    { 
        return _taskRepository.GetTaskById(taskId);
    }
    public void RegisterAccount(User account)
    {
        _accountRepository.RegisterAccount(account);
    } 
    public User GetAccount(string accountName)
    {
        return _accountRepository.GetAccount(accountName);
    }
    public List<User> GetAccounts()
    {
        return _accountRepository.GetAccounts();
    }
    public bool VerifyAccount(string email, string password)
    {
        return _accountRepository.VerifyAccount(email, password);
    }

}