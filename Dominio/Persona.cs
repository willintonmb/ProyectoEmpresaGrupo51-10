using System;

namespace Dominio
{
    public class Persona
    {
        public int Id {get; set;}
        public string Nombre {get; set;}
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
            return DateTime.Now.Year - fechaDeNacimiento.Year;
        }
    }
 
}
