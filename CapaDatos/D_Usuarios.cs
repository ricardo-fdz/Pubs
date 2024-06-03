using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class D_Usuarios
    {
        private string Conexion = ConfigurationManager.ConnectionStrings["ConexionPubs"].ConnectionString;
        List<E_Usuarios> Usuarios = new List<E_Usuarios>();
        public List<E_Usuarios> VistaUsuarios()
        {
            try
            {
                using (SqlConnection conexion = new SqlConnection(Conexion))
                { 
                    conexion.Open();
                    SqlCommand command = new SqlCommand("SELECT * FROM vwUsuarios with(nolock)", conexion);

                    using (IDataReader dr = command.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            Usuarios.Add(new E_Usuarios() {
                                IdUsuario = Convert.ToInt32(dr[0]),
                                NombreUsuario = dr[1].ToString(),
                                ContraseñaUsuario = dr[2].ToString(),
                                EsAdministrador = Convert.ToBoolean(dr[3])
                            });
                        }
                        return Usuarios;
                    }
                }
             }
            catch (Exception ex)
            {
                Usuarios.Add(new E_Usuarios()
                {
                    MensajeError= ex.ToString()
                });
                return Usuarios;
            }
        }
    }
}
