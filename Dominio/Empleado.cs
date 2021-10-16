using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Dominio
{
    public class Empleado : Persona
    {
        [Required]
        public double Salario { get; set; }

        [ForeignKey ("Empresa")]
        public int IdEmpresa { get; set; }

        public virtual Empresa Empresa { get; set; }

    }
}