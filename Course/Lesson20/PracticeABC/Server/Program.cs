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
<<<<<<< HEAD
<<<<<<< HEAD
    return new ProductRepository("Data Source=DataBase.db");
});


=======
    return new   ProductRepository("DataBase.json");
});



>>>>>>> ec9a1010 (Материалы 20-го урока)
=======
    return new ProductRepository("DataBase.db");
});


>>>>>>> 9a04c3d8 (refactor: try to run APIs)
var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();