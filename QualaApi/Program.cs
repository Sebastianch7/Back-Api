using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using QualaApi.Data;
var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDbContext<QualaApiContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("QualaApiContext") ?? throw new InvalidOperationException("Connection string 'QualaApiContext' not found.")));

// Add services to the container.

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var proveedor = builder.Services.BuildServiceProvider();
var configuracion = proveedor.GetRequiredService<IConfiguration>();

builder.Services.AddCors(opciones =>
{
    var frontUrl = configuracion.GetValue<String>("front_url");
    opciones.AddDefaultPolicy(builder =>
    {
        builder.WithOrigins(frontUrl).AllowAnyOrigin().AllowAnyMethod().AllowAnyHeader();
    });
});


var app = builder.Build();



// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseCors();

app.UseAuthorization();

app.MapControllers();

app.Run();

