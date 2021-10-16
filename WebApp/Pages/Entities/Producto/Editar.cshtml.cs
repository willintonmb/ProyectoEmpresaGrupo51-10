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
    public class EditarProductoModel : PageModel
    {
        private readonly IProductoRepository _productoRepository;
        private readonly IEmpresaRepository _empresaRepository;

        [BindProperty]
        public Producto Producto {get; set;}
        public IEnumerable<Empresa> Empresas {get; set;}
        public EditarProductoModel(IProductoRepository productoRepository, IEmpresaRepository empresaRepository)
        {
            _productoRepository = productoRepository;
            _empresaRepository = empresaRepository;
        }

        public IActionResult OnGet(int productoId)
        {
            Empresas = _empresaRepository.GetAllEmpresa();

            if (productoId != 0)
            {
                Producto = _productoRepository.GetProducto(productoId);
            }
            else
            {
                Producto = new Producto();
            }

             if (Producto == null)
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
            if (Producto.Id > 0)
            {
                Producto = _productoRepository.UpdateProducto(Producto);
            }
            else
            {
                _productoRepository.AddProducto(Producto);
            }
            return RedirectToPage("./Detalles");
        }
    }
}
