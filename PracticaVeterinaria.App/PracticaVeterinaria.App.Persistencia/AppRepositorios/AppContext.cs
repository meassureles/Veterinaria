//Me permite hacer conexión a la base de datos
using Microsoft.EntityFrameworkCore;
using PracticaVeterinaria.App.Dominio;

namespace PracticaVeterinaria.App.Persistencia
{
    // Clase DBContext permite hacer el mapeo para poderlo registrar en la base de datos como archivo lógico.
    public class AppContext : DbContext
    {
        public DbSet<Propietario> Propietario {get; set;}
         public DbSet<Veterinario> Veterinario{get; set;}
          public DbSet<Mascota> Mascota {get; set;}
          public DbSet<Visita> Visita {get; set;}
          public DbSet<Persona> Persona {get; set;}
          public DbSet<HistoriaClinica> HistoriaClinica {get; set;}

        // TODO
        //Continuar con todas las clases

        protected override void OnConfiguring(DbContextOptionBuilder optionBuilder)
        {
            if(!optionBuilder.IsConfigured)
            {
                //Configuración la cadena de conexion y nombre de base de datos.
                optionBuilder.UseSqlServer("Data Source = (localdb)\\MSQLLocalDB; Initial Catalog = PracticaVeterinaria.Data");
            }
        }

        
    }
}
