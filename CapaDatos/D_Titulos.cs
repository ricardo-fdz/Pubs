using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using CapaEntidad;

namespace CapaDatos
{
    public class D_Titulos
    {
        string Conexion = ConfigurationManager.ConnectionStrings["ConexionPubs"].ConnectionString;

        public List<E_Titulos> ObtenerTitulos()
        {
            List<E_Titulos> lista = new List<E_Titulos>();
            E_Titulos detalleTitulos = new E_Titulos();

            try
            {
                using (SqlConnection con = new SqlConnection(Conexion))
                {
                    con.Open();
                    SqlCommand sqlCommand = new SqlCommand("SELECT * FROM vwTitulos WITH(NOLOCK)", con);

                    using (IDataReader dr = sqlCommand.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            detalleTitulos = new E_Titulos();

                            detalleTitulos.IdTitulo = dr["Id Titulo"].ToString();
                            detalleTitulos.Titulo = dr[1].ToString();
                            detalleTitulos.TipoLibro = dr[2].ToString();
                            detalleTitulos.IdEditorial = dr[3].ToString();
                            object Precio = dr[4];
                            detalleTitulos.Precio = Precio != DBNull.Value ? Convert.ToDouble(Precio) : 0.00;
                            object Anticipo = dr[5];
                            detalleTitulos.Anticipo = Anticipo != DBNull.Value ? Convert.ToDouble(Anticipo) : 0.00;
                            object Regalias = dr[6];
                            detalleTitulos.Regalias = Regalias != DBNull.Value ? Convert.ToInt32(Regalias) : 0;
                            object Ventas = dr[7];
                            detalleTitulos.VentasAnio = Ventas != DBNull.Value ? Convert.ToInt32(Ventas) : 0;
                            detalleTitulos.Nota = dr[8].ToString();
                            detalleTitulos.FechaPublicacion = Convert.ToDateTime(dr[9].ToString());

                            lista.Add(detalleTitulos);
                        }


                    }
                    return lista;
                }
            }
            catch (Exception ex)
            {
                detalleTitulos = new E_Titulos();
                detalleTitulos.Error = ex.ToString();

                lista.Add(detalleTitulos);

                return lista;
                throw;
            }
        }

        public string AltaTitulo(string IdTitulo, string Titulo, string Tipo, string IdPub, decimal Precio,
                    decimal Anticipo, int Regalias, int YtdVentas, string Notas, DateTime FechaPublicacion)
        {
            int Resultado;
            try
            {
                using (SqlConnection connection= new SqlConnection(Conexion))
                {
                    connection.Open();

                    SqlCommand sqlCommand = new SqlCommand("spi_AltaTitulos", connection);

                    sqlCommand.CommandType = CommandType.StoredProcedure;

                    sqlCommand.Parameters.AddWithValue("@IdTitulo", IdTitulo);
                    sqlCommand.Parameters.AddWithValue("@Titulo", Titulo);
                    sqlCommand.Parameters.AddWithValue("@Tipo", Tipo);
                    sqlCommand.Parameters.AddWithValue("@IdPub", IdPub);
                    sqlCommand.Parameters.AddWithValue("@Precio", Precio);
                    sqlCommand.Parameters.AddWithValue("@Anticipo", Anticipo);
                    sqlCommand.Parameters.AddWithValue("@Regalias", Regalias);
                    sqlCommand.Parameters.AddWithValue("@YtdVentas", YtdVentas);
                    sqlCommand.Parameters.AddWithValue("@Notas", Notas);
                    sqlCommand.Parameters.AddWithValue("@FechaPublicacion", FechaPublicacion);

                  Resultado = (int)sqlCommand.ExecuteScalar();

                    if (Resultado == 1)
                    {
                        return "1";
                    }
                    else
                        return "0";
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
