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
    public class ProductoModel : PageModel
    {
        private readonly IProductoRepository _productoRepository;
        public IEnumerable<Producto> Productos {get; set;}
        public ProductoModel(IProductoRepository productoRepository)
        {
            _productoRepository = productoRepository;
        }
        public void OnGet()
        {
            Productos = _productoRepository.GetAllProductos();
        }
    }
}
