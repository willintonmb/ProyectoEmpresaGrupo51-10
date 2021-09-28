using Dominio;
using System.Collections.Generic;

namespace Persistencia.Interfaces
{
    public interface IClienteRepository 
    {
        IEnumerable<Cliente> GetAllClientes();
        Cliente AddCliente(Cliente cliente);
        Cliente UpdateCliente(Cliente cliente);
        void DeleteCliente(int idCliente);
        Cliente GetCliente(int idCliente);
    }
}