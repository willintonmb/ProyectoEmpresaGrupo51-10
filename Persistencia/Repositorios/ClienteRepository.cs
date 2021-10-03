using System;
using System.Collections.Generic;
using Dominio;
using Persistencia;
using Persistencia.Interfaces;
using System.Linq;

namespace Persistencia.Repositorios
{
    public class ClienteRepository : IClienteRepository
    {
        private readonly AppContext _appContext;

        public ClienteRepository(AppContext appContext)
        {
            _appContext = appContext;
        }

        Cliente IClienteRepository.AddCliente(Cliente cliente)
        {
            var clienteAdicionado = _appContext.Clientes.Add(cliente);
            _appContext.SaveChanges();
            return clienteAdicionado.Entity;
        }

        void IClienteRepository.DeleteCliente(int idCliente)
        {
            var clienteEncontrado = _appContext.Clientes.FirstOrDefault(x => x.Id == idCliente);

            if (clienteEncontrado == null)
                return;

            _appContext.Clientes.Remove(clienteEncontrado);
            _appContext.SaveChanges();
        }

        IEnumerable<Cliente> IClienteRepository.GetAllClientes()
        {
            return _appContext.Clientes;
        }

        Cliente IClienteRepository.GetCliente(int idCliente)
        {
            return _appContext.Clientes.FirstOrDefault(x => x.Id == idCliente);
        }

        Cliente IClienteRepository.UpdateCliente(Cliente cliente)
        {
            var clienteEncontrado = _appContext.Clientes.FirstOrDefault(x => x.Id == cliente.Id);

            if (clienteEncontrado != null)
            {
                clienteEncontrado.Nombre = cliente.Nombre;
                clienteEncontrado.Documento = cliente.Documento;
                clienteEncontrado.FechaDeNacimiento = cliente.FechaDeNacimiento;
                clienteEncontrado.Telefono = cliente.Telefono;
                _appContext.SaveChanges();
            }

            return clienteEncontrado;
        }
    }
}