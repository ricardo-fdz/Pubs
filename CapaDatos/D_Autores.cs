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
    public class D_Autores
    {
        string Conexion = ConfigurationManager.ConnectionStrings["ConexionPubs"].ConnectionString;

        public List<E_Autores> VistaAutores()
        {
            List<E_Autores> ListaAutor = new List<E_Autores>();
            E_Autores vistaAutores;
            try
            {
                using (SqlConnection con = new SqlConnection(Conexion))
                {
                    con.Open();
                    SqlCommand command = new SqlCommand("SELECT * FROM vwAutores with(nolock)", con);

                    using (IDataReader dr = command.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            vistaAutores = new E_Autores();
                            vistaAutores.IdAutor = dr[0].ToString();
                            vistaAutores.Apellido = dr[1].ToString();
                            vistaAutores.Nombre = dr[2].ToString();
                            vistaAutores.Telefono = dr[3].ToString();
                            vistaAutores.Direccion = dr[4].ToString();
                            vistaAutores.Ciudad = dr[5].ToString();
                            vistaAutores.Estado = dr[6].ToString();
                            vistaAutores.CodigoPostal = dr[7].ToString();
                            vistaAutores.Contrato = Convert.ToBoolean(dr[8].ToString());

                            ListaAutor.Add(vistaAutores);
                        }
                    }
                    return ListaAutor;
                }
            }
            catch (Exception ex)
            {
                List<E_Autores> listaAutor = new List<E_Autores>();
                vistaAutores = new E_Autores();

                vistaAutores.MensajeError = ex.ToString();
                listaAutor.Add(vistaAutores);

                return listaAutor;
            }
        }

        public string InsertarAutor(string IdAutor, string Nombre, string Apellido, string Telefono, string Direccion, string Ciudad, string Estado, string CodPostal, bool Contrato)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(Conexion))
                {
                    con.Open();

                    SqlCommand command = new SqlCommand("spi_AltaAutor", con);
                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.AddWithValue("@Id", IdAutor);
                    command.Parameters.AddWithValue("@Nombre", Nombre);
                    command.Parameters.AddWithValue("@Apellido", Apellido);
                    command.Parameters.AddWithValue("@Telefono", Telefono);
                    command.Parameters.AddWithValue("@Direccion", Direccion);
                    command.Parameters.AddWithValue("@Ciudad", Ciudad);
                    command.Parameters.AddWithValue("@Estado", Estado);
                    command.Parameters.AddWithValue("@CodigoPostal", CodPostal);
                    command.Parameters.AddWithValue("@Contrato", Contrato);

                    command.ExecuteNonQuery();

                    return "1";
                }
            }
            catch (Exception ex)
            {
                return ex.ToString();
                throw;
            }
        }

        public string AuctualizarAutor(string IdAutor, string Nombre, string Apellido, string Telefono, string Direccion, string Ciudad, string Estado, string CodPostal, bool Contrato)
        {
            string error;
            try
            {
                using (SqlConnection con = new SqlConnection(Conexion))
                {
                    con.Open();

                    SqlCommand command = new SqlCommand("spu_ActualizarAutor", con);

                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.AddWithValue("@IdRegistro", IdAutor);
                    command.Parameters.AddWithValue("@Nombre", Nombre);
                    command.Parameters.AddWithValue("@apellido", Apellido);
                    command.Parameters.AddWithValue("@Telefono", Telefono);
                    command.Parameters.AddWithValue("@Direccion", Direccion);
                    command.Parameters.AddWithValue("@Ciudad", Ciudad);
                    command.Parameters.AddWithValue("@Estado", Estado);
                    command.Parameters.AddWithValue("@CodigoPostal", CodPostal);
                    command.Parameters.AddWithValue("@Contrato", Contrato);

                    error = command.ExecuteScalar().ToString(); 

                    return error;
                }
            }
            catch (Exception ex)
            {
                return ex.ToString();
                throw;
            }
        }
    }
}
