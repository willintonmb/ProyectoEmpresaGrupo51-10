using System.ComponentModel.DataAnnotations;

namespace Dominio
{
    public class Directivo : Empleado
    {
        
        public string Categoria {get; set;}
    }
}