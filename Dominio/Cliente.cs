using System.ComponentModel.DataAnnotations;

namespace Dominio
{
    public class Cliente:Persona
    {
        [Required]
        public string Telefono {get; set;}
        public int IdEmpresa { get; set; }
    }
}