//Jonas da Rosa Oliveira
//https://www.linkedin.com/in/jonas-da-rosa-oliveira

using Scalar.AspNetCore;
using IMemoryCacheCore10.Domain.Interfaces;
using IMemoryCacheCore10.Infrastructure.Repositories;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();

builder.Services.AddOpenApi();
builder.Services.AddEndpointsApiExplorer(); 

builder.Services.AddMemoryCache();
builder.Services.AddHttpClient("FreeToGame", c => {
    c.BaseAddress = new Uri("https://www.freetogame.com/api/");
});

builder.Services.AddScoped<IGameRepository, GameRepository>();
builder.Services.AddScoped<IGameService, GameService>();

var app = builder.Build();


if (app.Environment.IsDevelopment())
{
    app.MapOpenApi(); 
    app.MapScalarApiReference(options => 
    {
        options.WithOpenApiRoutePattern("/openapi/v1.json");
    });
}

if (!app.Environment.IsDevelopment())
{
    app.UseHttpsRedirection();
}

app.MapControllers();

app.Run();