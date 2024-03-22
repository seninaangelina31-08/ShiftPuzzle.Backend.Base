using Microsoft.EntityFrameworkCore;



var builder = WebApplication.CreateBuilder(args);

// Добавляем сервисы в контейнер.
builder.Services.AddControllers();

// Добавляем поддержку Swagger
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// Регистрируем ProductRepository
builder.Services.AddSingleton<ITaskManager>(provider =>
{
    // Создаем экземпляр DbContextOptionsBuilder для конфигурации базы данных SQLite
    var optionsBuilder = new DbContextOptionsBuilder<TaskContext>();
    optionsBuilder.UseSqlite("Data Source=TaskDataBase.db");

    var taskContext = new TaskContext(optionsBuilder.Options);
    taskContext.Database.EnsureCreated();
    
    // Создаем экземпляр репозитория и передаем контекст базы данных
    ITaskReposytory taskReposytory = new TaskReposytory(taskContext);
    ITaskManager taskManager = new TaskReposytory(taskReposytory);
    return taskManager;
});

var app = builder.Build();

// Настраиваем конвейер обработки HTTP-запросов.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();


app.UseAuthorization();

app.MapControllers();

app.Run();

 