using PracticeABC;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();


builder.Services.AddSingleton<ITaskManager>(provider => 
{
    var optionsBuilder = new DbContextOptionsBuilder<TaskContext>();
    optionsBuilder.UseSqlite("Data Source=TaskDataBase.db");

    var taskContext = new TaskContext(optionsBuilder.Options);
    taskContext.Database.EnsureCreated();

    ITaskRepository taskRepository = new TaskRepository(taskContext);
    ITaskManager taskManager = new TaskManager(taskRepository);
    
    return taskManager;
});


var app = builder.Build();


if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();
app.Run();