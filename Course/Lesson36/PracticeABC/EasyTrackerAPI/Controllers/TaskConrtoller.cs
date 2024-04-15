using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;   

public class TaskController : ControllerBase
{
    private readonly ITaskManager _taskManager;
    private readonly IAccountManager _accountManager;

    public TaskController(ITaskManager taskManager, IAccountManager accountManager)
    {
        _taskManager = taskManager;
        _accountManager = accountManager;
    }
    }   

    [HttpGet("/api/tasks/getall")]
    public IEnumerable<TrackerTask> GetAll()
    {
        return _taskManager.GetAllTasks();
    }

    [HttpGet("/api/tasks/get/{id}")]
    public TrackerTask Get(int id)
    {
        return _taskManager.GetTaskById(id);
    }


    [HttpPost("/api/tasks/add")]
    public void Create([FromBody] TrackerTask task)
    {
        _taskManager.AddTask(task);
    }

    [HttpGet("/api/tasks/delete/{id}")]
    public void Delete(int id)
    {  
        _taskManager.DeleteTask(id); 
    }

    [HttpGet("/api/tasks/complete/{id}")]
    public void CompleteTask(int id)
    {
        _taskManager.Complete(id);
    }



    [HttpGet("/api/tasks/addrandom/{id}")]
    public void User(int id)
    {
         for(int x = 0 ; x < id;x++ )
         {
            int lastTaskID = 0 ;
            try
            {
                var tasks = _taskManager.GetAllTasks(); 
                lastTaskID = (int)tasks.Max(t => t.ID);   
            } 
            catch
            {
                lastTaskID = 0; 
            }
            
            var newTask = new TrackerTask();
            var randomName = "Task #" + (lastTaskID + x).ToString();
            newTask.ID = lastTaskID + x;       
            newTask.Name = randomName;  
            newTask.Description = "This is a random task";   
            newTask.DueDate = new DateTime();
            newTask.AssignedUser = new User("alkihuri");
            _taskManager.AddTask(newTask); 
         }

public class AccountContext : DbContext
{
    public DbSet<User> Users { get; set; }

    public AccountContext(DbContextOptions<AccountContext> options)
        : base(options)
    {
    }
}
public class AccountManager : IAccountManager
{
    private readonly AccountContext _context;
    private User CurrentUser;

    public AccountManager(AccountContext context)
    {
        _context = context;
    }

    public bool VerifyAccount(User account)
    {
        if(_context.Users.Any(u => u.Name == account.Name && u.Password == account.Password))
        {
            CurrentUser = account;
            Console.WriteLine("Account verified.");
            return true;    
        }
        else 
        {
            Console.WriteLine("Account not verified.");
            return false; 
        }    
    }
}}