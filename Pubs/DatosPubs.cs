using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using Pubs.Fachada;

namespace Pubs
{
    class DatosPubs
    {

        public string Conexion()
        {
            string conectionString = @"Data Source=DESKTOP-7789AN9\SQLEXPRESS;Initial Catalog=pubs;Integrated Security=True;";
            return conectionString;
        }

        public List<DetalleUsuario> ValidaUsuario(string Usuario, string Contrasena, bool ValidaAdmin)
        {
            try
            {


                string CadenaConexion;
                bool EsAdmin = false;
                int UsuarioValido;
                CadenaConexion = Conexion();

                using (SqlConnection connection = new SqlConnection(CadenaConexion))
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand("spr_ValidaUsuario", connection);
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@Ususario", Usuario);
                    command.Parameters.AddWithValue("@Pass", Contrasena);
                    command.Parameters.AddWithValue("@count", ValidaAdmin);
                    using (IDataReader dr = command.ExecuteReader())
                    {
                        List<DetalleUsuario> lista = new List<DetalleUsuario>();
                        DetalleUsuario detalle;
                        while (dr.Read())
                        {
                            detalle = new DetalleUsuario();
                            detalle.NombreUsuario = dr["NombreUsuario"].ToString();
                            detalle.EsAdmin = Convert.ToBoolean(dr["EsAdministrador"]);

                            lista.Add(detalle);
                        }

                        return lista;
                    }
                    //if (ValidaAdmin)
                    //{
                    //    return UsuarioValido = (int)command.ExecuteScalar();
                    //}
                    //else
                    //{
                    //    EsAdmin = Convert.ToBoolean(command.ExecuteScalar());
                    //    if (EsAdmin)
                    //    {
                    //        return 1;
                    //    }
                    //    else
                    //        return 0;
                    //}

                }
            }
            catch (Exception ex)
            {
                return null;
            }
        }
        // VISTAS

