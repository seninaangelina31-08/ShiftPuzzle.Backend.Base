# Методы API таск-трекера
---
## GetAll

Метод, который отвечает за получение всех задач по запросу ["tasks/getall"]

```c#
[HttpGet("getall")]
public IActionResult GetAll()
{
    return Ok(_taskManager.GetAllTasks());
}
```
---
## GetTask

Метод, отвечающий за получение задачи по ID по запросу ["tasks/gettask/{id}"]

```c#
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
```
---
## DeleteTask

Метод, отвечающий за удаление задачи по ID по запросу ["tasks/deletetask/{id}"]
```c#
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
```
---
## CreateTask

Метод, отвечающий за создание новой задачи по запросу ["tasks/createtask"]

```c#
[HttpPost("createtask")]
public IActionResult CreateTask([FromBody] TrackerTask task)
{
    _taskManager.AddTask(task);
    return Ok(_taskManager.GetAllTasks());
}
```
---
## AddRandom

Метод, отвечающий за добавление задачи со случайным ID по запросу ["tasks/addrandom"]

```c#
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
    
    return Ok("Ошибка добавления задачи :(");
}
```
---
## Complete

Метод, отвечающий за изменение статуса задачи с заданным  ID по запросу ["tasks/complete/{id}"]

```c#
[HttpPut("api/tasks/complete/{id}")]
public void Complete(int id)
{
    _taskManager.CompleteTask(id);
}    
```