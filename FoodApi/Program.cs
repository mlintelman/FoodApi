using Microsoft.EntityFrameworkCore;
using FoodApi.Models;

var builder = WebApplication.CreateBuilder(args);


// Add CORS policy
//builder.Services.AddCors(options =>
//{
//    options.AddPolicy("AllowReactApp",
//        policy =>
//        {
//            policy.WithOrigins("http://localhost:5173")
//                  .AllowAnyHeader()
//                  .AllowAnyMethod();
//        });
//});
// Add CORS policy
builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowReactDevClient",
        policy =>
        {
            policy.WithOrigins("http://localhost:5173")
                  .AllowAnyMethod()
                  .AllowAnyHeader();
        });
});
// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
//builder.Services.AddDbContext<FoodContext>(opt =>
//opt.UseInMemoryDatabase("FoodList"));
//builder.Services.AddDbContext<FoodContext>(options =>
//options.UseSqlite("Data Source=foods.db"));
builder.Services.AddDbContext<NutritionDbContext>(options =>
options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Use CORS
app.UseCors("AllowReactDevClient");

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

// Add this line before `UseAuthorization`:
//app.UseCors("AllowReactApp");

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
