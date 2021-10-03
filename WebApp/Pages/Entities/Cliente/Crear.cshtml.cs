using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Persistencia.Interfaces;
using Dominio;

namespace MyApp.Namespace
{
    public class CrearClienteModel : PageModel
    {
        private readonly IClienteRepository _clienteRepository;
        public CrearClienteModel(IClienteRepository clienteRepository)
        {
            _clienteRepository = clienteRepository;
        }

        public IEnumerable<Cliente> Clientes {get; set;}
        public void OnGet(int idCliente)
        {
        }
    }
}
