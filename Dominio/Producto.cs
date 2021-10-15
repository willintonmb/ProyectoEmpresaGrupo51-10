using System.ComponentModel.DataAnnotations;

namespace Dominio
{
    public class Producto
    {
        public int Id {get; set;}
        [Required]
        public string Nombre {get; set;}
        [Required]
        public double Valor {get; set;}
        public int IdEmpresa { get; set; }
    }
}