using System;
using System.ComponentModel.DataAnnotations;

namespace Dominio
{
    public class Persona
    {
        [Required]
        public int Id {get; set;}
        [Required]
        public string Nombre {get; set;}
        [Required]
        public string Documento {get; set;}
        
        public int Edad {get; set;}
        public DateTime FechaDeNacimiento {get; set;}

        public Persona(string nombre, string documento, DateTime fechaDeNacimiento)
        {
            Nombre = nombre;
            Documento = documento;
            Edad = CalcularEdad(fechaDeNacimiento);
            FechaDeNacimiento = fechaDeNacimiento;
        }

        public Persona()
        {
        }

        private int CalcularEdad(DateTime fechaDeNacimiento)
        {
            var edad = DateTime.Now.Year - fechaDeNacimiento.Year;
            if (fechaDeNacimiento > DateTime.Now.AddYears(-edad)) 
                edad -= 1;

            return edad ;
        }
    }
 
}