        #region Vista Autores
        public DataTable VistaAutores()
        {
            string conectionString;
            string Query = "SELECT * FROM vwAutores with(nolock)";

            conectionString = Conexion();

            using (SqlConnection connection = new SqlConnection(conectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(Query, connection);
                SqlDataAdapter dataAdapter = new SqlDataAdapter(command);

                DataTable dataTable = new DataTable();

                try
                {
                    dataAdapter.Fill(dataTable);

                    connection.Close();
                    return dataTable;
                }
                catch (Exception ex)
                {
                    connection.Close();
                    return null;
                }
            }
        }
        #endregion

        #region Vista Autores2
        public DataTable VistaAutores2(string idAutor)
        {
            string conectionString;
            string Query = "SELECT * FROM vwAutores with(nolock) WHERE [ID Autor] = @IdAutor";

            conectionString = Conexion();

            using (SqlConnection connection = new SqlConnection(conectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(Query, connection);
                command.Parameters.AddWithValue("@IdAutor", idAutor);
                SqlDataAdapter dataAdapter = new SqlDataAdapter(command);

                DataTable dataTable = new DataTable();

                try
                {
                    dataAdapter.Fill(dataTable);

                    connection.Close();
                    return dataTable;
                }
                catch (Exception ex)
                {
                    connection.Close();
                    return null;
                }
            }
        }
        #endregion

        #region Vista Titulos
        public DataTable VistaTitulos()
        {
            string conectionString;
            string Query = "SELECT * FROM vwTitulos with(nolock)";

            conectionString = Conexion();

            using (SqlConnection connection = new SqlConnection(conectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(Query, connection);
                SqlDataAdapter dataAdapter = new SqlDataAdapter(command);

                DataTable dataTable = new DataTable();

                try
                {
                    dataAdapter.Fill(dataTable);

                    connection.Close();
                    return dataTable;
                }
                catch (Exception ex)
                {
                    connection.Close();
                    return null;
                }
            }
        }
        #endregion

        #region Vista Titulos 2
        public DataTable VistaTitulos2(string idTitulo)
        {
            string conectionString;
            string Query = "SELECT * FROM vwTitulos with(nolock) WHERE [ID Titulo] = @IdTitulo";

            conectionString = Conexion();

            using (SqlConnection connection = new SqlConnection(conectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(Query, connection);
                command.Parameters.AddWithValue("@IdTitulo", idTitulo);
                SqlDataAdapter dataAdapter = new SqlDataAdapter(command);

                DataTable dataTable = new DataTable();

                try
                {
                    dataAdapter.Fill(dataTable);

                    connection.Close();
                    return dataTable;
                }
                catch (Exception ex)
                {
                    connection.Close();
                    return null;
                }
            }
        }
        #endregion

        #region Vista Stock
        public DataTable VistaStock()
        {
            string conectionString;
            string Query = "SELECT * FROM vwStock with(nolock)";

            conectionString = Conexion();

            using (SqlConnection connection = new SqlConnection(conectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(Query, connection);
                SqlDataAdapter dataAdapter = new SqlDataAdapter(command);

                DataTable dataTable = new DataTable();

                try
                {
                    dataAdapter.Fill(dataTable);

                    connection.Close();
                    return dataTable;
                }
                catch (Exception ex)
                {
                    connection.Close();
                    return null;
                }
            }
        }
        #endregion

        #region Vista Stock 2
        public DataTable VistaStock2(string idTienda)
        {
            string conectionString;
            string Query = "SELECT * FROM vwStock with(nolock) WHERE [ID Tienda] = @IdTienda";

            conectionString = Conexion();

            using (SqlConnection connection = new SqlConnection(conectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(Query, connection);
                command.Parameters.AddWithValue("@IdTienda", idTienda); // Pasar el parámetro del ID de la tienda

                SqlDataAdapter dataAdapter = new SqlDataAdapter(command);

                DataTable dataTable = new DataTable();

                try
                {
                    dataAdapter.Fill(dataTable);

                    connection.Close();
                    return dataTable;
                }
                catch (Exception ex)
                {
                    connection.Close();
                    return null;
                }
            }
        }
        #endregion

        #region Vista TitulosAutor
        public DataTable VistaTitulosAutor()
        {
            string conectionString;
            string Query = "SELECT * FROM vwTitulosAutor with(nolock)";

            conectionString = Conexion();

            using (SqlConnection connection = new SqlConnection(conectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(Query, connection);
                SqlDataAdapter dataAdapter = new SqlDataAdapter(command);

                DataTable dataTable = new DataTable();

                try
                {
                    dataAdapter.Fill(dataTable);

                    connection.Close();
                    return dataTable;
                }
                catch (Exception ex)
                {
                    connection.Close();
                    return null;
                }
            }
        }
        #endregion

        #region Vista TitulosAutor 2
        public DataTable VistaTitulosAutor2(string idAutor)
        {
            string conectionString;
            string Query = "SELECT * FROM vwTitulosAutor with(nolock) WHERE [ID Autor] = @IdAutor";

            conectionString = Conexion();

            using (SqlConnection connection = new SqlConnection(conectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(Query, connection);
                command.Parameters.AddWithValue("@IdAutor", idAutor);
                SqlDataAdapter dataAdapter = new SqlDataAdapter(command);

                DataTable dataTable = new DataTable();

                try
                {
                    dataAdapter.Fill(dataTable);

                    connection.Close();
                    return dataTable;
                }
                catch (Exception ex)
                {
                    connection.Close();
                    return null;
                }
            }
        }
        #endregion

        #region Vista Tiendas
        public DataTable VistaTiendas()
        {
            string conectionString;
            string Query = "SELECT * FROM vwTiendas with(nolock)";

            conectionString = Conexion();

            using (SqlConnection connection = new SqlConnection(conectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(Query, connection);
                SqlDataAdapter dataAdapter = new SqlDataAdapter(command);

                DataTable dataTable = new DataTable();

                try
                {
                    dataAdapter.Fill(dataTable);

                    connection.Close();
                    return dataTable;
                }
                catch (Exception ex)
                {
                    connection.Close();
                    return null;
                }
            }
        }
        #endregion

        #region Vista Tiendas 2
        public DataTable VistaTiendas2(string idTienda)
        {
            string conectionString;
            string Query = "SELECT * FROM vwTiendas with(nolock) WHERE [ID Tienda] = @IdTienda";

            conectionString = Conexion();

            using (SqlConnection connection = new SqlConnection(conectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(Query, connection);
                command.Parameters.AddWithValue("@IdTienda", idTienda);
                SqlDataAdapter dataAdapter = new SqlDataAdapter(command);

                DataTable dataTable = new DataTable();

                try
                {
                    dataAdapter.Fill(dataTable);

                    connection.Close();
                    return dataTable;
                }
                catch (Exception ex)
                {
                    connection.Close();
                    return null;
                }
            }
        }
        #endregion

        #region Vista Ventas
        public DataTable VistaVentas()
        {
            string conectionString;
            string Query = "SELECT * FROM vwVentas with(nolock)";

            conectionString = Conexion();

            using (SqlConnection connection = new SqlConnection(conectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(Query, connection);
                SqlDataAdapter dataAdapter = new SqlDataAdapter(command);

                DataTable dataTable = new DataTable();

                try
                {
                    dataAdapter.Fill(dataTable);

                    connection.Close();
                    return dataTable;
                }
                catch (Exception ex)
                {
                    connection.Close();
                    return null;
                }
            }
        }
        #endregion

        #region Vista Ventas 2
        public DataTable VistaVentas2(string idTienda)
        {
            string conectionString;
            string Query = "SELECT * FROM vwVentas with(nolock) WHERE [ID Tienda] = @IdTienda";

            conectionString = Conexion();

            using (SqlConnection connection = new SqlConnection(conectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(Query, connection);
                command.Parameters.AddWithValue("@IdTienda", idTienda);
                SqlDataAdapter dataAdapter = new SqlDataAdapter(command);

                DataTable dataTable = new DataTable();

                try
                {
                    dataAdapter.Fill(dataTable);

                    connection.Close();
                    return dataTable;
                }
                catch (Exception ex)
                {
                    connection.Close();
                    return null;
                }
            }
        }
        #endregion

        #region Vista Ventas 3
        public DataTable VistaVentas3(string numOrden)
        {
            string conectionString;
            string Query = "SELECT * FROM vwVentas with(nolock) WHERE [Numero de Orden] = @NumOrden";

            conectionString = Conexion();

            using (SqlConnection connection = new SqlConnection(conectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(Query, connection);
                command.Parameters.AddWithValue("@NumOrden", numOrden);
                SqlDataAdapter dataAdapter = new SqlDataAdapter(command);

                DataTable dataTable = new DataTable();

                try
                {
                    dataAdapter.Fill(dataTable);

                    connection.Close();
                    return dataTable;
                }
                catch (Exception ex)
                {
                    connection.Close();
                    return null;
                }
            }
        }
        #endregion

        #region Vista Empleados
        public DataTable VistaEmpleados()
        {
            string conectionString;
            string Query = "SELECT * FROM vwEmpleados with(nolock)";

            conectionString = Conexion();

            using (SqlConnection connection = new SqlConnection(conectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(Query, connection);
                SqlDataAdapter dataAdapter = new SqlDataAdapter(command);

                DataTable dataTable = new DataTable();

                try
                {
                    dataAdapter.Fill(dataTable);

                    connection.Close();
                    return dataTable;
                }
                catch (Exception ex)
                {
                    connection.Close();
                    return null;
                }
            }
        }
        #endregion

        #region Vista Empleados 2
        public DataTable VistaEmpleados2(string idEmpleado)
        {
            string conectionString;
            string Query = "SELECT * FROM vwEmpleados with(nolock) WHERE [ID Empleado] = @IdEmpleado";

            conectionString = Conexion();

            using (SqlConnection connection = new SqlConnection(conectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(Query, connection);
                command.Parameters.AddWithValue("@IdEmpleado", idEmpleado);
                SqlDataAdapter dataAdapter = new SqlDataAdapter(command);

                DataTable dataTable = new DataTable();

                try
                {
                    dataAdapter.Fill(dataTable);

                    connection.Close();
                    return dataTable;
                }
                catch (Exception ex)
                {
                    connection.Close();
                    return null;
                }
            }
        }
        #endregion

        #region Vista Usuarios
        public DataTable VistaUsuarios()
        {
            string conectionString;
            string Query = "SELECT * FROM vwUsuarios with(nolock)";

            conectionString = Conexion();

            using (SqlConnection connection = new SqlConnection(conectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(Query, connection);
                SqlDataAdapter dataAdapter = new SqlDataAdapter(command);

                DataTable dataTable = new DataTable();

                try
                {
                    dataAdapter.Fill(dataTable);

                    connection.Close();
                    return dataTable;
                }
                catch (Exception ex)
                {
                    connection.Close();
                    return null;
                }
            }
        }
        #endregion

        #region Vista Usuarios 2
        public DataTable VistaUsuarios2(string idUsuario)
        {
            string conectionString;
            string Query = "SELECT * FROM vwUsuarios with(nolock) WHERE [ID Usuario] = @IdUsuario";

            conectionString = Conexion();

            using (SqlConnection connection = new SqlConnection(conectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(Query, connection);
                command.Parameters.AddWithValue("@IdUsuario", idUsuario);
                SqlDataAdapter dataAdapter = new SqlDataAdapter(command);

                DataTable dataTable = new DataTable();

                try
                {
                    dataAdapter.Fill(dataTable);

                    connection.Close();
                    return dataTable;
                }
                catch (Exception ex)
                {
                    connection.Close();
                    return null;
                }
            }
        }
        #endregion

        // PROCEDIMIENTOS EXTRAS

        #region Obtener Estados
        public DataTable ObtenerEstados()
        {
            string CadenaConexion;

            CadenaConexion = Conexion();

            using (SqlConnection connection = new SqlConnection(CadenaConexion))
            {
                connection.Open();
                SqlCommand command = new SqlCommand("spr_Estados", connection);
                command.CommandType = CommandType.StoredProcedure;

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    try
                    {
                        DataTable data = new DataTable();

                        data.Load(reader);

                        connection.Close();
                        return data;
                    }
                    catch (Exception)
                    {

                        throw;
                    }
                }
            }
        }
        #endregion

        #region Obtener Tiendas
        public DataTable ObtenerTiendas()
        {
            string CadenaConexion;

            CadenaConexion = Conexion();

            using (SqlConnection connection = new SqlConnection(CadenaConexion))
            {
                connection.Open();
                SqlCommand command = new SqlCommand("spr_ObtenerTiendas", connection);
                command.CommandType = CommandType.StoredProcedure;

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    try
                    {
                        DataTable data = new DataTable();

                        data.Load(reader);

                        connection.Close();
                        return data;
                    }
                    catch (Exception)
                    {

                        throw;
                    }
                }
            }
        }
        #endregion

        #region Obtener Titulos
        public DataTable ObtenerTitulos()
        {
            string CadenaConexion;

            CadenaConexion = Conexion();

            using (SqlConnection connection = new SqlConnection(CadenaConexion))
            {
                connection.Open();
                SqlCommand command = new SqlCommand("spr_ObtenerTitulos", connection);
                command.CommandType = CommandType.StoredProcedure;

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    try
                    {
                        DataTable data = new DataTable();

                        data.Load(reader);

                        connection.Close();
                        return data;
                    }
                    catch (Exception)
                    {

                        throw;
                    }
                }
            }
        }
        #endregion

        #region Obtener Pub
        public DataTable ObtenerPub()
        {
            string CadenaConexion;

            CadenaConexion = Conexion();

            using (SqlConnection connection = new SqlConnection(CadenaConexion))
            {
                connection.Open();
                SqlCommand command = new SqlCommand("spr_ObtenerEditorialPub", connection);
                command.CommandType = CommandType.StoredProcedure;

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    try
                    {
                        DataTable data = new DataTable();

                        data.Load(reader);

                        connection.Close();
                        return data;
                    }
                    catch (Exception)
                    {

                        throw;
                    }
                }
            }
        }
        #endregion

        #region Obtener Job
        public DataTable ObtenerJob()
        {
            string CadenaConexion;

            CadenaConexion = Conexion();

            using (SqlConnection connection = new SqlConnection(CadenaConexion))
            {
                connection.Open();
                SqlCommand command = new SqlCommand("spr_ObtenerJob", connection);
                command.CommandType = CommandType.StoredProcedure;

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    try
                    {
                        DataTable data = new DataTable();

                        data.Load(reader);

                        connection.Close();
                        return data;
                    }
                    catch (Exception)
                    {

                        throw;
                    }
                }
            }
        }
        #endregion

        #region Obtener Autor
        public DataTable ObtenerAutor()
        {
            string CadenaConexion;

            CadenaConexion = Conexion();

            using (SqlConnection connection = new SqlConnection(CadenaConexion))
            {
                connection.Open();
                SqlCommand command = new SqlCommand("spr_ObtenerAutores", connection);
                command.CommandType = CommandType.StoredProcedure;

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    try
                    {
                        DataTable data = new DataTable();

                        data.Load(reader);

                        connection.Close();
                        return data;
                    }
                    catch (Exception)
                    {

                        throw;
                    }
                }
            }
        }
        #endregion

        #region Obtener Numero
        public DataTable ObtenerNumero()
        {
            string CadenaConexion;

            CadenaConexion = Conexion();

            using (SqlConnection connection = new SqlConnection(CadenaConexion))
            {
                connection.Open();
                SqlCommand command = new SqlCommand("spr_ObtenerNumeroOrden", connection);
                command.CommandType = CommandType.StoredProcedure;

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    try
                    {
                        DataTable data = new DataTable();

                        data.Load(reader);

                        connection.Close();
                        return data;
                    }
                    catch (Exception)
                    {

                        throw;
                    }
                }
            }
        }
        #endregion

        #region Obtener Ventas
        public DataTable ObtenerVentas()
        {
            string CadenaConexion;

            CadenaConexion = Conexion();

            using (SqlConnection connection = new SqlConnection(CadenaConexion))
            {
                connection.Open();
                SqlCommand command = new SqlCommand("spr_ObtenerVentas", connection);
                command.CommandType = CommandType.StoredProcedure;

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    try
                    {
                        DataTable data = new DataTable();

                        data.Load(reader);

                        connection.Close();
                        return data;
                    }
                    catch (Exception)
                    {

                        throw;
                    }
                }
            }
        }
        #endregion

        #region Obtener Empleados
        public DataTable ObtenerEmpleados()
        {
            string CadenaConexion;

            CadenaConexion = Conexion();

            using (SqlConnection connection = new SqlConnection(CadenaConexion))
            {
                connection.Open();
                SqlCommand command = new SqlCommand("spr_ObtenerEMPLEADO", connection);
                command.CommandType = CommandType.StoredProcedure;

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    try
                    {
                        DataTable data = new DataTable();

                        data.Load(reader);

                        connection.Close();
                        return data;
                    }
                    catch (Exception)
                    {

                        throw;
                    }
                }
            }
        }
        #endregion

        #region Obtener Usuarios
        public DataTable ObtenerUsuarios()
        {
            string CadenaConexion;

            CadenaConexion = Conexion();

            using (SqlConnection connection = new SqlConnection(CadenaConexion))
            {
                connection.Open();
                SqlCommand command = new SqlCommand("spr_ObtenerUsuario", connection);
                command.CommandType = CommandType.StoredProcedure;

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    try
                    {
                        DataTable data = new DataTable();

                        data.Load(reader);

                        connection.Close();
                        return data;
                    }
                    catch (Exception)
                    {

                        throw;
                    }
                }
            }
        }
        #endregion

        #region Actualizar BookStock
        public void ActualizarBookStock(string stor_id, string title_id, int nuevaCantidad)
        {
            string consulta = "UPDATE BookStock SET quantity = @nuevaCantidad WHERE store_id = @stor_id AND title_id = @title_id";
            string CadenaConexion;
            CadenaConexion = Conexion();
            using (SqlConnection conexion = new SqlConnection(CadenaConexion))
            {
                using (SqlCommand comando = new SqlCommand(consulta, conexion))
                {
                    comando.Parameters.AddWithValue("@nuevaCantidad", nuevaCantidad);
                    comando.Parameters.AddWithValue("@stor_id", stor_id);
                    comando.Parameters.AddWithValue("@title_id", title_id);

                    conexion.Open();
                    comando.ExecuteNonQuery();
                }
            }
        }
        #endregion

        #region Libro Existente
        public bool LibroExistenteEnTienda(string IdTienda, string IdTitulo)
        {
            // Variable para almacenar el resultado de la consulta
            bool existe = false;

            // Cadena de conexión a la base de datos
            string connectionString = Conexion();

            // Consulta SQL para verificar si existe un registro con el mismo IdTienda y IdTitulo
            string query = "SELECT COUNT(*) FROM BookStock WHERE store_id = @IdTienda AND title_id = @IdTitulo";

            // Creación de la conexión y comando SQL
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    // Agregar los parámetros IdTienda e IdTitulo a la consulta
                    command.Parameters.AddWithValue("@IdTienda", IdTienda);
                    command.Parameters.AddWithValue("@IdTitulo", IdTitulo);

                    try
                    {
                        // Abrir la conexión y ejecutar la consulta
                        connection.Open();
                        int count = (int)command.ExecuteScalar(); // Obtenemos el número de filas que coinciden con la consulta
                        existe = count > 0; // Si count es mayor que cero, significa que el libro ya existe en la tienda
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Error al ejecutar la consulta: " + ex.Message);
                    }
                }
            }

            return existe; // Devolvemos true si el libro ya existe en la tienda, false si no existe
        }
        #endregion

        #region Obtener BookStock
        public int ObtenerStock(string stor_id, string title_id)
        {
            string consulta = "SELECT quantity FROM BookStock WHERE store_id = @stor_id AND title_id = @title_id";
            int stock = 0;
            string CadenaConexion;
            CadenaConexion = Conexion();
            using (SqlConnection conexion = new SqlConnection(CadenaConexion))
            {
                using (SqlCommand comando = new SqlCommand(consulta, conexion))
                {
                    comando.Parameters.AddWithValue("@stor_id", stor_id);
                    comando.Parameters.AddWithValue("@title_id", title_id);

                    conexion.Open();
                    var result = comando.ExecuteScalar();
                    if (result != null && result != DBNull.Value)
                    {
                        stock = Convert.ToInt32(result);
                    }
                }
            }
            return stock;
        }
        #endregion

        #region Obtener InformacionLibro
        public DataTable ObtenerInformacionLibro(string Idtitulo)
        {
            string CadenaConexion;

            CadenaConexion = Conexion();

            using (SqlConnection connection = new SqlConnection(CadenaConexion))
            {
                connection.Open();
                SqlCommand command = new SqlCommand("spr_ObtenerInformacionLibro", connection);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@Id_titulo", Idtitulo);
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    try
                    {
                        DataTable data = new DataTable();

                        data.Load(reader);

                        connection.Close();
                        return data;
                    }
                    catch (Exception)
                    {

                        throw;
                    }
                }
            }
        }
        #endregion

        #region Calcular Descuento
        public List<string> ObtenerDescuentos(int cantidad)
        {
            string connectionString = Conexion();
            List<string> descuentos = new List<string>();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    string query = @"SELECT discounttype, discount 
                                     FROM discounts
                                     WHERE lowqty <= @Cantidad AND highqty >= @Cantidad";

                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@Cantidad", cantidad);

                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        descuentos.Add(reader["discounttype"].ToString() + " - " + reader["discount"].ToString() + "%");
                    }

                    reader.Close();
                }
                catch (Exception ex)
                {
                    // Manejar excepciones según lo desees
                    throw ex;
                }
            }

            return descuentos;
        }
        #endregion


        //------------ AUTORES -----------------
        #region Alta Autores
        public void AltaAutores(string Id, string Nombre, string Apellido, string Telefono, string Direccion, string Ciudad, string Estado, string CodigoPostal, bool Contrato)
        {
            //Obtenemos la cadena de conexión de nuestra base de datos
            string conectionString;
            conectionString = Conexion();

            //Generamos la conexión
            using (SqlConnection connection = new SqlConnection(conectionString))
            {
                try
                {
                    //Abrimos la conexión
                    connection.Open();
                    //Indicamos el comando que se va a ejecutar en este caso un stored prodcedure
                    SqlCommand command = new SqlCommand("spi_AltaAutor", connection);
                    //Le indicamos que tipo de componente es
                    command.CommandType = CommandType.StoredProcedure;

                    //Le mandamos las variables ingresadas en los texbox
                    command.Parameters.AddWithValue("@Id", Id);
                    command.Parameters.AddWithValue("@Nombre", Nombre);
                    command.Parameters.AddWithValue("@Apellido", Apellido);
                    command.Parameters.AddWithValue("@Telefono", Telefono);
                    command.Parameters.AddWithValue("@Direccion", Direccion);
                    command.Parameters.AddWithValue("@Ciudad", Ciudad);
                    command.Parameters.AddWithValue("@Estado", Estado);
                    command.Parameters.AddWithValue("@CodigoPostal", CodigoPostal);
                    command.Parameters.AddWithValue("@Contrato", Contrato);

                    //Ejecutamos el componente "Similar a EXEC en SQL"
                    command.ExecuteNonQuery();
                    connection.Close();
                }
                catch (SqlException ex)
                {
                    // Manejar específicamente errores de SQL Server
                    Console.WriteLine("Error al ejecutar el stored procedure: " + ex.Message);
                    throw; // Relanzar la excepción para que pueda ser capturada en el bloque catch de tu código de presentación
                }
                catch (Exception ex)
                {
                    // Otros tipos de errores
                    Console.WriteLine("Error al ejecutar el stored procedure: " + ex.Message);
                    throw; // Relanzar la excepción para que pueda ser capturada en el bloque catch de tu código de presentación
                }
                finally
                {
                    connection.Close(); // Asegúrate de cerrar la conexión
                }
            }
        }
        #endregion

        #region Eliminar Autor
        public void EliminarRegistroAutor(string idAutor)
        {
            string connectionString;
            connectionString = Conexion();

            // Definir la consulta SQL para eliminar los títulos asociados al autor
            string deleteTitleAuthorQuery = "DELETE FROM titleauthor WHERE au_id = @AuthorID";

            // Definir la consulta SQL para eliminar el autor
            string deleteAuthorQuery = "DELETE FROM authors WHERE au_id = @AuthorID";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlTransaction transaction = connection.BeginTransaction();

                try
                {
                    // Eliminar las filas en la tabla titleauthor que hacen referencia al autor
                    using (SqlCommand command = new SqlCommand(deleteTitleAuthorQuery, connection, transaction))
                    {
                        command.Parameters.AddWithValue("@AuthorID", idAutor);
                        command.ExecuteNonQuery();
                    }

                    // Eliminar el registro del autor en la tabla authors
                    using (SqlCommand command = new SqlCommand(deleteAuthorQuery, connection, transaction))
                    {
                        command.Parameters.AddWithValue("@AuthorID", idAutor);
                        command.ExecuteNonQuery();
                    }

                    // Confirmar la transacción
                    transaction.Commit();
                }
                catch (Exception ex)
                {
                    // Deshacer la transacción en caso de error
                    transaction.Rollback();
                    throw new Exception("Error al eliminar el autor y sus títulos asociados: " + ex.Message);
                }
            }
        }
        #endregion

