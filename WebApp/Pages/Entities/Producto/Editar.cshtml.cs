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

        [BindProperty]
        public Producto Producto {get; set;}
        public EditarProductoModel(IProductoRepository productoRepository)
        {
            _productoRepository = productoRepository;
        }
        public IActionResult OnGet(int productoId)
        {
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
