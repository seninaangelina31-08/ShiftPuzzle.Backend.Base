namespace EasyTrackerAPI;

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

    [HttpGet("gettask")]
    public IActionResult GetTask(int taskId)
    {
        var task = _taskManager.GetTaskById(taskId);
        if (task != null)
        {
            return Ok(task);
        }
        else
        {
            return NotFound("Задача не найдена");
        }

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
            return NotFound("Задача не найдена");
        }
    }

    [HttpPost("createtask")]
    public IActionResult CreateTask([FromBody] TrackerTask task)
    {
        _taskManager.AddTask(task);
        return Ok(_taskManager.GetAllTasks());
    }

    [HttpGet("addrandom")]
    public IActionResult AddRandom()
    {
        Random rnd = new Random();

        int taskId = rnd.Next();
        if (_taskManager.GetTaskById(taskId) == null)
        {
            var task = new TrackerTask();
            task.ID = taskId;
            _taskManager.AddTask(task);

            return Ok (_taskManager.GetAllTasks());
        }
        return Ok("Не удалось добавить задачу. Попробуйте еще раз.");
    }

    
}

