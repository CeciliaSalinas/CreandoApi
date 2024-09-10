using Microsoft.EntityFrameworkCore;
using CreandoApi.Models;
using CreandoApi.Context;
using Microsoft.Extensions.Options;

//aca creamos un objeto builder que se usará para construir nuestra aplicacion
var builder = WebApplication.CreateBuilder(args); 

// Add services to the container.
//creo una varable ara la cadena de conexion
var connectionString = builder.Configuration.GetConnectionString("ConexionSql");

//registrar servicio para la conexion
builder.Services.AddDbContext<AppDbContext>(Options => Options.UseSqlServer(connectionString));

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle


//documentacion con swagger
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

// se asigana las rutas de los controllers para que la aplicacion pueda dirigir la solicitud http a los controladores
app.MapControllers();

//inicia la aplicacion
app.Run();

