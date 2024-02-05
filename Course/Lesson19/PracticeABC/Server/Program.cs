namespace PracticeA;
var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

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

builder.Services.AddScoped<DBModelRepository>(provider =>
{
    return new DBModelRepository("DBModle.cs");
});

builder.Services.AddScoped<ProductRepository>(provider =>
{
    return new ProductRepository("Product.cs");
});

builder.Services.AddScoped<UserCredentialsRepository>(provider =>
{
    return new UserCredentialsRepository("UserCredentials.cs");
});