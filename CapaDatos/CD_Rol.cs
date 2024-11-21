using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace CapaDatos
{
    public class CD_Rol
    {
        public List<Rol> Listar()
        {
            List<Rol> lista = new List<Rol>();

            using (SqlConnection conexion = new SqlConnection(Conexion.cadena))
            {
                try
                {
                    StringBuilder query = new StringBuilder();
                    query.AppendLine("Select IdRol, Descripcion FROM ROL");
                   

                    SqlCommand cmd = new SqlCommand(query.ToString(), conexion);
                    cmd.CommandType = CommandType.Text;

                    conexion.Open();

                    using (SqlDataReader rd = cmd.ExecuteReader())
                    {
                        while (rd.Read())
                        {

                            lista.Add(new Rol()
                            {
                                IdRol = Convert.ToInt32(rd["IdRol"]),
                                Descripcion = rd["Descripcion"].ToString(),

                            });
                        }
                    }
                }
                catch (Exception ex)
                {
                    lista = new List<Rol>();
                }
            }

            return lista;
        }
    }
}
