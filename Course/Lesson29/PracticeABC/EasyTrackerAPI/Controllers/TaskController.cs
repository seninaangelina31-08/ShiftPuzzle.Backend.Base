namespace EasyTrackerAPI;

using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;


[ApiController()]
public class StoreController : ControllerBase
{
    private readonly ITaskManager _taskManager;

    public StoreController(ITaskManager taskManager)
    {
        _taskManager = taskManager;
    }

    [HttpGet]
    [Route("/api/tasks/getall")]
    public IActionResult GetAll()
    {
        return Ok(_taskManager.GetAllTasks());
    }

    [HttpGet("/api/tasks/get/{id}")]
    public IActionResult GetByID(int id)
    {
        var task = _taskManager.GetTaskById(id);
        if (task != null)
        {
            return Ok(task);
        }
        return NotFound();
    }

    [HttpPost("/api/tasks/add")]
    public IActionResult Add([FromBody] TrackerTask task)
    {
        _taskManager.AddTask(task);
        return Ok();
    }

    [HttpGet("/api/tasks/delete/{id}")]
    public IActionResult Delete(int id)
    {
        var task = _taskManager.GetTaskById(id);
        if (task != null)
        {
            _taskManager.DeleteTask(task);
            return Ok();
        }
        return NotFound();
    }
}