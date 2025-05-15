using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SistemaGestionProductosMVC.Data.UnitOfWork;

namespace SistemaGestionProductosMVC_.Factory
{
    public interface IRepositoryFactory
    {
        IUnitOfWork CrearUnitOfWork(string tipo);
    }
}
