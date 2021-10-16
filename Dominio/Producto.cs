using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Dominio
{
    public class Producto
    {
        
        public int Id {get; set;}
        [Required]
        public string Nombre {get; set;}
        [Required]
        public double Valor {get; set;}
        
        public virtual ICollection<ProductoEmpresa> ProductoEmpresasLink { get; set; }


    }
}