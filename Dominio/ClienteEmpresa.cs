using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;

namespace Dominio
{
    public class ClienteEmpresa
    {
        [ForeignKey ("Cliente")]
        public int IdCliente {get; set;}
        
        [ForeignKey ("Empresa")]
        public int IdEmpresa {get; set;}

        public virtual Cliente Cliente {get; set;}
        public virtual Empresa Empresa {get; set;}

        public virtual ICollection<Cliente> ListaClientes {get; set;}

    }
}