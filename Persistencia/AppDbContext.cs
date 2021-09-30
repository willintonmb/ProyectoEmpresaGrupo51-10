using System;
using Microsoft.EntityFrameworkCore;
using Dominio;

namespace Persistencia
{
    public class AppDbContext : DbContext
    {
        public DbSet<Cliente> Clientes {get; set;}
        public DbSet<Directivo> Directivos {get; set;}
        public DbSet<Empleado> Empleados {get; set;}
        public DbSet<Persona> Personas {get; set;}
        public DbSet<Empresa> Empresas {get; set;}
        public DbSet<Producto> Productos {get; set;}
   
        public AppDbContext(DbContextOptions<AppDbContext>options):base(options)
        {
            
        }
        public AppDbContext()
        {
            
        }

    }
}