        #region Actualizar Autor
        public void ActualizarAutor(string idRegistro, string Nombre, string Apellido, string Telefono, string Direccion, string Ciudad, string Estado, string CodigoPostal, bool Contrato)
        {
            string connectionString = Conexion();
            string updateQuery = "UPDATE authors SET au_fname = @Nombre, au_lname = @Apellido, phone = @Telefono," +
                                 "address = @Direccion, city = @Ciudad, state = @Estado, zip = @CodigoPostal, contract = @Contrato WHERE au_id = @IDRegistro";

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    using (SqlCommand command = new SqlCommand(updateQuery, connection))
                    {
                        command.Parameters.AddWithValue("@Nombre", Nombre);
                        command.Parameters.AddWithValue("@Apellido", Apellido);
                        command.Parameters.AddWithValue("@Telefono", Telefono);
                        command.Parameters.AddWithValue("@Direccion", Direccion);
                        command.Parameters.AddWithValue("@Ciudad", Ciudad);
                        command.Parameters.AddWithValue("@Estado", Estado);
                        command.Parameters.AddWithValue("@CodigoPostal", CodigoPostal);
                        command.Parameters.AddWithValue("@Contrato", Contrato);
                        command.Parameters.AddWithValue("@IDRegistro", idRegistro);

                        connection.Open();
                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            Console.WriteLine("La actualización se realizó correctamente. Filas afectadas: " + rowsAffected);
                        }
                        else
                        {
                            Console.WriteLine("La actualización no afectó ninguna fila.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al actualizar el registro: " + ex.Message);
                throw; // Propagar la excepción para que se maneje en el código que llama a este método
            }
        }
        #endregion

