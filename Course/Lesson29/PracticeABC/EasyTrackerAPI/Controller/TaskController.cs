using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic; 
using System;
using System.Linq;  

//1.  CОЗДАТЬ КОНТРОЛЛЕР ДЛЯ ЗАДАЧ, КОТОРЫЙ ДОЛЖЕН: 






//# Практика B: 

//1.  Cоздать Get запрос для генерации  случайных записей в  БД   [HttpGet("/api/tasks/addrandom/{id}")]
[ApiController]
public class TaskContrller : ControllerBase
{
    private readonly ITaskManager _taskManager;


    public TaskContrller(ITaskManager taskManager)
    {
        _taskManager = taskManager;
    }   
//    - Получить все таски        [HttpGet("/api/tasks/getall")]
    [HttpGet("/api/tasks/getall")]
    public IEnumerable<TrackerTask> GetAll()
    {
        return _taskManager.GetAllTasks();
    }

//    - Получить таск по ID       [HttpGet("/api/tasks/get/{id}")]
    [HttpGet("/api/tasks/get/{id}")]
    public TrackerTask GetByID(int id)
    {
        return _taskManager.GetTaskById(id);
    }

//    - Создать таск              [HttpPost("/api/tasks/add")]
    [HttpPost("/api/tasks/add")]
    public void AddTaskk([FromBody] TrackerTask task)
    {
        _taskManager.AddTask(task);
    }

//    - Удалить таск по ID        [HttpGet("/api/tasks/delete/{id}")]
    [HttpGet("/api/tasks/delete/{id}")]
    public void DeleteTaskk(TrackerTask id)
    {  
       _taskManager.DeleteTask(id);
    }


    [HttpGet("/api/tasks/addrandom/{id}")]
    public void AddRandomTask(int id)
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