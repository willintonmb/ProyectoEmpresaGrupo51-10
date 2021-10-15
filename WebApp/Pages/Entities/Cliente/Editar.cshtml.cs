using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Dominio;
using Persistencia.Repositorios;
using Persistencia.Interfaces;

namespace MyApp.Namespace
{
    public class EditarClienteModel : PageModel
    {
        private readonly IClienteRepository _clienteRepository;

        [BindProperty]
        public Cliente Cliente {get; set;}
        public EditarClienteModel(IClienteRepository clienteRepository)
        {
            _clienteRepository = clienteRepository;
        }
        public IActionResult OnGet(int clienteId)
        {

            if (clienteId != 0)
            {
                Cliente = _clienteRepository.GetCliente(clienteId);
            }
            else
            {
                Cliente = new Cliente();
            }

            if (Cliente == null)
            {
                return RedirectToPage("./Not Found");
            }
            else
            {
                return Page();
            }
        }

        public IActionResult OnPost()
        {
            if (Cliente.Id > 0)
            {
                Cliente = _clienteRepository.UpdateCliente(Cliente);
            }
            else
            {
                _clienteRepository.AddCliente(Cliente);
            }
             return Page();
        }
    }
}
