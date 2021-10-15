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
    public class EliminarProductoModel : PageModel
    {
        private readonly IProductoRepository _productoRepository;
        public Producto Producto {get; set;}
        public EliminarProductoModel(IProductoRepository productoRepository)
        {
            _productoRepository = productoRepository;
        }
        public void OnGet(int productoId)
        {
            Producto = _productoRepository.GetProducto(productoId);
        }

        public void OnPost(int productoId)
        {
            _productoRepository.DeleteProducto(productoId);
        }
    }
}
