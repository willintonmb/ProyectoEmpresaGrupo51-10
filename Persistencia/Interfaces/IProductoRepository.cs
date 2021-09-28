using Dominio;
using System.Collections.Generic;
using Persistencia;

namespace Persistencia.Interfaces
{
    public interface IProductoRepository
    {
        IEnumerable<Producto> GetAllProductos();
        Producto AddProducto(Producto producto);
        Producto UpdateProducto(Producto producto);
        void DeleteProducto(int idProducto);
        Producto GetProducto(int idProducto);
    }
}