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
    public partial class frmModificarVentas : Form
    {
        public frmModificarVentas(string valorColumna1, string valorColumna2, DateTime valorColumna3, short valorColumna4,
            string valorColumna5, string valorColumna6, string valorColumna7)
        {
            InitializeComponent();
            cbxIdTienda.Text = valorColumna1;
            txtOrden.Text = valorColumna2;
            dtpFechaOrden.Value = valorColumna3;
            nupCantidad.Value = valorColumna4;
            txtPayterms.Text = valorColumna5;
            cbxIdTitulo.Text = valorColumna6;
            cbxNombreTitulo.Text = valorColumna7;
        }
        public frmModificarVentas()
        {
            InitializeComponent();
        }

        private void frmModificarVentas_Load(object sender, EventArgs e)
        {
            LlenarTienda();
            LlenarTitulo();
        }

        private void LlenarTienda()
        {
            DataTable data = new DataTable();
            DatosPubs datos = new DatosPubs();

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

            data = datos.ObtenerTitulos();

            foreach (DataRow row in data.Rows)
            {
                cbxIdTitulo.Items.Add(row["title_id"].ToString());
                cbxNombreTitulo.Items.Add(row["title"].ToString());
            }
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            this.Close();
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

                // Asignar los valores obtenidos a los controles de texto
                txtAutor.Text = nombreAutor;
                dtpFechaPublicacion.Value = fechaPublicacion;
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

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            DatosPubs datos = new DatosPubs();
            try
            {
                string nuevoIdTienda = cbxIdTienda.Text;
                string nuevoNumeroOrden = txtOrden.Text;
                DateTime nuevaFechaOrden = dtpFechaOrden.Value;
                short nuevaCantidad = (short)nupCantidad.Value;
                string nuevoPayterms = txtPayterms.Text;
                string nuevoIdTitulo = cbxIdTitulo.Text;

                // Verificar si hay suficiente stock antes de realizar la venta
                int stockActual = datos.ObtenerStock(nuevoIdTienda, nuevoIdTitulo);
                if (stockActual < nuevaCantidad)
                {
                    MessageBox.Show("¡No hay suficiente stock para realizar o modificar esta venta!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return; // No continuar con la venta si no hay suficiente stock
                }

                // Realizar la venta
                datos.ActualizarVenta(nuevoNumeroOrden, nuevoIdTienda, nuevaFechaOrden, nuevaCantidad, nuevoPayterms, nuevoIdTitulo);

                MessageBox.Show("Venta modificada", "Informativo", MessageBoxButtons.OK);

                frmVentas parentForm = (frmVentas)this.Owner;
                parentForm.ActualizarDataGridView();

                // Cerrar el formulario de Modificación
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al realizar la modificación: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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
