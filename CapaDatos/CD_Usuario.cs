using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using CapaEntidad; 

namespace CapaDatos
{
    public class CD_Usuario
    {
        public List<Usuario> Listar()
        {
            List<Usuario> lista = new List<Usuario>();

            using (SqlConnection conexion = new SqlConnection(Conexion.cadena))
            {
                try
                {
                    string query = "SELECT IdUsuario, Documento, NombreCompleto, Correo, Clave, Estado FROM usuario";
                    SqlCommand cmd = new SqlCommand(query, conexion);
                    cmd.CommandType = CommandType.Text;

                    conexion.Open();

                    using (SqlDataReader rd = cmd.ExecuteReader())  
                    {
                        while (rd.Read())
                        {
                           
                            lista.Add(new Usuario()
                            {
                                IdUsuario = Convert.ToInt32(rd["IdUsuario"]),
                                Documento = rd["Documento"].ToString(),
                                NombreCompleto = rd["NombreCompleto"].ToString(),
                                Correo = rd["Correo"].ToString(),
                                Clave = rd["Clave"].ToString(),
                                Estado = Convert.ToBoolean(rd["Estado"]),
                            });
                        }
                    }
                }
                catch (Exception ex)
                {
                    throw ex;   
                }
            }

            return lista; 
        }
    }
}