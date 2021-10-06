using System;
using Microsoft.EntityFrameworkCore;
using VeterinariaEnCasa.App.Dominio;

namespace VeterinariaEnCasa.App.Persistencia
{
    public class AppContext : DbContext
    {
        public DbSet<Persona> personas { get; set; }
        public DbSet<Mascota> mascotas {get;set;}
        public DbSet<AuxiliarVeterinario> auxiliar {get;set;}
        public DbSet<Historia> historia {get;set;}
        public DbSet<Propietario> propietario {get;set;}
        public DbSet<SignoVital> signoVital {get;set;}
        public DbSet<SugerenciaCuidado> sugerencia {get;set;}

         
        

        
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {

                optionsBuilder
               .UseSqlServer("Data Source=(localdb)\\MSSQLLocalDB; initial catalog=VeterinariaEnCasa.Data");

            }
        }

        
    }
}