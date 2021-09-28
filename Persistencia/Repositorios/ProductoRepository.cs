using System.Collections.Generic;
using Dominio;
using Persistencia.Interfaces;
using Persistencia;
using System.Linq;

namespace Persistencia.Repositorios
{
    public class ProductoRepository : IProductoRepository
    {
        private readonly AppContext _appContext;

        public ProductoRepository(AppContext appContext)
        {
            _appContext = appContext;
        }

        IEnumerable<Producto> IProductoRepository.GetAllProductos()
        {
            return _appContext.Productos;
        }

        Producto IProductoRepository.AddProducto(Producto producto)
        {
            var productoAdicionado = _appContext.Productos.Add(producto);
            _appContext.SaveChanges();
            return productoAdicionado.Entity;
        }

        Producto IProductoRepository.UpdateProducto(Producto producto)
        {
            var productoEncontrado = _appContext.Productos.FirstOrDefault(x => x.Id == producto.Id);

            if (productoEncontrado != null)
            {
                productoEncontrado.Nombre = producto.Nombre;
                productoEncontrado.Valor = producto.Valor;
                _appContext.SaveChanges();
            }

            return productoEncontrado;
        }

        void IProductoRepository.DeleteProducto(int idProducto)
        {
            var productoEncontrado = _appContext.Productos.FirstOrDefault(x => x.Id == idProducto);
            
            if (productoEncontrado == null)
                return;

            _appContext.Productos.Remove(productoEncontrado);
            _appContext.SaveChanges();
        }

        Producto IProductoRepository.GetProducto(int idProducto)
        {
            return _appContext.Productos.FirstOrDefault(x => x.Id == idProducto);
        }
    }
}