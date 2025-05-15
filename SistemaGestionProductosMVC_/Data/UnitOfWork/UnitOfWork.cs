using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SistemaGestionProductosMVC.Data.Repositories;

namespace SistemaGestionProductosMVC.Data.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork
    {
        public IProductoRepository ProductoRepository { get; }

        public UnitOfWork()
        {
            
            ProductoRepository = new ProductoRepository();
        }
    }
}