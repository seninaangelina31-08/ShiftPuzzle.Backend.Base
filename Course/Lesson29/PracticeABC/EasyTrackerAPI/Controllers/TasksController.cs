using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("api/tasks")]
public class TasksController : ControllerBase
{
    private readonly ITaskManager _taskManager;
    private readonly List<string> randomNames = new() {"go for a walk", "make front-end", "wah the floor", "make salad"};

    public TasksController(ITaskManager taskManager)
    {
        _taskManager = taskManager;
    }

    [Route("getall")]
    [HttpGet]
    public IActionResult GetAll()
    {
        return Ok(_taskManager.GetAllTasks());
    }

    [Route("get/{id}")]
    [HttpGet]
    public IActionResult GetById(int id)
    {
        return Ok(_taskManager.GetTaskById(id));
    }

    [Route("add")]
    [HttpPost]
    public IActionResult Add([FromBody] TrackerTask task)
    {
        _taskManager.AddTask(task);
        return Ok("Заказ успешно добавлен");
    }

    [Route("delete/{id}")]
    [HttpDelete]
    public IActionResult DeleteById(int id)
    {
        var task = _taskManager.GetAllTasks().FirstOrDefault(p => p.ID == id);
        if (task != null)
        {
            _taskManager.DeleteTask(task);
            return Ok("Заказ успешно удалён!");
        }

        return Ok("Заказ не получилось найти в базе данных...");
    }

    [Route("addrandom/{id}")]
    [HttpPost]
    public IActionResult AddRandomTask()
    {
        Random random = new();
        string randomName = randomNames[random.Next(randomNames.Count)];
        string randomDescription = "bla-bla-bla";
        var randomTask = new TrackerTask(randomName, randomDescription);
        _taskManager.AddTask(randomTask);
        return Ok("Случайный заказ добавлен в БД!");

    }



}