using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaEntidad;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace CapaDatos
{
    public class D_Logging
    {
        string Conexion = ConfigurationManager.ConnectionStrings["ConexionPubs"].ConnectionString;
        public List<E_Logging> ValidaUsuario(string Usuario, string Contrasena)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(Conexion))
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand("spr_ValidaUsuario", connection);
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@Ususario", Usuario);
                    command.Parameters.AddWithValue("@Pass", Contrasena);

                    using (IDataReader dr = command.ExecuteReader())
                    {
                        List<E_Logging> lista = new List<E_Logging>();
                        E_Logging detalle;
                        while (dr.Read())
                        {
                            detalle = new E_Logging();
                            //detalle.NombreUsuario = dr["NombreUsuario"].ToString();
                            detalle.EsAdmin = Convert.ToBoolean(dr["EsAdministrador"]);

                            lista.Add(detalle);
                        }

                        return lista;
                    }
                }
            }
            catch (Exception ex)
            {
                return null;
            }
        }
    }
}
