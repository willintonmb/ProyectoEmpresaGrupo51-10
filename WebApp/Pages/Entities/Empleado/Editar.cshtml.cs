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
            if (empleadoId != 0)
            {
                Empleado = _empleadoRepository.GetEmpleado(empleadoId);
            }
            else
            {
                Empleado = new Empleado();
            }

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
            if (Empleado.Id > 0)
            {
                Empleado = _empleadoRepository.UpdateEmpleado(Empleado);
            }
            else
            {
                _empleadoRepository.AddEmpleado(Empleado);
            }
            return RedirectToPage("./Detalles");
        }
    }
 }

