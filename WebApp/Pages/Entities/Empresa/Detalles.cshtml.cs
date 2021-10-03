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
    public class DetallesEmpresaModel : PageModel
    {
        private readonly IEmpresaRepository _empresaRepository;
        public IEnumerable<Empresa> Empresas {get; set;}
        public DetallesEmpresaModel(IEmpresaRepository empresaRepository)
        {
            _empresaRepository = empresaRepository;
        }
        public void OnGet()
        {
            Empresas = _empresaRepository.GetAllEmpresa();
        }
    }
}
