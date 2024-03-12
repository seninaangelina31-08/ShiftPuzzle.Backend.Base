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

    [HttpGet("getall")]
    public IActionResult GetAll()
    {
        return Ok(_taskManager.GetAllTasks());
    }

    [HttpGet("getID")]
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

    [HttpPost("addtask")]
    public IActionResult CreateTask([FromBody] TrackerTask task)
    {
        _taskManager.AddTask(task);
        return Ok(_taskManager.GetAllTasks());
    }

    [HttpDelete("deletetask")]
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
}