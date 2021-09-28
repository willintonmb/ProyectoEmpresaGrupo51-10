using System;
using Microsoft.EntityFrameworkCore;
using Dominio;

namespace Persistencia
{
    public class AppContext : DbContext
    {
        public DbSet<Cliente> Clientes {get; set;}
        public DbSet<Directivo> Directivos {get; set;}
        public DbSet<Empleado> Empleados {get; set;}
        public DbSet<Persona> Personas {get; set;}
        public DbSet<Empresa> Empresas {get; set;}
        public DbSet<Producto> Productos {get; set;}
    

        protected override void OnConfiguring(DbContextOptionsBuilder optionBuilder)
        {
            if (!optionBuilder.IsConfigured)
            {
                optionBuilder
                .UseSqlServer("Data Source = DESKTOP-KCG6U4C\\SQLEXPRESS; Initial Catalog = Proyecto Ciclo 3; Integrated Security=True");
            }
        }

    }
}
