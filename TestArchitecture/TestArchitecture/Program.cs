using Microsoft.EntityFrameworkCore;
using TestArchitecture.BL;
using TestArchitecture.Core.Repository;
using TestArchitecture.Core.Service;
using TestArchitecture.DA;
using TestArchitecture.DA.Repositories;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddScoped<IHomeworksRepository, HomeworksRepository>();
builder.Services.AddScoped<IHomeworksService, HomeworksService>();

var ConnectionString = builder.Configuration.GetConnectionString("HomeworkDatabase");
builder.Services.AddDbContext<TestArchitectureDbContext>(builder =>
{

    builder.UseSqlServer(ConnectionString);
});

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
