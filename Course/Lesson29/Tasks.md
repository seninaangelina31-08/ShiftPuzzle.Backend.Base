

---
# Практика А:

1.  CОЗДАТЬ КОНТРОЛЛЕР ДЛЯ ЗАДАЧ, КОТОРЫЙ ДОЛЖЕН: 

    - Получить все таски        [HttpGet("/api/tasks/getall")]
    - Получить таск по ID       [HttpGet("/api/tasks/get/{id}")]
    - Создать таск              [HttpPost("/api/tasks/add")]
    - Удалить таск по ID        [HttpGet("/api/tasks/delete/{id}")]

 
--- 
# Практика B: 

1.  Cоздать Get запрос для генерации  случайных записей в  БД     
                                [HttpGet("/api/tasks/addrandom/{id}")]

Подсказка: 

```C#
var newTask = new TrackerTask();
            var randomName = "Task #" + (lastTaskID + x).ToString();
            newTask.ID = lastTaskID + x;       
            newTask.Name = randomName;  
            newTask.Description = "This is a random task";   
            _taskManager.AddTask(newTask); 
```

--- 
# Практика C:

1.  Cоздать Reame.md файл с описанием каждого метода АПИ.









































public class TaskContrller : ControllerBase
{
    private readonly ITaskManager _taskManager;

    public TaskContrller(ITaskManager taskManager)
    {
        _taskManager = taskManager;
    }   

    [HttpGet]
    [Route("/api/tasks/getall")]
    public IEnumerable<TrackerTask> GetAll()
    {
        return _taskManager.GetAllTasks();
    }

    [HttpGet]
    [Route("/api/tasks/get")]
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


    [HttpGet("/api/tasks/addrandom/{id}")]
    public void AddRandom(int id)
    {
         for(int x = 0 ; x < id;x++ )
         {
            int lastTaskID = 0 ;
            try
            {
                var tasks = _taskManager.GetAllTasks(); 
                lastTaskID = tasks.Max(t => t.ID);   
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
            _taskManager.AddTask(newTask); 
         }
    }

}