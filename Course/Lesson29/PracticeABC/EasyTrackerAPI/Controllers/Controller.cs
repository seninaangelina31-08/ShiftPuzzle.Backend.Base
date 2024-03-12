namespace EasyTracker;

using Microsoft.AspNetCore.Mvc;
using System;
using System.Net.Http;
using System.Collections.Generic;

[ApiController] 
[Route("tasks/")]
public class TasksController : ControllerBase
{


    private readonly ITaskManager _taskManager;
    public TasksController(ITaskManager taskManager)
    {
        _taskManager = taskManager;
    }
    
    [HttpGet("/api/tasks/getall")]
    public IActionResult GetAll()
    {
        return Ok(_taskManager.GetAllTasks());
    }

    [HttpGet("/api/tasks/get/")]
    public IActionResult GetTask(int taskId)
    {
        var task = _taskManager.GetTaskById(taskId);
        if (task != null)
        {
            return Ok(task);
        }
        else
        {
            return NotFound("Tasks doesn`t found");
        }

    }

    [HttpPost("/api/tasks/add")]
    public IActionResult CreateTask([FromBody] TrackerTask task)
    {
        _taskManager.AddTask(task);
        return Ok(_taskManager.GetAllTasks());
    }

    [HttpDelete("/api/tasks/delete/")]
    public IActionResult DeleteTask(int taskId)
    {
        var task = _taskManager.GetTaskById(taskId);
        if (task != null)
        {
            _taskManager.DeleteTask(task);
            return Ok(_taskManager.GetAllTasks());
        }
        else
        {
            return NotFound("Tasks doesn`t found");
        }
    }

    [HttpGet("/api/tasks/addrandom/")]
    public IActionResult AddRandom()
    {
        Random random = new Random();
        TrackerTask ran = new TrackerTask();
        ran.ID = random.Next();
        _taskManager.AddTask(ran);
        return Ok(_taskManager.GetAllTasks);
    }
}