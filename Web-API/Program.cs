using Microsoft.EntityFrameworkCore;
using Web_API.Data;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
builder.Services.AddDbContext<DataContext>(opt =>
{
    opt.UseNpgsql(builder.Configuration.GetConnectionString("DefaultConnection"));
});

builder.Services.AddCors();     

var app = builder.Build();

// Configure the HTTP request pipeline.

app.UseCors(builder => builder.AllowAnyHeader().AllowAnyMethod().WithOrigins("http://localhost:4200"));  

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();  