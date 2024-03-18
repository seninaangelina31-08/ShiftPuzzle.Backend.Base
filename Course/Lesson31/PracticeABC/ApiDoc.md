# API's methods description

## GetAll()
### Метод, отвечающий на GET - запрос по адресу 'tasks/getall'. Возвращает список всех записей в таблице TrackerTasks.
```c#
    [HttpGet("getall")]
    public IActionResult GetAll()
    {
        return Ok(_taskManager.GetAllTasks());
    }
```
## GetTask(int taskId)
### Метод, отвечающий на GET - запрос по адресу 'tasks/gettask'. Возвращает запись по ключу ID из таблицы TrackerTasks, если такое найдено. В противном случае выводит сообщение об отсутствии нужной записи.
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
## DeleteTask(int taskId)
### Метод, отвечающий на DELETE - запрос по адресу 'tasks/deletetask'. Удаляет запись по ключу ID из таблицы TrackerTasks, если такое найдено. В противном случае выводит сообщение об отсутствии нужной записи.
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
## CreateTask([FromBody] TrackerTask task)
### Метод, отвещающий на POST - запрос по адресу 'createtask'. Добавляет новую запись в таблицу TrackerTasks и возвращает обновленный список всех записей таблицы TrackerTasks.
```c#
    [HttpPost("createtask")]
    public IActionResult CreateTask([FromBody] TrackerTask task)
    {
        _taskManager.AddTask(task);
        return Ok(_taskManager.GetAllTasks());
    }
```

## AddRandom()
### Метод, отвечающий на GET - запрос по адресу 'tasks/addrandom'. Добавляет новую запись в таблицу TrackerTasks с случайным ID, если запись с таким ID еще не добавлена в таблицу. В противном случае выводит сообщение о неудачной попытке добавления записи.

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
        return Ok("Не удалось добавить задачу. Попробуйте еще раз.");
    }

##Complete(int id)
### Метод, отвечающий на PUT - запрос по адресу tasks/complete. Вызывает метод TaskManager - а, который изменяет статус задачи на 'Выполнена'. Поиск задачи ведется по ключу id, переданный пользователем.
```
