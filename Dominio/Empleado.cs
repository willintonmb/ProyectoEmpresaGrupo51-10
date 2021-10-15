using System;
using System.ComponentModel.DataAnnotations;

namespace Dominio
{
    public class Empleado : Persona
    {
        [Required]
        public double Salario { get; set; }
        public int IdEmpresa { get; set; }

    }
}