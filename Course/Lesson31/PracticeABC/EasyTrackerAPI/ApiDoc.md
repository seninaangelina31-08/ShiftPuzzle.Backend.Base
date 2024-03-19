1. IEnumerable<TrackerTask> GetAll() [HttpGet("/api/tasks/getall")]
Возвращает все задачи
2. TrackerTask Get(int id) [HttpGet("/api/tasks/get/{id}")]
Получает задачу по ID 
3. void Create([FromBody] TrackerTask task)[HttpPost("/api/tasks/add")]
Создание задачи            
4. void Delete(int id) [HttpGet("/api/tasks/delete/{id}")]
Удаление задачи по ID        
5. void AddRandom(int id) [HttpGet("/api/tasks/addrandom/{id}")]
Cоздание случайной задачи в БД по ID
6. void CompleteTask(int id) [HttpGet("/api/tasks/complete/{id}")]
Изменение статуса задачи на завершено