namespace EasyTrackerAPI;

using Microsoft.AspNetCore.Mvc;
using System;
using System.ComponentModel.DataAnnotations;
using System.Text.Json;
using System.IO; 
using System.Net.Http;
using System.Text; 
using System.Threading.Tasks;
using System.Collections.Generic;

[ApiController]
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
    public IActionResult GetByID(int taskId)
    {
        return Ok(_taskManager.GetTaskById(taskId));
    }

    [HttpPost("/api/tasks/add")]
    public IActionResult Add([FromBody] TrackerTask task)
    {
        _taskManager.AddTask(task);
        return Ok(_taskManager.GetAllTasks);
    }

    [HttpDelete("/api/tasks/delete/")]
    public IActionResult Delete(int taskId)
    {
        var ac = _taskManager.GetTaskById(taskId);
        if (ac != null){
            _taskManager.DeleteTask(ac);
            return Ok($"Удалён элемент под ID {taskId}");
        }
        
        return Ok("Элемент не найден");
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