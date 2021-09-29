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
    public class DirectivoModel : PageModel
    {
        private readonly IDirectivoRepository directivoRepository;
        public IEnumerable<Directivo> Directivos {get; set;}
        public DirectivoModel(IDirectivoRepository directivoRepository)
        {
            this.directivoRepository = directivoRepository;
        }

        public void OnGet()
        {
            Directivos = directivoRepository.GetAllDirectivos();
        }
    }
}
