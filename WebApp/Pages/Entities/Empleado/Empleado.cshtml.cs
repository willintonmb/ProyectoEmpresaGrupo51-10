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
    public class EmpleadoModel : PageModel
    {
        private readonly IEmpleadoRepository empleadoRepository;
        public IEnumerable<Empleado> Empleados {get; set;}
        public EmpleadoModel(IEmpleadoRepository empleadoRepository)
        {
            this.empleadoRepository = empleadoRepository;
        }
        public void OnGet()
        {
            Empleados = empleadoRepository.GetAllEmpleado();
        }
    }
}
