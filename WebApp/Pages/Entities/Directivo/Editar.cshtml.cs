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
    public class EditarDirectivoModel : PageModel
    {
        private readonly IDirectivoRepository _directivoRepository;
        private readonly IEmpresaRepository _empresaRepository;

        [BindProperty]
        public Directivo Directivo {get; set;}
        public IEnumerable<Empresa> Empresas {get; set;}
        public EditarDirectivoModel(IDirectivoRepository directivoRepository, IEmpresaRepository empresaRepository)
        {
            _directivoRepository = directivoRepository;
            _empresaRepository = empresaRepository;
        }
        public IActionResult OnGet(int directivoId)
        {
            Empresas = _empresaRepository.GetAllEmpresa();

            if (directivoId != 0)
            {
                Directivo = _directivoRepository.GetDirectivo(directivoId);
            }
            else
            {
                Directivo = new Directivo();
            }
 
            if (Directivo == null)
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
            if (Directivo.Id > 0)
            {
                Directivo = _directivoRepository.UpdateDirectivo(Directivo);
            }
            else
            {
                _directivoRepository.AddDirectivo(Directivo);
            }
            return RedirectToPage("./Detalles");
        }
    }
}
