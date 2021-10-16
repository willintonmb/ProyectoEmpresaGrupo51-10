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
        
        [ForeignKey("Empresa")]
        public int IdEmpresa { get; set; }

        public virtual Empresa Empresa { get; set; }


    }
}