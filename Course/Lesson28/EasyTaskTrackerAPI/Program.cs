using Microsoft.EntityFrameWorkCore;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddSingleton<ITaskManager>(provider =>
{
    var optionsBuilder = new DbContextOptionsBuilder<TaskContext>();
    optionsBuilder.useSqlite("Data Source=TaskDataBase.db");

    var taskContext = new TaskContext(optionsBuilder.Options);
    taskContext.Database.EnsureCreated();

    ITaskRepository taskRepository = new TaskRepository(taskContext);
    ITaskManager TaskManager = new TaskManager(taskRepository);

    return TaskManager;
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
