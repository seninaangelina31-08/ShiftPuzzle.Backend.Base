
using System.Text.Json.Serialization;
using Microsoft.EntityFrameworkCore; 

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
 
builder.Services.AddSingleton<ITaskManager>(provider =>
{
    var taskOptionsBuilder = new DbContextOptionsBuilder<TaskTrackerContext>();
    taskOptionsBuilder.UseSqlite("Data Source=TaskDataBase.db"); 
    var taskContext = new TaskTrackerContext(taskOptionsBuilder.Options);

    var userOptionsBuilder = new DbContextOptionsBuilder<AccountContext>();
    userOptionsBuilder.UseSqlite("Data Source=TaskDataBase.db"); 
    var accountContext = new AccountContext(userOptionsBuilder.Options);
 
    ITaskRepository taskRepository = new TaskRepository(taskContext);
    IAccountRepository accountRepository = new AccountRepository(accountContext);
    ITaskManager taskManager = new TaskManager(taskRepository, accountRepository);
    Console.WriteLine(taskManager);
    return taskManager;
});


var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseAuthorization();

app.MapControllers();

app.Run();