        //------------ EMPLEADOS -----------------
        #region Alta Empleados
        public void AltaEmpleados(string Id, string Nombre, string Inicial, string Apellido, short IdTrabajo, byte Nivel,
            string IdPub, DateTime FechaContratacion)
        {
            //Obtenemos la cadena de conexión de nuestra base de datos
            string conectionString;
            conectionString = Conexion();

            //Generamos la conexión
            using (SqlConnection connection = new SqlConnection(conectionString))
            {
                try
                {
                    //Abrimos la conexión
                    connection.Open();
                    //Indicamos el comando que se va a ejecutar en este caso un stored prodcedure
                    SqlCommand command = new SqlCommand("spi_AltaEmpleados", connection);
                    //Le indicamos que tipo de componente es
                    command.CommandType = CommandType.StoredProcedure;

                    //Le mandamos las variables ingresadas en los texbox
                    command.Parameters.AddWithValue("@IdEmpleado", Id);
                    command.Parameters.AddWithValue("@NompreEmpleado", Nombre);
                    command.Parameters.AddWithValue("@Inicial", Inicial);
                    command.Parameters.AddWithValue("@ApellidoEmpleado", Apellido);
                    command.Parameters.AddWithValue("@IdTrabajo", IdTrabajo);
                    command.Parameters.AddWithValue("@NivelTrabajo", Nivel);
                    command.Parameters.AddWithValue("@IdPub", IdPub);
                    command.Parameters.AddWithValue("@FechaContratacion", FechaContratacion);

                    //Ejecutamos el componente "Similar a EXEC en SQL"
                    command.ExecuteNonQuery();
                    connection.Close();
                }
                catch (SqlException ex)
                {
                    // Manejar específicamente errores de SQL Server
                    Console.WriteLine("Error al ejecutar el stored procedure: " + ex.Message);
                    throw; // Relanzar la excepción para que pueda ser capturada en el bloque catch de tu código de presentación
                }
                catch (Exception ex)
                {
                    // Otros tipos de errores
                    Console.WriteLine("Error al ejecutar el stored procedure: " + ex.Message);
                    throw; // Relanzar la excepción para que pueda ser capturada en el bloque catch de tu código de presentación
                }
                finally
                {
                    connection.Close(); // Asegúrate de cerrar la conexión
                }
            }
        }
        #endregion

        #region Eliminar Empleado
        public void EliminarRegistroEmpleado(string idEmpleado)
        {
            string conectionString;
            conectionString = Conexion();
            // Consulta SQL para eliminar el registro con el ID proporcionado
            string query = "DELETE FROM employee WHERE emp_id = @IDEmpleado";

            using (SqlConnection connection = new SqlConnection(conectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    // Agregar parámetro para el ID
                    command.Parameters.AddWithValue("@IDEmpleado", idEmpleado);

                    try
                    {
                        // Abrir la conexión
                        connection.Open();

                        // Ejecutar la consulta
                        command.ExecuteNonQuery();
                    }
                    catch (Exception ex)
                    {
                        // Manejar cualquier error
                        throw new Exception("Error al eliminar el registro: " + ex.Message);
                    }
                }
            }
        }
        #endregion

