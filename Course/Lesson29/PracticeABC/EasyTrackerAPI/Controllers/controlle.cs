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
[Route("tasks/")]
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
       var task = _taskManager.GetTaskById(taskId);
        if (task != null)
        {
            _taskManager.DeleteTask(task);
            return Ok(_taskManager.GetAllTasks());
        }
        else
        {
            return NotFound("Задачи не найдены");
        }
    }
    [HttpGet("/api/tasks/addrandom/{id}")]
    public void AddRandom(int id)
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
            newTask.Description = "генерация рандомных записей ";   
            _taskManager.AddTask(newTask); 
         }



}