using Homework;
using System.Data.SQLite; 

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllers();

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddSingleton<IProductRepository>(provider =>
{
    string connectPath = "Data Source=DataBase.db"; 
    IProductRepository productRepository = new SQLLiteProductRepository(connectPath);
    return productRepository;
});

var app = builder.Build();

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

 