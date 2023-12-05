using Microsoft.EntityFrameworkCore;
using Proyecto_Api_Usuarios_Accesos.Contexto;

var builder = WebApplication.CreateBuilder(args);



builder.Services.AddControllers();

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddDbContext<gestorBibliotecaDbContext>(
     o => o.UseNpgsql(builder.Configuration.GetConnectionString("conexion")));
var app = builder.Build();


if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
