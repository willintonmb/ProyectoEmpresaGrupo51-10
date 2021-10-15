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
    public class EliminarEmpresaModel : PageModel
    {
        private readonly IEmpresaRepository _empresaRepository;
        public Empresa Empresa {get; set;}
        public EliminarEmpresaModel(IEmpresaRepository empresaRepository)
        {
            _empresaRepository = empresaRepository;
        }
        public void OnGet(int empresaId)
        {
            Empresa = _empresaRepository.GetEmpresa(empresaId);
        }

        public void OnPost(int empresaId)
        {
            _empresaRepository.DeleteEmpresa(empresaId);
        }
    }
}
