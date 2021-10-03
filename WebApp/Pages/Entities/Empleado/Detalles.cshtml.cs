using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Persistencia.Interfaces;
using Persistencia.Repositorios;
using Dominio;

namespace MyApp.Namespace
{
    public class DetallesEmpleadoModel : PageModel
    {
        private readonly IEmpleadoRepository _empleadoRepository;
        public IEnumerable<Empleado> Empleados {get; set;}
        public DetallesEmpleadoModel(IEmpleadoRepository empleadoRepository)
        {
            _empleadoRepository = empleadoRepository;
        }
        public void OnGet()
        {
            Empleados = _empleadoRepository.GetAllEmpleado();
        }
    }
}
