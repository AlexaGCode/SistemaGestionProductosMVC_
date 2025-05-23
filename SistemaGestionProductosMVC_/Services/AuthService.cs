﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SistemaGestionProductosMVC.Entities;
using SistemaGestionProductosMVC.Utils;
using System.Data.SqlClient;
using System.Windows.Forms;


namespace SistemaGestionProductosMVC.Services
{
    public class AuthService
    {
        public Usuario Login(string usuario, string clave)
        {
            var conn = DbConnectionSingleton.Instancia;
            var cmd = new SqlCommand("sp_Login", conn);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Usuario", usuario);
            cmd.Parameters.AddWithValue("@Clave", clave);

            conn.Open();
            var reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                var user = new Usuario
                {
                    IdUsuario = (int)reader["IdUsuario"],
                    NombreUsuario = reader["Usuario"].ToString(),
                    Rol = reader["NombreRol"].ToString()
                };
                conn.Close();
                return user;
            }
            conn.Close();
            return null;
        }
    }
}