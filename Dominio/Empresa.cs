using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;


namespace Dominio
{
    public class Empresa
    {
        public int Id {get; set;}
        [Required]
        public string Nombre {get; set;}
        [Required]
        public string Nit {get; set;}

        public virtual ICollection<Empleado> ListaEmpleados {get; set;}

        public virtual ICollection<Producto> ListaProductos {get; set;}
    }
}