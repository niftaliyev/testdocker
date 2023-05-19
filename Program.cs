using Microsoft.EntityFrameworkCore;
using MySql.Data.MySqlClient;
using testdocker;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();


var connectionString = "server=testdocker_db_1;port=3306;database=test;user=root;password=1;";
builder.Services.AddDbContext<MyDbContext>(options => options.UseMySql(connectionString , new MySqlServerVersion(new Version(8, 0, 26))));



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
