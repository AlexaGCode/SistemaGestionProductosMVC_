using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SistemaGestionProductosMVC.Entities;
using SistemaGestionProductosMVC.Utils;
using System.Data.SqlClient;
using System.Data;

namespace SistemaGestionProductosMVC.Data.Repositories
{
    public class ProductoRepository : IProductoRepository
    {
        private readonly SqlConnection _conexion;

        public ProductoRepository()
        {
            _conexion = DbConnectionSingleton.Instancia;
        }

        public List<Producto> ObtenerTodos()
        {
            List<Producto> lista = new List<Producto>();
            SqlCommand cmd = new SqlCommand("sp_ListarProductos", _conexion);
            cmd.CommandType = CommandType.StoredProcedure;

            _conexion.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                lista.Add(new Producto
                {
                    IdProducto = Convert.ToInt32(dr["IdProducto"]),
                    Nombre = dr["Nombre"].ToString(),
                    Precio = Convert.ToDecimal(dr["Precio"]),
                    Stock = Convert.ToInt32(dr["Stock"])
                });
            }
            _conexion.Close();
            return lista;
        }

        public void Insertar(Producto producto)
        {
            SqlCommand cmd = new SqlCommand("sp_InsertarProducto", _conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Nombre", producto.Nombre);
            cmd.Parameters.AddWithValue("@Precio", producto.Precio);
            cmd.Parameters.AddWithValue("@Stock", producto.Stock);

            _conexion.Open();
            cmd.ExecuteNonQuery();
            _conexion.Close();
        }

        public void Actualizar(Producto producto)
        {
            SqlCommand cmd = new SqlCommand("sp_ActualizarProducto", _conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@IdProducto", producto.IdProducto);
            cmd.Parameters.AddWithValue("@Nombre", producto.Nombre);
            cmd.Parameters.AddWithValue("@Precio", producto.Precio);
            cmd.Parameters.AddWithValue("@Stock", producto.Stock);

            _conexion.Open();
            cmd.ExecuteNonQuery();
            _conexion.Close();
        }

        public void Eliminar(int id)
        {
            SqlCommand cmd = new SqlCommand("sp_EliminarProducto", _conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@IdProducto", id);

            _conexion.Open();
            cmd.ExecuteNonQuery();
            _conexion.Close();
        }
    }
}