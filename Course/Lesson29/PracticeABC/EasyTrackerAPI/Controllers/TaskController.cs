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
[Route("/task")]
public class TaskController: ControllerBase {

    private readonly ITaskManager _taskManager;
    

    public TaskController(ITaskManager taskManager) {
        _taskManager = taskManager;
    }

    [HttpGet]
    [Route("/tasks/getall")]
    public IActionResult Showall() {
        return Ok(_taskManager.GetAllTasks());

    }

    [HttpGet]
    [Route("/tasks/gettask")]

    public IActionResult Get_task(int id) {
        var task = _taskManager.GetTaskById(id);
        if (task!=null) {
            return Ok(task);
        } else {
            return NotFound("Задача не найдена");
        }
    }

    [HttpPost]
    [Route("/tasks/createtask")]

    public IActionResult Add([FromBody] TrackerTask new_task) {
        _taskManager.AddTask(new_task);
        return Ok("Задание добавлено");
    }

    [HttpDelete]
    [Route("/tasks/deletetask")]

    public IActionResult Delete(int id) {
        TrackerTask task = _taskManager.GetTaskById(id);
        if (task != null) {
            _taskManager.DeleteTask(task);
            return Ok("Задание удалено");
        } else {
            return NotFound("Задание не найденно");
        }
    }
}