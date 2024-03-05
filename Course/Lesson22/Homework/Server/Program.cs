using Homework;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Sqlite;

var builder = WebApplication.CreateBuilder(args);

// Добавляем сервисы в контейнер.
builder.Services.AddControllers();

// Добавляем поддержку Swagger
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<ToadContext>(options =>
        options.UseSqlite("Data Source=DataBase.db"));
// Регистрируем ToadRepository
builder.Services.AddSingleton<IToadRepository>(provider =>
{
    // Создаем экземпляр DbContextOptionsBuilder для конфигурации базы данных SQLite
    var optionsBuilder = new DbContextOptionsBuilder<ToadContext>();
    optionsBuilder.UseSqlite("Data Source=DataBase.db");

    // Создаем экземпляр ToadContext с передачей объекта optionsBuilder.Options
    var toadContext = new ToadContext(optionsBuilder.Options);
    
    // Создаем экземпляр репозитория и передаем контекст базы данных
    IToadRepository toadRepository = new EFCoreToadRepository(toadContext);
    
    return toadRepository;
});

var app = builder.Build();

// Настраиваем конвейер обработки HTTP-запросов.
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
