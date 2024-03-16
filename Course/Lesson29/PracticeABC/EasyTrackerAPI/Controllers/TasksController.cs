using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace EasyTrac.Controllers
{
    [Route("api/[controller]")]
    public class TasksController : Controller
    {
        private readonly ITaskService _taskService;

        public TasksController(ITaskService taskService)
        {
            _taskService = taskService;
        }

        [HttpGet("/api/tasks/getall")]
        public async Task<IActionResult> GetAllTasks()
        {
            var tasks = await _taskService.GetAllTasksAsync();
            return Ok(tasks);
        }

        [HttpGet("/api/tasks/get/{id}")]
        public async Task<IActionResult> GetTaskById(int id)
        {
            var task = await _taskService.GetTaskByIdAsync(id);

            if (task == null)
            {
                return NotFound();
            }

            return Ok(task);
        }

        [HttpPost("/api/tasks/add")]
        public async Task<IActionResult> AddTask([FromBody] TaskModel taskModel)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var task = await _taskService.AddTaskAsync(taskModel);
            return CreatedAtAction(nameof(GetTaskById), new { id = task.Id }, task);
        }

        [HttpGet("/api/tasks/delete/{id}")]
        public async Task<IActionResult> DeleteTaskById(int id)
        {
            await _taskService.DeleteTaskByIdAsync(id);
            return NoContent();
        }

        [HttpGet("/api/tasks/addrandom/{id}")]
        public async Task<IActionResult> AddRandomTasks(int id)
        {
            var random = new Random();
            var lastTaskID = id;
            const int numberOfRandomTasks = null;

            for (int x = 1; x <= numberOfRandomTasks; x++)
            {
                var newTask = new TaskModel();
                var randomName = "Task #" + (lastTaskID + x).ToString();
                newTask.Id = lastTaskID + x;
                newTask.Title = randomName;
                newTask.Description = "This is a random task";
                newTask.IsCompleted = false;

                await _taskService.AddTaskAsync(newTask);
            }

            return Ok("Random tasks added successfully");
        }
    }

    public interface ITaskService
    {
        Task<IEnumerable<TaskModel>> GetAllTasksAsync();
        Task<TaskModel> GetTaskByIdAsync(int id);
        Task<TaskModel> AddTaskAsync(TaskModel taskModel);
        Task DeleteTaskByIdAsync(int id);
    }

    public class TaskModel
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public bool IsCompleted { get; set; }
    }
}