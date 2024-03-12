namespace EasyTrackerAPI;

using System;
using System.IO; 
using System.Text; 
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

[ApiController]
public class TasksController : ControllerBase
{
    private readonly ITaskManager _taskManager;

    public TasksController(ITaskManager taskManager)
    {
        _taskManager = taskManager;
    }

    [HttpGet]
    [Route("/api/tasks/getall")]
    public IActionResult GetAllTasks()
    {
        return Ok(_taskManager.GetAllTasks());
    }

    [HttpGet]
    [Route("/api/tasks/get")]
    public IActionResult GetTaskById(int id)
    {
        if(_taskManager.GetTaskById(id) != null)
        {
            return Ok(_taskManager.GetTaskById(id));
        }
        return NotFound($"Задача с id={id} не найдена");
    }

    [HttpPost]
    [Route("/api/tasks/add")]
    public IActionResult AddTask([FromBody] TrackerTask task)
    {
        _taskManager.AddTask(task);
        return Ok(_taskManager.GetAllTasks());
    }

    [HttpDelete]
    [Route("/api/tasks/delete")]
    public IActionResult DeleteTask(int id)
    {
        if(_taskManager.GetTaskById(id) != null)
        {
            TrackerTask task = _taskManager.GetTaskById(id);
            _taskManager.DeleteTask(task);
            return Ok(_taskManager.GetAllTasks());
        }
        return NotFound($"Задача с id={id} не найдена");
    }
}