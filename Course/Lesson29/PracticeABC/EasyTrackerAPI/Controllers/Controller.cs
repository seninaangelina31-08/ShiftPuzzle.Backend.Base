namespace EasyTracker;

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

    [HttpGet("getall")]
    public IActionResult GetAll()
    {
        return Ok(_taskManager.GetAllTasks());
    }

    [HttpGet("get/id")]
    public IActionResult GetTask(int id)
    {
        var task = _taskManager.GetTaskById(id);
        if (task != null)
        {
            return Ok(task);
        }
        else
        {
            return NotFound("Товар не найден");
        }

    }

    [HttpPost("addtask")]
    public IActionResult CreateTask([FromBody] TrackerTask task)
    {
        _taskManager.AddTask(task);
        return Ok(_taskManager.GetAllTasks());
    }

    [HttpDelete("deletetask")]
    public IActionResult DeleteTask(int id)
    {
        var task = _taskManager.GetTaskById(id);
        if (task != null)
        {
            _taskManager.DeleteTask(task);
            return Ok("Товар удалён");
        }
        else
        {
            return NotFound("Товар не найден");
        }
    }
}