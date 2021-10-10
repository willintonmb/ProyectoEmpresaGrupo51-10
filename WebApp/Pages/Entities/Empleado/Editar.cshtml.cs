using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Dominio;
using Persistencia.Repositorios;
using Persistencia.Interfaces;


namespace MyApp.Namespace
{    
    public class EditarEmpleadoModel : PageModel
    { 
        private readonly IEmpleadoRepository _empleadoRepository;

        [BindProperty]
        public Empleado Empleado {get; set;}
        public EditarEmpleadoModel(IEmpleadoRepository empleadoRepository)
        {
            _empleadoRepository = empleadoRepository;
        }
        public IActionResult OnGet(int empleadoId)
        {
            Empleado = _empleadoRepository.GetEmpleado(empleadoId);

            if (Empleado == null)
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
            Empleado = _empleadoRepository.UpdateEmpleado(Empleado);
            return Page();

        }
    }
    
}

