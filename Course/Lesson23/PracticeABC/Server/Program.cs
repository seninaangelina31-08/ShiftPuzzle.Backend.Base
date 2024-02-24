using PracticeABC;
using System.Data.SQLite; // Добавляем пространство имен для работы с SQLite
<<<<<<< HEAD
<<<<<<< HEAD
using Microsoft.EntityFrameworkCore;
=======
>>>>>>> bc515b02 (feat: lesson 22 completed)
=======
using Microsoft.EntityFrameworkCore;
>>>>>>> aa092068 (feat: homework for lesson 23 completed)

var builder = WebApplication.CreateBuilder(args);

// Добавляем сервисы в контейнер.
builder.Services.AddControllers();

// Добавляем поддержку Swagger
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// Регистрируем ProductRepository
builder.Services.AddSingleton<IProductRepository>(provider =>
{
<<<<<<< HEAD
<<<<<<< HEAD
=======
>>>>>>> aa092068 (feat: homework for lesson 23 completed)
    // Создаем экземпляр DbContextOptionsBuilder для конфигурации базы данных SQLite
    var optionsBuilder = new DbContextOptionsBuilder<ProductContext>();
    optionsBuilder.UseSqlite("Data Source=DataBase.db");

    // Создаем экземпляр ProductContext с передачей объекта optionsBuilder.Options
    var productContext = new ProductContext(optionsBuilder.Options);
    
    // Создаем экземпляр репозитория и передаем контекст базы данных
    IProductRepository productRepository = new EFCoreProductRepository(productContext);
    
    return productRepository;
<<<<<<< HEAD
=======
    // Создаем базу данных и передаем путь к ней
    string connectPath = "Data Source=DataBase.db"; 
    // Создаем экземпляр репозитория и передаем путь к базе данных SQLite
    IProductRepository productRepository = new SQLLiteUpperCaseRepository(connectPath);
    return productRepository; // Путь к файлу базы данных SQLite
>>>>>>> bc515b02 (feat: lesson 22 completed)
=======
>>>>>>> aa092068 (feat: homework for lesson 23 completed)
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

 