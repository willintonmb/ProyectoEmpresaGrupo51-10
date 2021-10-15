using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Persistencia.Repositorios;
using Persistencia.Interfaces;
using Dominio;

namespace MyApp.Namespace
{
    public class EliminarClienteModel : PageModel
    {
        private readonly IClienteRepository _clienteRepository;
        public Cliente Cliente {get; set;}
        public EliminarClienteModel(IClienteRepository clienteRepository)
        {
            _clienteRepository = clienteRepository;
        }
        public void OnGet(int clienteId)
        {
            Cliente = _clienteRepository.GetCliente(clienteId);
        }

        public void OnPost(int clienteId)
        {
            _clienteRepository.DeleteCliente(clienteId);
        }
    }
}
