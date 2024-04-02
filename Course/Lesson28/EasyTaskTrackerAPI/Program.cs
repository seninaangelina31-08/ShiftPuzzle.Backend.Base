namespace EasyTaskTrackerAPI;
using Microsoft.EntityFrameworkCore;


var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddSingleton<ITaskManager>(provider =>
{


var optionBuilder = new DbContextOptionsBuilder<TaskContext>();
optionsBuilder.UseSqlite("Data Sourse=TaskDateBase.db");

var taskContext = new TaskContext(optionsBuilder.Options);
taskContext.DataBase.EnsureCreated();

ITaskRepository taskRepository = new ITaskRepository(taskContext);
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


