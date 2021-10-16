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

        [BindProperty]
        public Directivo Directivo {get; set;}
        public EditarDirectivoModel(IDirectivoRepository directivoRepository)
        {
            _directivoRepository = directivoRepository;
        }
        public IActionResult OnGet(int directivoId)
        {

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
