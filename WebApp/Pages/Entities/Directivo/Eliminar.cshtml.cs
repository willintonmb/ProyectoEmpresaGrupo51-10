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
    public class EliminarDirectivoModel : PageModel
    {
        private readonly IDirectivoRepository _directivoRepository;
        public Directivo Directivo {get; set;}
        public EliminarDirectivoModel(IDirectivoRepository directivoRepository)
        {
            _directivoRepository = directivoRepository;
        }
        public void OnGet(int directivoId)
        {
            Directivo = _directivoRepository.GetDirectivo(directivoId);
        }

        public IActionResult OnPost(int directivoId)
        {
            _directivoRepository.DeleteDirectivo(directivoId);
            return RedirectToPage("./Detalles");
        }
    }
}
