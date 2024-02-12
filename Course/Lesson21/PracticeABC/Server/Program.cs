<<<<<<< HEAD
<<<<<<< HEAD
using PracticeABC;
using System.Data.SQLite; // Добавляем пространство имен для работы с SQLite

var builder = WebApplication.CreateBuilder(args);

// Добавляем сервисы в контейнер.
builder.Services.AddControllers();

// Добавляем поддержку Swagger
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// Регистрируем ProductRepository
builder.Services.AddSingleton<IProductRepository>(provider =>
{
    // Создаем базу данных и передаем путь к ней
    string connectPath = "Data Source=DataBase.db"; 
    IProductRepository productRepository = new SQLLiteUpperCaseRepository(connectPath);
    return productRepository; 
});

var app = builder.Build();

// Настраиваем конвейер обработки HTTP-запросов.
=======
=======
>>>>>>> 240f7224 (feat: added answer to task 21)
using PracticeABC; 

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

 
builder.Services.AddScoped<ProductRepository>(provider =>
{
    // Use the constructor with the appropriate parameters, e.g., the JSON file path
    return new   ProductRepository("DataBase.json");
});



var app = builder.Build();

// Configure the HTTP request pipeline.
<<<<<<< HEAD
>>>>>>> 78543e51 (матераилы 21-го урока)
=======
=======
using PracticeABC;
using System.Data.SQLite; // Добавляем пространство имен для работы с SQLite

var builder = WebApplication.CreateBuilder(args);

// Добавляем сервисы в контейнер.
builder.Services.AddControllers();

// Добавляем поддержку Swagger
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// Регистрируем ProductRepository
builder.Services.AddSingleton<SqlLiteProductRepository>(provider =>
{
    // Создаем базу данных и передаем путь к ней
    string connectPath = "Data Source=DataBase.db"; 
    return new SqlLiteProductRepository(connectPath); // Путь к файлу базы данных SQLite
});

var app = builder.Build();

// Настраиваем конвейер обработки HTTP-запросов.
>>>>>>> 08c5061f8c31354bd946ca5f449edd5e834a29da
>>>>>>> 240f7224 (feat: added answer to task 21)
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

<<<<<<< HEAD
app.Run();
=======
app.Run();
<<<<<<< HEAD
>>>>>>> 78543e51 (матераилы 21-го урока)
=======

 
>>>>>>> 08c5061f8c31354bd946ca5f449edd5e834a29da
>>>>>>> 240f7224 (feat: added answer to task 21)
