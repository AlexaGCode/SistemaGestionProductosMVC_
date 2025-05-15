using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SistemaGestionProductosMVC.Data.UnitOfWork;

namespace SistemaGestionProductosMVC_.Factory
{
    public static class RepositoryFactory
    {
        public static IUnitOfWork CrearUnitOfWork(string tipo)
        {
            // En esta fase solo tienes ADO.NET, pero esto te prepara para EF u otros
            return tipo == "EF"
                ? throw new NotImplementedException("EF aún no está implementado.")
                : new UnitOfWork(); // por defecto ADO.NET
        }
    }
}
