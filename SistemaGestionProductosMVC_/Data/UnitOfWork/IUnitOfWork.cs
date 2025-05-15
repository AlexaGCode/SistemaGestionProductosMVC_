using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SistemaGestionProductosMVC.Data.Repositories;


namespace SistemaGestionProductosMVC.Data.UnitOfWork
{
    public interface IUnitOfWork
    {
        IProductoRepository ProductoRepository { get; }
        
    }
}