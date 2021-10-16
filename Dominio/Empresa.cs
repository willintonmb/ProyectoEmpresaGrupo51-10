using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;


namespace Dominio
{
    public class Empresa
    {
        [Key]
        public int IdEmpresa {get; set;}
        [Required]
        public string Nombre {get; set;}
        [Required]
        public string Nit {get; set;}

        public virtual ICollection<Persona> ListaPersonas {get; set;}

        public virtual ICollection<ProductoEmpresa> ProductoEmpresasLink {get; set;}
    }
}