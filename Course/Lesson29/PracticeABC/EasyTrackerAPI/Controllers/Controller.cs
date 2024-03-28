using Microsoft.AspNetCore.Mvc;
using System;
using System.Net.Http;
using System.Collections.Generic;

[ApiController] 
[Route("api/tasks/")]
public class TasksController : ControllerBase
{
    private readonly ITaskManager _taskManager;
    public TasksController(ITaskManager taskManager)
    {
        _taskManager = taskManager;
    }

    [HttpGet("get/all")]
    public IActionResult GetAll()
    {
        return Ok(_taskManager.GetAllTasks());
    }

    [HttpGet("get/id")]
    public IActionResult GetId(int id)
    {
        var task = _taskManager.GetTaskById(id);
        if (task != null)
        {
            return Ok(task);
        }
        else
        {
            return NotFound("task is not find");
        }
    }

    [HttpPost("add")]
    public IActionResult GetId([FromBody] TrackerTask task)
    {
        _taskManager.AddTask(task);
        return Ok(_taskManager.GetAllTasks());
    }

    [HttpGet("delete/id")]
    public IActionResult DeleteId(int id)
    {
        var task = _taskManager.GetTaskById(id);
        if (task != null)
        {
            _taskManager.DeleteTask(task);
            return Ok("task was deleted");
        }
        else
        {
            return NotFound("task was not finded");
        }
    }

    [HttpGet("tasks/addrandom")]
    public IActionResult AddRandom(int x)
    {
        var newTask = new TrackerTask();
        var randomName = "Task #" + (lastTaskID + x).ToString();
        newTask.ID = lastTaskID + x;       
        newTask.Name = randomName;  
        newTask.Description = "This is a random task";   
        _taskManager.AddTask(newTask); 

        return Ok("random task was added to DB");
    }
}