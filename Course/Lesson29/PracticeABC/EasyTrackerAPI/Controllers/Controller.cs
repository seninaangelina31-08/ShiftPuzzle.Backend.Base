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
            return NotFound("Продукт не найден");
        }

    }

    [HttpGet("addrandom/id")]
    public IActionResult AddRandomTask(int id)
    {
        var newTask = new TrackerTask();
        var randomName = "Task #" + (lastTaskID + id).ToString();
        newTask.ID = lastTaskID + id;       
        newTask.Name = randomName;  
        newTask.Description = "This is a random task";   
        _taskManager.AddTask(newTask); 

        return Ok("Случайная задача добавлена в БД");
    }


    [HttpPost("add")]
    public IActionResult CreateTask([FromBody] TrackerTask task)
    {
        _taskManager.AddTask(task);
        return Ok(_taskManager.GetAllTasks());
    }

    [HttpDelete("delete/id")]
    public IActionResult DeleteTask(int id)
    {
        var task = _taskManager.GetTaskById(id);
        if (task != null)
        {
            _taskManager.DeleteTask(task);
            return Ok("Продукт удалён");
        }
        else
        {
            return NotFound("Продукт не найден");
        }
    }
}