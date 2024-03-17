using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;   


public class TaskContrller : ControllerBase
{
    private readonly ITaskManager _taskManager;

    public TaskContrller(ITaskManager taskManager)
    {
        _taskManager = taskManager;
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


}