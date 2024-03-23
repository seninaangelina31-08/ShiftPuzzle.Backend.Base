# API's methods description

# P.S Я надеюсь что это увидит только акшин https://www.youtube.com/watch?v=07FjVXysheI

## GetAll()
### Метод, отвечающий на GET - запрос по адресу 'tasks/getall'. TrackerTasks возвращает список записей в таблице.
```c#
    [HttpGet("getall")]
    public IActionResult GetAll()
    {
        return Ok(_taskManager.GetAllTasks());
    }
```
## GetTask(int taskId)
### Метод, отвечающий на GET - запрос по адресу 'tasks/gettask'. TrackerTasks возвращает запись по ключу ID из таблицы TrackerTasks. При худшем исходе выводит сообщение об отсутствии необходимой записи.
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
### Метод, отвечающий на DELETE - запрос по адресу 'tasks/deletetask'.Как удалить запись по ключу ID из таблицы TrackerTasks?В противном случае выводит сообщение об отсутствии необходимой записи.
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
### Метод, отвещающий на POST - запрос по адресу "createtask". Добавляет новую запись в таблицу TrackerTasks и возвращает обновленный список записей таблицы TrackerTasks.
```c#
    [HttpPost("createtask")]
    public IActionResult CreateTask([FromBody] TrackerTask task)
    {
        _taskManager.AddTask(task);
        return Ok(_taskManager.GetAllTasks());
    }
```

## AddRandom()
### етод, отвечающий на GET - запрос по адресу 'tasks/addrandom'. TrackerTasks добавляет новую запись в таблицу с случайным ID, если запись с таким ID еще не добавлена в таблицу. При худшем исходе выводит сообщение о неудачной попытке добавить запись.
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
```

## Complete(int id)
### Метод, отвечающий на PUT - запрос по адресу tasks/complete. Вызывает метод TaskManager - изменяющий статус задачи на 'Выполнена'. Поиск задачи ведется по ключу id, введённым пользователем.

```c#
    [HttpPut("api/tasks/complete/{id}")]
    public void Complete(int id)
    {
        _taskManager.CompleteTask(id);
    } 
```
