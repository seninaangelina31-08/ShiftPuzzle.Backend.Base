# API's methods description

## TaskController
### GetAll()
#### Метод, отвечающий на GET - запрос на эндпоинт 'tasks/getall'. Возвращает список всех записей в таблице TrackerTasks.
```c#
    [HttpGet("getall")]
    public IActionResult GetAll()
    {
        return Ok(_taskManager.GetAllTasks());
    }
```
### Get(int id)
#### Метод, отвечающий на GET - запрос на эндпоинт 'tasks/get/{id}'. Возвращает запись по ключу ID из таблицы TrackerTasks.
```c#
    [HttpGet("get/{id}")]

    public TrackerTask Get(int id)
    {
        return _taskManager.GetTaskById(id);
    }
```
### Delete(int id)
#### Метод, отвечающий на DELETE - запрос на эндпоинт 'tasks/delete/{id}'. Удаляет запись по ключу ID из таблицы TrackerTasks.
```c#
    [HttpDelete("delete/{id}")]
    public void Delete(int id)
    {  
        _taskManager.DeleteTask(id); 
    }
```
### Create([FromBody] TrackerTask task)
#### Метод, отвещающий на POST - запрос на эндпоинт 'add'. Добавляет новую запись в таблицу TrackerTasks.
```c#
    [HttpPost("add")]
    public void Create([FromBody] TrackerTask task)
    {
        _taskManager.AddTask(task);
    }
```

### AddRandom()
#### Метод, отвечающий на GET - запрос на эндпоинт 'tasks/addrandom/{id}'. Добавляет новую запись в таблицу TrackerTasks с случайным ID.

```c#
    [HttpGet("addrandom/{id}")]
    public void User(int id)
    {
         for(int x = 0 ; x < id;x++ )
         {
            int lastTaskID = 0 ;
            try
            {
                var tasks = _taskManager.GetAllTasks(); 
                lastTaskID = (int)tasks.Max(t => t.ID);   
            } 
            catch
            {
                lastTaskID = 0; 
            }
            
            var newTask = new TrackerTask();
            var randomName = "Task #" + (lastTaskID + x).ToString();
            newTask.ID = lastTaskID + x;       
            newTask.Name = randomName;  
            newTask.Description = "This is a random task";   
            newTask.DueDate = new DateTime();
            newTask.AssignedUser = new User {Name = "random", Email = "random@random.com", Password = "random", ID = 1};
            _taskManager.AddTask(newTask); 
         }
    }
```
---
## AccountController

### Create([FromBody] User account)
#### Метод, отвещающий на Post - запрос на эндпоинт 'api/account/register'. Создает новую запись пользователя в таблицу Users.
```c#
    [HttpPost("register")]
    public IActionResult Create([FromBody] User account)
    {
        var user = new IdentityUser { UserName = account.Name, Email = account.Email};
        var result = _userManager.CreateAsync(user, account.Password).Result;
        if (result.Succeeded)
        {
            _signInManager.SignInAsync(user, false).Wait();
            return Ok();
        }
        else
        {
            return BadRequest();
        }
    }
```

### Login([FromBody] User account)
#### Метод, отвещающий на POST - запрос на эндпоинт 'api/account/login'. Логинит пользователя в его аккаунт в случае правильно введенных имени и пароля.
```c#
    [HttpPost("login")]
    public IActionResult Login([FromBody] User account)
    {
        var result = _signInManager.PasswordSignInAsync(account.Name, account.Password,false, false).Result;
        if (result.Succeeded)
        {
            return Ok();
        }
        else
        {
            return BadRequest();
        }
    }
```

### Logout()
#### Метод, отвечающий на GET - запрос на эндпоинт 'api/account/logout. Метод отвечает за выход пользователя из аккаунта.
```c#
    [HttpGet("logout")]
    public IActionResult Logout()
    {
        _signInManager.SignOutAsync().Wait();
        return Ok();
    }
```

### GetAccounts()
#### Метод, отвечающий на GET - запрос на эндпоинт 'api/account/account'. Возвращает список всех зарегистрированных аккаунтов.

```c#
    [HttpGet("account")]
    public List<User> GetAccounts()
    {
        return _userManager.Users.Select(u => new User { Name = u.UserName, Email = u.Email }).ToList();
    }
```