        #region Actualizar Empleado
        public void ActualizarEmpleado(string idRegistro, string Nombre, string Inicial, string Apellido, short IdTrabajo, byte Nivel,
            string IdPub, DateTime FechaContratacion)
        {
            string connectionString;
            connectionString = Conexion();

            // Consulta SQL para actualizar el registro en la base de datos
            string updateQuery = "UPDATE employee SET fname = @NompreEmpleado, minit = @Inicial, lname = @ApellidoEmpleado," +
                "job_id = @IdTrabajo, job_lvl = @NivelTrabajo, pub_id = @IdPub, hire_date = @FechaContratacion WHERE emp_id = @IDRegistro";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(updateQuery, connection))
                {
                    // Agregar parámetros para los nuevos datos y el ID del registro
                    command.Parameters.AddWithValue("@NompreEmpleado", Nombre);
                    command.Parameters.AddWithValue("@Inicial", Inicial);
                    command.Parameters.AddWithValue("@ApellidoEmpleado", Apellido);
                    command.Parameters.AddWithValue("@IdTrabajo", IdTrabajo);
                    command.Parameters.AddWithValue("@NivelTrabajo", Nivel);
                    command.Parameters.AddWithValue("@IdPub", IdPub);
                    command.Parameters.AddWithValue("@FechaContratacion", FechaContratacion);
                    command.Parameters.AddWithValue("@IDRegistro", idRegistro);

                    try
                    {
                        // Abrir la conexión
                        connection.Open();

                        // Ejecutar la consulta de actualización
                        command.ExecuteNonQuery();
                    }
                    catch (Exception ex)
                    {
                        // Manejar cualquier error que ocurra durante la actualización
                        throw new Exception("Error al actualizar el registro: " + ex.Message);
                    }
                }
            }
        }
        #endregion

        //------------ TITULOS -----------------
        #region Alta Titulos
        public void AltaTitulos(string IdTitulo, string Titulo, string Tipo, string IdPub, decimal Precio,
                    decimal Anticipo, int Regalias, int YtdVentas, string Notas, DateTime FechaPublicacion)
        {
            //Obtenemos la cadena de conexión de nuestra base de datos
            string conectionString;
            conectionString = Conexion();

            //Generamos la conexión
            using (SqlConnection connection = new SqlConnection(conectionString))
            {
                try
                {
                    //Abrimos la conexión
                    connection.Open();
                    //Indicamos el comando que se va a ejecutar en este caso un stored prodcedure
                    SqlCommand command = new SqlCommand("spi_AltaTitulos", connection);
                    //Le indicamos que tipo de componente es
                    command.CommandType = CommandType.StoredProcedure;

                    //Le mandamos las variables ingresadas en los texbox
                    command.Parameters.AddWithValue("@IdTitulo", IdTitulo);
                    command.Parameters.AddWithValue("@Titulo", Titulo);
                    command.Parameters.AddWithValue("@Tipo", Tipo);
                    command.Parameters.AddWithValue("@IdPub", IdPub);
                    command.Parameters.AddWithValue("@Precio", Precio);
                    command.Parameters.AddWithValue("@Anticipo", Anticipo);
                    command.Parameters.AddWithValue("@Regalias", Regalias);
                    command.Parameters.AddWithValue("@YtdVentas", YtdVentas);
                    command.Parameters.AddWithValue("@Notas", Notas);
                    command.Parameters.AddWithValue("@FechaPublicacion", FechaPublicacion);

                    //Ejecutamos el componente "Similar a EXEC en SQL"
                    command.ExecuteNonQuery();
                    connection.Close();
                }
                catch (SqlException ex)
                {
                    // Manejar específicamente errores de SQL Server
                    Console.WriteLine("Error al ejecutar el stored procedure: " + ex.Message);
                    throw; // Relanzar la excepción para que pueda ser capturada en el bloque catch de tu código de presentación
                }
                catch (Exception ex)
                {
                    // Otros tipos de errores
                    Console.WriteLine("Error al ejecutar el stored procedure: " + ex.Message);
                    throw; // Relanzar la excepción para que pueda ser capturada en el bloque catch de tu código de presentación
                }
                finally
                {
                    connection.Close(); // Asegúrate de cerrar la conexión
                }
            }
        }
        #endregion

        #region Eliminar Titulo
        public void EliminarRegistroTitulo(string idTitulo)
        {
            string connectionString;
            connectionString = Conexion();

            // Definir la consulta SQL para deshabilitar la restricción de referencia en la tabla sales
            string disableConstraintQuery = "ALTER TABLE sales NOCHECK CONSTRAINT FK__sales__title_id__4BAC3F29";

            // Definir la consulta SQL para eliminar los títulos asociados al autor
            string deleteTitleAuthorQuery = "DELETE FROM titleauthor WHERE title_id = @TitleID";

            string deleteTitleBookStockQuery = "DELETE FROM bookstock WHERE title_id = @TitleID";

            // Definir la consulta SQL para eliminar el autor
            string deleteTitleQuery = "DELETE FROM titles WHERE title_id = @TitleID";

            // Definir la consulta SQL para habilitar nuevamente la restricción de referencia en la tabla sales
            string enableConstraintQuery = "ALTER TABLE sales CHECK CONSTRAINT FK__sales__title_id__4BAC3F29";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlTransaction transaction = connection.BeginTransaction();

                try
                {
                    // Deshabilitar la restricción de referencia en la tabla sales
                    using (SqlCommand command = new SqlCommand(disableConstraintQuery, connection, transaction))
                    {
                        command.ExecuteNonQuery();
                    }

                    // Eliminar las filas en la tabla titleauthor que hacen referencia al título
                    using (SqlCommand command = new SqlCommand(deleteTitleAuthorQuery, connection, transaction))
                    {
                        command.Parameters.AddWithValue("@TitleID", idTitulo);
                        command.ExecuteNonQuery();
                    }

                    using (SqlCommand command = new SqlCommand(deleteTitleBookStockQuery, connection, transaction))
                    {
                        command.Parameters.AddWithValue("@TitleID", idTitulo);
                        command.ExecuteNonQuery();
                    }

                    // Eliminar el registro del título en la tabla titles
                    using (SqlCommand command = new SqlCommand(deleteTitleQuery, connection, transaction))
                    {
                        command.Parameters.AddWithValue("@TitleID", idTitulo);
                        command.ExecuteNonQuery();
                    }

                    // Habilitar nuevamente la restricción de referencia en la tabla sales
                    using (SqlCommand command = new SqlCommand(enableConstraintQuery, connection, transaction))
                    {
                        command.ExecuteNonQuery();
                    }

                    // Confirmar la transacción
                    transaction.Commit();
                }
                catch (Exception ex)
                {
                    // Deshacer la transacción en caso de error
                    transaction.Rollback();
                    throw new Exception("Error al eliminar el título y sus asociados: " + ex.Message);
                }
            }
        }
        #endregion

        #region Actualizar Titulo
        public void ActualizarTitulo(string idRegistro, string Titulo, string Tipo, string IdPub, decimal Precio,
                decimal Anticipo, int Regalias, int YtdVentas, string Notas, DateTime FechaPublicacion)
        {
            string connectionString;
            connectionString = Conexion();

            // Consulta SQL para actualizar el registro en la base de datos
            string updateQuery = "UPDATE titles SET title = @Titulo, type = @Tipo, pub_id = @IdPub," +
                "price = @Precio, advance = @Anticipo, royalty = @Regalias, ytd_sales = @YtdVentas, " +
                "notes = @Notas, pubdate = @FechaPublicacion WHERE title_id = @IDRegistro";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(updateQuery, connection))
                {
                    // Agregar parámetros para los nuevos datos y el ID del registro
                    command.Parameters.AddWithValue("@Titulo", Titulo);
                    command.Parameters.AddWithValue("@Tipo", Tipo);
                    command.Parameters.AddWithValue("@IdPub", IdPub);
                    command.Parameters.AddWithValue("@Precio", Precio);
                    command.Parameters.AddWithValue("@Anticipo", Anticipo);
                    command.Parameters.AddWithValue("@Regalias", Regalias);
                    command.Parameters.AddWithValue("@YtdVentas", YtdVentas);
                    command.Parameters.AddWithValue("@Notas", Notas);
                    command.Parameters.AddWithValue("@FechaPublicacion", FechaPublicacion);
                    command.Parameters.AddWithValue("@IDRegistro", idRegistro);

                    try
                    {
                        // Abrir la conexión
                        connection.Open();

                        // Ejecutar la consulta de actualización
                        command.ExecuteNonQuery();
                    }
                    catch (Exception ex)
                    {
                        // Manejar cualquier error que ocurra durante la actualización
                        throw new Exception("Error al actualizar el registro: " + ex.Message);
                    }
                }
            }
        }
        #endregion

        //------------ TIENDAS -----------------
        #region Alta Tiendas
        public void AltaTiendas(string IdTienda, string Nombre, string Direccion, string Ciudad, string Estado,
                    string CodigoPostal)
        {
            //Obtenemos la cadena de conexión de nuestra base de datos
            string conectionString;
            conectionString = Conexion();

            //Generamos la conexión
            using (SqlConnection connection = new SqlConnection(conectionString))
            {
                try
                {
                    //Abrimos la conexión
                    connection.Open();
                    //Indicamos el comando que se va a ejecutar en este caso un stored prodcedure
                    SqlCommand command = new SqlCommand("spi_AltaTiendas", connection);
                    //Le indicamos que tipo de componente es
                    command.CommandType = CommandType.StoredProcedure;

                    //Le mandamos las variables ingresadas en los texbox
                    command.Parameters.AddWithValue("@IdTienda", IdTienda);
                    command.Parameters.AddWithValue("@NombreTienda", Nombre);
                    command.Parameters.AddWithValue("@Direccion", Direccion);
                    command.Parameters.AddWithValue("@Ciudad", Ciudad);
                    command.Parameters.AddWithValue("@Estado", Estado);
                    command.Parameters.AddWithValue("@CodigoPostal", CodigoPostal);

                    //Ejecutamos el componente "Similar a EXEC en SQL"
                    command.ExecuteNonQuery();
                    connection.Close();
                }
                catch (SqlException ex)
                {
                    // Manejar específicamente errores de SQL Server
                    Console.WriteLine("Error al ejecutar el stored procedure: " + ex.Message);
                    throw; // Relanzar la excepción para que pueda ser capturada en el bloque catch de tu código de presentación
                }
                catch (Exception ex)
                {
                    // Otros tipos de errores
                    Console.WriteLine("Error al ejecutar el stored procedure: " + ex.Message);
                    throw; // Relanzar la excepción para que pueda ser capturada en el bloque catch de tu código de presentación
                }
                finally
                {
                    connection.Close(); // Asegúrate de cerrar la conexión
                }
            }
        }
        #endregion

        #region Eliminar Tienda
        public void EliminarRegistroTienda(string idTienda)
        {
            string conectionString = Conexion();

            // Consulta SQL para deshabilitar la restricción de referencia en la tabla sales
            string disableConstraintQuery = "ALTER TABLE sales NOCHECK CONSTRAINT FK__sales__stor_id__4AB81AF0";

            // Consulta SQL para eliminar el registro de la tabla stores
            string deleteStoreQuery = "DELETE FROM stores WHERE stor_id = @IDTienda";

            string deleteStockQuery = "DELETE FROM bookstock WHERE store_id = @IDTienda";

            // Consulta SQL para habilitar nuevamente la restricción de referencia en la tabla sales
            string enableConstraintQuery = "ALTER TABLE sales CHECK CONSTRAINT FK__sales__stor_id__4AB81AF0";

            using (SqlConnection connection = new SqlConnection(conectionString))
            {
                connection.Open();
                SqlTransaction transaction = connection.BeginTransaction();

                try
                {
                    // Deshabilitar la restricción de referencia en la tabla sales
                    using (SqlCommand command = new SqlCommand(disableConstraintQuery, connection, transaction))
                    {
                        command.ExecuteNonQuery();
                    }

                    using (SqlCommand command = new SqlCommand(deleteStockQuery, connection, transaction))
                    {
                        command.Parameters.AddWithValue("@IDTienda", idTienda);
                        command.ExecuteNonQuery();
                    }

                    // Eliminar el registro de la tienda en la tabla stores
                    using (SqlCommand command = new SqlCommand(deleteStoreQuery, connection, transaction))
                    {
                        command.Parameters.AddWithValue("@IDTienda", idTienda);
                        command.ExecuteNonQuery();
                    }

                    // Habilitar nuevamente la restricción de referencia en la tabla sales
                    using (SqlCommand command = new SqlCommand(enableConstraintQuery, connection, transaction))
                    {
                        command.ExecuteNonQuery();
                    }

                    // Confirmar la transacción
                    transaction.Commit();
                }
                catch (Exception ex)
                {
                    // Deshacer la transacción en caso de error
                    transaction.Rollback();
                    throw new Exception("Error al eliminar el registro de la tienda: " + ex.Message);
                }
            }
        }
        #endregion

        #region Actualizar Tienda
        public void ActualizarTienda(string idRegistro, string Nombre, string Direccion, string Ciudad, string Estado,
                    string CodigoPostal)
        {
            string connectionString;
            connectionString = Conexion();

            // Consulta SQL para actualizar el registro en la base de datos
            string updateQuery = "UPDATE stores SET stor_name = @NombreTienda, stor_address = @Direccion, city = @Ciudad," +
                "state = @Estado, zip = @CodigoPostal WHERE stor_id = @IDRegistro";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(updateQuery, connection))
                {
                    // Agregar parámetros para los nuevos datos y el ID del registro
                    command.Parameters.AddWithValue("@NombreTienda", Nombre);
                    command.Parameters.AddWithValue("@Direccion", Direccion);
                    command.Parameters.AddWithValue("@Ciudad", Ciudad);
                    command.Parameters.AddWithValue("@Estado", Estado);
                    command.Parameters.AddWithValue("@CodigoPostal", CodigoPostal);
                    command.Parameters.AddWithValue("@IDRegistro", idRegistro);

                    try
                    {
                        // Abrir la conexión
                        connection.Open();

                        // Ejecutar la consulta de actualización
                        command.ExecuteNonQuery();
                    }
                    catch (Exception ex)
                    {
                        // Manejar cualquier error que ocurra durante la actualización
                        throw new Exception("Error al actualizar el registro: " + ex.Message);
                    }
                }
            }
        }
        #endregion

        //------------ VENTAS -----------------
        #region Alta Ventas
        public bool AltaVentas(string IdTienda, string NumeroOrden, DateTime FechaOrden, short Cantidad, string Payterms,
        string IdTitulo)
        {
            //Obtenemos la cadena de conexión de nuestra base de datos
            string conectionString;
            conectionString = Conexion();

            //Generamos la conexión
            using (SqlConnection connection = new SqlConnection(conectionString))
            {
                try
                {
                    //Abrimos la conexión
                    connection.Open();

                    // Verificar si hay suficiente stock antes de realizar la venta
                    int stockActual = ObtenerStock(IdTienda, IdTitulo);
                    if (stockActual < Cantidad)
                    {
                        MessageBox.Show("¡No hay suficiente stock para realizar esta venta!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return false; // La venta no se realizó debido a falta de stock
                    }

                    //Indicamos el comando que se va a ejecutar en este caso un stored procedure
                    SqlCommand command = new SqlCommand("spi_AltaVentas", connection);
                    //Le indicamos que tipo de componente es
                    command.CommandType = CommandType.StoredProcedure;

                    //Le mandamos las variables ingresadas en los texbox
                    command.Parameters.AddWithValue("@IdTienda", IdTienda);
                    command.Parameters.AddWithValue("@NumeroOrden", NumeroOrden);
                    command.Parameters.AddWithValue("@FechaOrden", FechaOrden);
                    command.Parameters.AddWithValue("@Cantidad", Cantidad);
                    command.Parameters.AddWithValue("@Payterms", Payterms);
                    command.Parameters.AddWithValue("@IdTitulo", IdTitulo);

                    //Ejecutamos el componente "Similar a EXEC en SQL"
                    command.ExecuteNonQuery();

                    // Actualizar el stock después de la venta
                    ActualizarBookStock(IdTienda, IdTitulo, stockActual - Cantidad);

                    // Verificar si el stock es bajo y mostrar mensaje de advertencia si es necesario
                    if (stockActual - Cantidad <= 5)
                    {
                        MessageBox.Show("¡Atención! El stock de este libro es bajo. Considere aumentar el inventario.", "Stock Bajo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }

                    return true; // La venta se realizó correctamente
                }
                catch (SqlException ex)
                {
                    // Manejar específicamente errores de SQL Server
                    Console.WriteLine("Error al ejecutar el stored procedure: " + ex.Message);
                    throw; // Relanzar la excepción para que pueda ser capturada en el bloque catch de tu código de presentación
                }
                catch (Exception ex)
                {
                    // Otros tipos de errores
                    Console.WriteLine("Error al ejecutar el stored procedure: " + ex.Message);
                    throw; // Relanzar la excepción para que pueda ser capturada en el bloque catch de tu código de presentación
                }
                finally
                {
                    connection.Close(); // Asegúrate de cerrar la conexión
                }
            }
        }
        #endregion

        #region Eliminar Venta
        public void EliminarRegistroVenta(string idTienda, string ordNum)
        {
            string conectionString;
            conectionString = Conexion();
            // Consulta SQL para eliminar el registro con el ID proporcionado
            string query = "DELETE FROM sales WHERE stor_id = @IDTienda AND ord_num = @NumeroOrden";

            using (SqlConnection connection = new SqlConnection(conectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    // Agregar parámetro para el ID
                    command.Parameters.AddWithValue("@IDTienda", idTienda);
                    command.Parameters.AddWithValue("@NumeroOrden", ordNum);

                    try
                    {
                        // Abrir la conexión
                        connection.Open();

                        // Ejecutar la consulta
                        command.ExecuteNonQuery();
                    }
                    catch (Exception ex)
                    {
                        // Manejar cualquier error
                        throw new Exception("Error al eliminar el registro: " + ex.Message);
                    }
                }
            }
        }
        #endregion

        #region Actualizar Venta
        public void ActualizarVenta(string idRegistro, string IdTienda, DateTime FechaOrden, short Cantidad, string Payterms,
                    string IdTitulo)
        {
            string connectionString;
            connectionString = Conexion();

            // Consulta SQL para actualizar el registro en la base de datos
            string updateQuery = "UPDATE sales SET stor_id = @IdTienda, ord_date = @FechaOrden, qty = @Cantidad," +
                "payterms = @Payterms, title_id = @IdTitulo WHERE ord_num = @IDRegistro";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(updateQuery, connection))
                {
                    // Agregar parámetros para los nuevos datos y el ID del registro
                    command.Parameters.AddWithValue("@IdTienda", IdTienda);
                    command.Parameters.AddWithValue("@FechaOrden", FechaOrden);
                    command.Parameters.AddWithValue("@Cantidad", Cantidad);
                    command.Parameters.AddWithValue("@Payterms", Payterms);
                    command.Parameters.AddWithValue("@IdTitulo", IdTitulo);
                    command.Parameters.AddWithValue("@IDRegistro", idRegistro);

                    try
                    {
                        // Abrir la conexión
                        connection.Open();

                        // Ejecutar la consulta de actualización
                        command.ExecuteNonQuery();

                        // Verificar si el stock es bajo después de la venta y mostrar un mensaje de advertencia si es necesario
                        int stockActual = ObtenerStock(IdTienda, IdTitulo);
                        if (stockActual - Cantidad <= 5)
                        {
                            MessageBox.Show("¡Atención! El stock de este libro es bajo. Considere aumentar el inventario.", "Stock Bajo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }

                        // Actualizar el stock después de la venta
                        ActualizarBookStock(IdTienda, IdTitulo, stockActual - Cantidad);
                    }
                    catch (Exception ex)
                    {
                        // Manejar cualquier error que ocurra durante la actualización
                        throw new Exception("Error al actualizar el registro: " + ex.Message);
                    }
                }
            }
        }
        #endregion

        //------------ TITULOS AUTOR -----------------
        #region Alta TitulosAutor
        public void AltaTitulosAutor(string IdAutor, string IdTitulo, byte OrdenAutor, int Royaltyper)
        {
            //Obtenemos la cadena de conexión de nuestra base de datos
            string conectionString;
            conectionString = Conexion();

            //Generamos la conexión
            using (SqlConnection connection = new SqlConnection(conectionString))
            {
                try
                {
                    //Abrimos la conexión
                    connection.Open();
                    //Indicamos el comando que se va a ejecutar en este caso un stored prodcedure
                    SqlCommand command = new SqlCommand("spi_AltaTitulosAutor", connection);
                    //Le indicamos que tipo de componente es
                    command.CommandType = CommandType.StoredProcedure;

                    //Le mandamos las variables ingresadas en los texbox
                    command.Parameters.AddWithValue("@IdAutor", IdAutor);
                    command.Parameters.AddWithValue("@IdTitulo", IdTitulo);
                    command.Parameters.AddWithValue("@OrdenAutor", OrdenAutor);
                    command.Parameters.AddWithValue("@RoyalTyper", Royaltyper);

                    //Ejecutamos el componente "Similar a EXEC en SQL"
                    command.ExecuteNonQuery();
                    connection.Close();
                }
                catch (SqlException ex)
                {
                    // Manejar específicamente errores de SQL Server
                    Console.WriteLine("Error al ejecutar el stored procedure: " + ex.Message);
                    throw; // Relanzar la excepción para que pueda ser capturada en el bloque catch de tu código de presentación
                }
                catch (Exception ex)
                {
                    // Otros tipos de errores
                    Console.WriteLine("Error al ejecutar el stored procedure: " + ex.Message);
                    throw; // Relanzar la excepción para que pueda ser capturada en el bloque catch de tu código de presentación
                }
                finally
                {
                    connection.Close(); // Asegúrate de cerrar la conexión
                }
            }
        }
        #endregion

        #region Eliminar TituloAutor
        public void EliminarRegistroTituloAutor(string idAutor, string idTitulo)
        {
            string conectionString;
            conectionString = Conexion();
            // Consulta SQL para eliminar el registro con el ID proporcionado
            string query = "DELETE FROM titleauthor WHERE au_id = @IDAutor AND title_id = @IDTitulo";

            using (SqlConnection connection = new SqlConnection(conectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    // Agregar parámetro para el ID
                    command.Parameters.AddWithValue("@IDAutor", idAutor);
                    command.Parameters.AddWithValue("@IDTitulo", idTitulo);

                    try
                    {
                        // Abrir la conexión
                        connection.Open();

                        // Ejecutar la consulta
                        command.ExecuteNonQuery();
                    }
                    catch (Exception ex)
                    {
                        // Manejar cualquier error
                        throw new Exception("Error al eliminar el registro: " + ex.Message);
                    }
                }
            }
        }
        #endregion

        #region Actualizar TituloAutor
        public void ActualizarTituloAutor(string idAutorRegistro, string idTituloRegistro, byte OrdenAutor, int Royaltyper, string nuevoIdAutor, string nuevoIdTitulo)
        {
            string connectionString;
            connectionString = Conexion();

            // Consulta SQL para actualizar el registro en la base de datos
            string updateQuery = "UPDATE titleauthor SET au_ord = @OrdenAutor, royaltyper = @RoyalTyper, " +
                "title_id = @NuevoIdTitulo, au_id = @NuevoIdAutor WHERE au_id = @IdAutorRegistro AND title_id = @IdTituloRegistro";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(updateQuery, connection))
                {
                    // Agregar parámetros para los nuevos datos y el ID del registro
                    command.Parameters.AddWithValue("@IdAutorRegistro", idAutorRegistro);
                    command.Parameters.AddWithValue("@IdTituloRegistro", idTituloRegistro);
                    command.Parameters.AddWithValue("@OrdenAutor", OrdenAutor);
                    command.Parameters.AddWithValue("@RoyalTyper", Royaltyper);
                    command.Parameters.AddWithValue("@NuevoIdAutor", nuevoIdAutor);
                    command.Parameters.AddWithValue("@NuevoIdTitulo", nuevoIdTitulo);

                    try
                    {
                        // Abrir la conexión
                        connection.Open();

                        // Ejecutar la consulta de actualización
                        command.ExecuteNonQuery();
                    }
                    catch (Exception ex)
                    {
                        // Manejar cualquier error que ocurra durante la actualización
                        throw new Exception("Error al actualizar el registro: " + ex.Message);
                    }
                }
            }
        }
        #endregion


        //------------ BOOKSTOCK -----------------
        #region Alta BookStock
        public void AltaBookStock(string IdTienda, string IdTitulo, int Cantidad)
        {
            if (LibroExistenteEnTienda(IdTienda, IdTitulo))
            {
                // Si el libro ya existe en la tienda, mostrar un mensaje y salir del método
                MessageBox.Show("El libro ya existe en esta tienda.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // Si el libro no existe en la tienda, proceder con la inserción
            //Obtenemos la cadena de conexión de nuestra base de datos
            string conectionString;
            conectionString = Conexion();

            //Generamos la conexión
            using (SqlConnection connection = new SqlConnection(conectionString))
            {
                try
                {
                    //Abrimos la conexión
                    connection.Open();
                    //Indicamos el comando que se va a ejecutar en este caso un stored prodcedure
                    SqlCommand command = new SqlCommand("spi_AltaBookStock", connection);
                    //Le indicamos que tipo de componente es
                    command.CommandType = CommandType.StoredProcedure;

                    //Le mandamos las variables ingresadas en los texbox
                    command.Parameters.AddWithValue("@IdTienda", IdTienda);
                    command.Parameters.AddWithValue("@IdTitulo", IdTitulo);
                    command.Parameters.AddWithValue("@Cantidad", Cantidad);

                    //Ejecutamos el componente "Similar a EXEC en SQL"
                    command.ExecuteNonQuery();
                    connection.Close();
                }
                catch (SqlException ex)
                {
                    // Manejar específicamente errores de SQL Server
                    Console.WriteLine("Error al ejecutar el stored procedure: " + ex.Message);
                    throw; // Relanzar la excepción para que pueda ser capturada en el bloque catch de tu código de presentación
                }
                catch (Exception ex)
                {
                    // Otros tipos de errores
                    Console.WriteLine("Error al ejecutar el stored procedure: " + ex.Message);
                    throw; // Relanzar la excepción para que pueda ser capturada en el bloque catch de tu código de presentación
                }
                finally
                {
                    connection.Close(); // Asegúrate de cerrar la conexión
                }
            }
        }
        #endregion

        #region Eliminar Stock
        public void EliminarRegistroStock(string idTienda, string idLibro)
        {
            string conectionString;
            conectionString = Conexion();
            // Consulta SQL para eliminar el registro con el ID proporcionado
            string query = "DELETE FROM bookstock WHERE store_id = @IDTienda AND title_id = @IDLibro";

            using (SqlConnection connection = new SqlConnection(conectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    // Agregar parámetro para el ID
                    command.Parameters.AddWithValue("@IDTienda", idTienda);
                    command.Parameters.AddWithValue("@IDLibro", idLibro);

                    try
                    {
                        // Abrir la conexión
                        connection.Open();

                        // Ejecutar la consulta
                        command.ExecuteNonQuery();
                    }
                    catch (Exception ex)
                    {
                        // Manejar cualquier error
                        throw new Exception("Error al eliminar el registro: " + ex.Message);
                    }
                }
            }
        }
        #endregion

        //------------ USUARIOS -----------------
        #region Alta Usuarios
        public void AltaUsuarios(string NombreUsuario, string ContraseñaUsuario, bool EsAdministrador)
        {
            //Obtenemos la cadena de conexión de nuestra base de datos
            string conectionString;
            conectionString = Conexion();

            //Generamos la conexión
            using (SqlConnection connection = new SqlConnection(conectionString))
            {
                try
                {
                    //Abrimos la conexión
                    connection.Open();
                    //Indicamos el comando que se va a ejecutar en este caso un stored prodcedure
                    SqlCommand command = new SqlCommand("spi_AltaUsuarios", connection);
                    //Le indicamos que tipo de componente es
                    command.CommandType = CommandType.StoredProcedure;

                    //Le mandamos las variables ingresadas en los texbox
                    command.Parameters.AddWithValue("@NombreUsuario", NombreUsuario);
                    command.Parameters.AddWithValue("@ContraseñaUsuario", ContraseñaUsuario);
                    command.Parameters.AddWithValue("@EsAdministrador", EsAdministrador);

                    //Ejecutamos el componente "Similar a EXEC en SQL"
                    command.ExecuteNonQuery();
                    connection.Close();
                }
                catch (SqlException ex)
                {
                    // Manejar específicamente errores de SQL Server
                    Console.WriteLine("Error al ejecutar el stored procedure: " + ex.Message);
                    throw; // Relanzar la excepción para que pueda ser capturada en el bloque catch de tu código de presentación
                }
                catch (Exception ex)
                {
                    // Otros tipos de errores
                    Console.WriteLine("Error al ejecutar el stored procedure: " + ex.Message);
                    throw; // Relanzar la excepción para que pueda ser capturada en el bloque catch de tu código de presentación
                }
                finally
                {
                    connection.Close(); // Asegúrate de cerrar la conexión
                }
            }
        }
        #endregion

        #region Eliminar Usuario
        public void EliminarRegistroUsuario(string idUsuario)
        {
            string conectionString;
            conectionString = Conexion();
            // Consulta SQL para eliminar el registro con el ID proporcionado
            string query = "DELETE FROM Usuarios WHERE idUsuario = @IDUsuario";

            using (SqlConnection connection = new SqlConnection(conectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    // Agregar parámetro para el ID
                    command.Parameters.AddWithValue("@IDUsuario", idUsuario);

                    try
                    {
                        // Abrir la conexión
                        connection.Open();

                        // Ejecutar la consulta
                        command.ExecuteNonQuery();
                    }
                    catch (Exception ex)
                    {
                        // Manejar cualquier error
                        throw new Exception("Error al eliminar el registro: " + ex.Message);
                    }
                }
            }
        }
        #endregion

        #region Actualizar Usuario
        public void ActualizarUsuario(string idRegistro, string NombreUsuario, string ContraseñaUsuario, bool EsAdministrador)
        {
            string connectionString;
            connectionString = Conexion();

            // Consulta SQL para actualizar el registro en la base de datos
            string updateQuery = "UPDATE Usuarios SET nombreUsuario = @NombreUsuario," +
                "contraseñaUsuario = @ContraseñaUsuario, esAdministrador = @EsAdministrador WHERE idUsuario = @IdRegistro";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(updateQuery, connection))
                {
                    // Agregar parámetros para los nuevos datos y el ID del registro
                    command.Parameters.AddWithValue("@NombreUsuario", NombreUsuario);
                    command.Parameters.AddWithValue("@ContraseñaUsuario", ContraseñaUsuario);
                    command.Parameters.AddWithValue("@EsAdministrador", EsAdministrador);
                    command.Parameters.AddWithValue("@IdRegistro", idRegistro);

                    try
                    {
                        // Abrir la conexión
                        connection.Open();

                        // Ejecutar la consulta de actualización
                        command.ExecuteNonQuery();
                    }
                    catch (Exception ex)
                    {
                        // Manejar cualquier error que ocurra durante la actualización
                        throw new Exception("Error al actualizar el registro: " + ex.Message);
                    }
                }
            }
        }
        #endregion
    }
}
