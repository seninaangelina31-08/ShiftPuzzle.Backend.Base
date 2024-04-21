

var builder = WebApplication.CreateBuilder(args);

// Добавляем необходимые сервисы в контейнер
builder.Services.AddControllers();
// Добавляем Swagger
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Настраиваем конвейер обработки HTTP-запросов
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.UseAuthorization();

// Добавляем контроллеры
app.MapControllers();

app.Run();

