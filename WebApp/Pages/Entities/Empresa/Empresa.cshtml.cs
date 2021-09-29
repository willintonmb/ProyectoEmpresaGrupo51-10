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
    public class EmpresaModel : PageModel
    {
        private readonly IEmpresaRepository empresaRepository;
        public IEnumerable<Empresa> Empresas {get; set;}
        public EmpresaModel(IEmpresaRepository empresaRepository)
        {
            this.empresaRepository = empresaRepository;
        }
        public void OnGet()
        {
            Empresas = empresaRepository.GetAllEmpresa();
        }
    }
}
