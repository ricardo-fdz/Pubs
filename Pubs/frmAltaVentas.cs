using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pubs
{
    public partial class frmAltaVentas : Form
    {
        frmVentas ventas;
        public frmAltaVentas()
        {
            InitializeComponent();
        }

        public void EsAdmin(bool admn)
        {
            btnRegresar.Visible = admn;
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            ventas = new frmVentas();
            ventas.Show();
            this.Close();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            DatosPubs datos = new DatosPubs();
            string[] valores;
            string descuentoSinPorcentaje;
            string[] partesDescuento;
            string valorDescuento;
            double descuento;

            try
            {
                // Obtener los valores seleccionados en los ComboBox
                // Obtener los valores seleccionados en los ComboBox
                string stor_id = cbxIdTienda.SelectedItem.ToString();
                string stor_name = cbxNombreTienda.SelectedItem.ToString();
                string title_id = cbxIdTitulo.SelectedItem.ToString();
                string title = cbxNombreTitulo.SelectedItem.ToString();
                if (cbxDescuento.SelectedIndex != 0)
                {
                    valores = cbxDescuento.SelectedItem.ToString().Split('-');
                    descuentoSinPorcentaje = valores[1].Trim(); // Eliminar espacios en blanco antes de dividir
                    partesDescuento = descuentoSinPorcentaje.Split('%');
                    valorDescuento = partesDescuento[0].Trim(); // Obtener solo el valor numérico del descuento
                    descuento = Convert.ToDouble(valorDescuento);
                }
                else
                    descuento = 0;

                // Intentar realizar la venta
                bool ventaRealizada = datos.AltaVentas(stor_id, txtOrden.Text, dtpFechaOrden.Value, ((short)nupCantidad.Value), txtPayterms.Text, title_id);

                if (ventaRealizada)
                {
                    // Si la venta se realizó correctamente, mostramos el mensaje de venta realizada
                    MessageBox.Show("Venta realizada", "Informativo", MessageBoxButtons.OK);
                    // Mostrar el diálogo de guardado de archivos
                    
                    // Limpiar los controles después de agregar el título
                    LimpiarControles();
                }
            }
            catch (Exception ex)
            {
                // Si ocurre un error al realizar la venta, se mostrará el mensaje de error
                MessageBox.Show("Error al realizar la venta: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void LimpiarControles()
        {
            cbxIdTienda.SelectedIndex = 0;
            cbxIdTitulo.SelectedIndex = 0;
            cbxNombreTienda.SelectedIndex = 0;
            cbxNombreTitulo.SelectedIndex = 0;
            txtOrden.Clear();
            txtPrecioU.Clear();
            nupCantidad.Value = 0;
            txtAutor.Clear();
            if (cbxDescuento.SelectedIndex != 0)
            {
                cbxDescuento.SelectedIndex = -1;
            }
            dtpFechaOrden.Value = DateTime.Today;
            txtPayterms.Clear();
        }

        private void LlenarTienda()
        {
            DataTable data = new DataTable();
            DatosPubs datos = new DatosPubs();

            cbxIdTienda.Items.Add("Seleccionar");
            cbxNombreTienda.Items.Add("Seleccionar");

            cbxIdTienda.SelectedIndex = 0;
            cbxNombreTienda.SelectedIndex = 0;

            data = datos.ObtenerTiendas();

            foreach (DataRow row in data.Rows)
            {
                cbxIdTienda.Items.Add(row["stor_id"].ToString());
                cbxNombreTienda.Items.Add(row["stor_name"].ToString());
            }
        }

        private void LlenarTitulo()
        {
            DataTable data = new DataTable();
            DatosPubs datos = new DatosPubs();

            cbxIdTitulo.Items.Add("Seleccionar");
            cbxNombreTitulo.Items.Add("Seleccionar");
            cbxIdTitulo.SelectedIndex = 0;

            data = datos.ObtenerTitulos();

            foreach (DataRow row in data.Rows)
            {
                cbxIdTitulo.Items.Add(row["title_id"].ToString());
                cbxNombreTitulo.Items.Add(row["title"].ToString());
            }
        }

        private void cbxIdTienda_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedIndex = cbxIdTienda.SelectedIndex;
            cbxNombreTienda.SelectedIndex = selectedIndex;
        }

        private void cbxNombreTienda_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedIndex = cbxNombreTienda.SelectedIndex;
            cbxIdTienda.SelectedIndex = selectedIndex;
        }

        private void cbxIdTitulo_SelectedIndexChanged(object sender, EventArgs e)
        {
            DatosPubs datos = new DatosPubs();
            int selectedIndex = cbxIdTitulo.SelectedIndex;
            cbxNombreTitulo.SelectedIndex = selectedIndex;
            string idTituloSeleccionado = cbxIdTitulo.SelectedItem.ToString(); // Obtener el ID del libro seleccionado en el combobox

            // Obtener la información del libro utilizando el método ObtenerInformacionLibro
            DataTable libroInfo = datos.ObtenerInformacionLibro(idTituloSeleccionado);

            // Filtrar el DataTable para obtener la información del libro seleccionado
            DataRow[] libroSeleccionado = libroInfo.Select($"title_id = '{idTituloSeleccionado}'");

            // Verificar si se encontró información para el libro seleccionado
            if (libroSeleccionado.Length > 0)
            {
                // Obtener el nombre del autor y la fecha de publicación del libro seleccionado
                string nombreAutor = libroSeleccionado[0]["emp_nombre"].ToString();
                DateTime fechaPublicacion = Convert.ToDateTime(libroSeleccionado[0]["pubdate"]);
                double Precio = Convert.ToDouble(libroSeleccionado[0]["price"]);
                // Asignar los valores obtenidos a los controles de texto
                txtAutor.Text = nombreAutor;
                dtpFechaPublicacion.Value = fechaPublicacion;
                txtPrecioU.Text = Precio.ToString();
            }
            else
            {
                // Limpiar los controles de texto si no se encontró información para el libro seleccionado
                txtAutor.Clear();
                dtpFechaPublicacion.Value = DateTime.Now; // Asignar la fecha actual por defecto
            }
        }

        private void cbxNombreTitulo_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedIndex = cbxNombreTitulo.SelectedIndex;
            cbxIdTitulo.SelectedIndex = selectedIndex;
        }

        private void frmAltaVentas_Load(object sender, EventArgs e)
        {
            cbxDescuento.Items.Add("Seleccionar");
            cbxDescuento.SelectedIndex = 0;
            LlenarTienda();
            LlenarTitulo();
        }

        private void nupCantidad_ValueChanged(object sender, EventArgs e)
        {
            CargarDescuentos();
        }

        private void CargarDescuentos()
        {
            // Limpiar ComboBox antes de cargar nuevos descuentos
            cbxDescuento.Items.Clear();
            DatosPubs datos = new DatosPubs();
            try
            {
                // Obtener cantidad ingresada desde el control nupCantidad
                int cantidad = Convert.ToInt32(nupCantidad.Value);

                // Llamar al método de la clase de consultas SQL para obtener los descuentos
                var descuentos = datos.ObtenerDescuentos(cantidad);

                // Agregar descuentos al ComboBox
                foreach (string descuento in descuentos)
                {
                    cbxDescuento.Items.Add(descuento);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar descuentos: " + ex.Message);
            }
        }
    }
}
