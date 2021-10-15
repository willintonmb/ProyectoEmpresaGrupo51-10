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
    public class EliminarEmpleadoModel : PageModel
    {
        private readonly IEmpleadoRepository _empleadoRepository;
        public Empleado Empleado {get; set;}
        public EliminarEmpleadoModel(IEmpleadoRepository empleadoRepository)
        {
            _empleadoRepository = empleadoRepository;
        }
        public void OnGet(int empleadoId)
        {
            Empleado = _empleadoRepository.GetEmpleado(empleadoId);
        }

        public IActionResult OnPost(int empleadoId)
        {
            _empleadoRepository.DeleteEmpleado(empleadoId);
            return RedirectToPage("./Detalles");
        }
    }
}
