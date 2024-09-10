using CreandoApi.Models;
using Microsoft.EntityFrameworkCore;

namespace CreandoApi.Context
{
    public class AppDbContext : DbContext 
    {                           
        public AppDbContext(DbContextOptions<AppDbContext> options): base(options)
        //DbContextOptions: constructor que toma un argumento que se usa para configura el comportamiento del DbContext

        {
            
        }

        public DbSet<Empleadxs> Persons { get; set; }

        //dbset :clase de entity fram. que representa una coleccion de entidades en el contexto de las bases de datos
        //<Person>: es el tipo de entidad(clase que representa objetos o modelo de datos) que se almacenará en este conjunto ( el tipo de entidad es el tipo de modelo que estamos construyendo)
        //Persons : la entidad es de tipo person y el conjunto se llama persons
    }
}
