using Microsoft.EntityFrameworkCore;
using TaskCoreHub.Api.DependencyInjection;
using TaskCoreHub.Infrastructure.Persistence.Context;
using TaskCoreHub.Application;
using TaskCoreHub.Infrastructure;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<TaskCoreHubDbContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("TaskCoreHubDb")));

builder.Services.AddSqsServices(builder.Configuration);

builder.Services
    .AddApplication()
    .AddInfrastructure();

// Configuração de CORS
builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowAll", policy =>
    {
        policy.AllowAnyOrigin()  // Permite qualquer origem
              .AllowAnyMethod()  // Permite qualquer método (GET, POST, etc)
              .AllowAnyHeader(); // Permite qualquer cabeçalho
    });
});

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

// Usando a política de CORS
app.UseCors("AllowAll");

app.MapControllers();

app.Run();
