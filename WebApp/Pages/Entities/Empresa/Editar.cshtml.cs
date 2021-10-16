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
    public class EditarEmpresaModel : PageModel
    {
        private readonly IEmpresaRepository _empresaRepository;

        [BindProperty]
        public Empresa Empresa {get; set;}
        public EditarEmpresaModel(IEmpresaRepository empresaRepository)
        {
            _empresaRepository = empresaRepository;
        }
        public IActionResult OnGet(int empresaId)
        {
            if (empresaId != 0)
            {
                Empresa = _empresaRepository.GetEmpresa(empresaId);
            }
            else
            {
                Empresa = new Empresa();
            }

             if (Empresa == null)
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
            if (Empresa.IdEmpresa > 0)
            {
                Empresa = _empresaRepository.UpdateEmpresa(Empresa);
            }
            else
            {
                _empresaRepository.AddEmpresa(Empresa);
            }
            return RedirectToPage("./Detalles");
        }
    }
}
