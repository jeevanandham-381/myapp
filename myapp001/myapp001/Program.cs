using Microsoft.EntityFrameworkCore;
using myapp001.EF_core;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddDbContext<EF_Datacontext>(
    context => context.UseNpgsql(builder.Configuration.GetConnectionString("Ef_Postgres_db"))

    );

builder.Services.AddControllers();

var app = builder.Build();

// Configure the HTTP request pipeline.

app.UseAuthorization();

app.MapControllers();

app.Run();
