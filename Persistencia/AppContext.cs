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
   
        public AppContext(DbContextOptions<AppContext>options):base(options)
        {
            
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        { 
            //Db local
            //optionsBuilder.UseSqlServer("Data Source=localhost\\SQLEXPRESS;Initial Catalog = Proyecto Ciclo 3;Integrated Security = True; MultipleActiveResultSets=true");
            //Db Azure
            optionsBuilder.UseSqlServer("Server=tcp:fenixdevelopment.database.windows.net,1433;Initial Catalog=Proyecto Ciclo 3;Persist Security Info=False;User ID=WillintonMB;Password=C1a9m8b8*;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30");
        }
        public AppContext()
        {
            
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ProductoEmpresa>().HasKey(
                pe => new {pe.IdProducto, pe.IdEmpresa}
            );
        }

    }
}
