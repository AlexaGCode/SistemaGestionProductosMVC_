using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SistemaGestionProductosMVC.Entities;

namespace SistemaGestionProductosMVC.Data.Repositories
{
    public interface IProductoRepository
    {
        List<Producto> ObtenerTodos();
        void Insertar(Producto producto);
        void Actualizar(Producto producto);
        void Eliminar(int id);
    }
}