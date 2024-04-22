
using System.Text.Json.Serialization;
using Microsoft.EntityFrameworkCore; 

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddDbContext<AccountContext>(options =>
        options.UseSqlite("Data Source=AccountDataBase.db"));

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
 
builder.Services.AddSingleton<ITaskManager>(provider =>
{
    var taskOptionsBuilder = new DbContextOptionsBuilder<TaskTrackerContext>();
    taskOptionsBuilder.UseSqlite("Data Source=TaskDataBase.db"); 
    var taskContext = new TaskTrackerContext(taskOptionsBuilder.Options);
    taskContext.Database.EnsureCreated(); 
    ITaskRepository taskRepository = new TaskRepository(taskContext);
    ITaskManager taskManager = new TaskManager(taskRepository);

    return taskManager;
});

builder.Services.AddSingleton<IAccountManager>(provider =>
{
    var accountOptionsBuilder = new DbContextOptionsBuilder<AccountContext>();
    accountOptionsBuilder.UseSqlite("Data Source=AccountDataBase.db"); 
    var accountContext = new AccountContext(accountOptionsBuilder.Options);
    accountContext.Database.EnsureCreated();  
    IAccountRepository accountRepository = new AccountRepository(accountContext);
    IAccountManager accountManager = new AccountManager(accountRepository);

    return accountManager;
});

builder.Services.AddSwaggerGen(c =>
{
    c.SwaggerDoc("v1", new() { Title = "EasyTaskTracker API", Version = "v1" });
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
