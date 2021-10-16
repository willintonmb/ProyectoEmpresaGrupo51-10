using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Dominio
{
    public class ProductoEmpresa
    {
        [ForeignKey ("Producto")]
        public int IdProducto {get; set;}

        public Producto Producto {get; set;}

        [ForeignKey ("Empresa")]
        public int IdEmpresa {get; set;}
        public Empresa Empresa {get; set;}
    }
}