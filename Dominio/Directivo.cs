using System.ComponentModel.DataAnnotations;

namespace Dominio
{
    public class Directivo : Empleado
    {
        [Required]
        public string Categoria {get; set;}
    }
}