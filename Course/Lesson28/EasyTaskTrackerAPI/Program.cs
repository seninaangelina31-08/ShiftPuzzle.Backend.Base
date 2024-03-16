using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);
builder. Services.AddControtlers();
builder. Services. AddEndpointsApiExplorer();
builder. Services. AddSwaggerGen();



builder. Services. AddSingleton<ITaskManager>(provider =>
{
    var optionsBuilder = new DbContextOptionsBuilder<TaskContext>();
    optionsBuilder.UseSqlite("Data Source=TaskDataBase. db")

    var taskContext = new TaskContext (optionsBuilder. Options) ;
    taskContext Database. EnsureCreated();

    TTaskRepository taskRepository = new TaskRepository(taskContext);
    TTaskManager taskManager = new TaskManager(taskRepository) ;

    return taskManager;
});


var app = builder.Build();
if (app. Environment. IsDevelopment ())
{
    app.UseSwagger();
    app. UseSwaggerUI();
}
app.UseHttpsRedirection();

app.UseAuthorization();

app.MapCont roUlers();

app.Run();
