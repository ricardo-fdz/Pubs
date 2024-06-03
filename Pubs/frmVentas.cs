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
    public partial class frmVentas : Form
    {
        frmMenu menu;
        frmAltaVentas ventas;
        public frmVentas()
        {
            InitializeComponent();
        }

        private void frmVentas_Load(object sender, EventArgs e)
        {
            DatosPubs datos = new DatosPubs();

            try
            {

                dgvVentas.DataSource = datos.VistaVentas();


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            LlenarNumeroOrden();
            LlenarTienda();
        }
        public void ActualizarDataGridView()
        {
            DatosPubs datos = new DatosPubs();

            try
            {

                dgvVentas.DataSource = datos.VistaVentas();


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            LlenarNumeroOrden();
            LlenarTienda();
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            menu = new frmMenu();
            menu.Show();
            this.Close();
        }

        private void btnAltaVentas_Click(object sender, EventArgs e)
        {
            ventas = new frmAltaVentas();
            ventas.Show();
            this.Hide();
        }

        private void btnEliminarVenta_Click(object sender, EventArgs e)
        {
            DatosPubs datos = new DatosPubs();
            // Verificar si hay una fila seleccionada en el DataGridView
            if (dgvVentas.SelectedRows.Count > 0)
            {
                // Obtener el valor del ID de la fila seleccionada
                string idTiendaSeleccionado = dgvVentas.SelectedRows[0].Cells["ID Tienda"].Value.ToString();
                string idOrdenSeleccionada = dgvVentas.SelectedRows[0].Cells["Numero de Orden"].Value.ToString();

                // Confirmar con el usuario antes de eliminar
                DialogResult result = MessageBox.Show("¿Estás seguro de que deseas eliminar el registro de venta con número de orden " + idOrdenSeleccionada + "? Toma en cuenta que el registro se borrará en otros espacios donde también se usaba ",
                                                        "Confirmar Eliminación",
                                                        MessageBoxButtons.YesNo,
                                                        MessageBoxIcon.Question);

                // Si el usuario confirma la eliminación
                if (result == DialogResult.Yes)
                {
                    // Realizar la eliminación del registro utilizando el ID obtenido
                    try
                    {
                        // Llamar a un método en tu clase de acceso a datos para eliminar el registro por su ID
                        datos.EliminarRegistroVenta(idTiendaSeleccionado, idOrdenSeleccionada);

                        // Actualizar el DataGridView después de la eliminación
                        try
                        {
                            dgvVentas.DataSource = datos.VistaVentas();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.ToString());
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error al eliminar el registro: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Por favor, seleccione una fila para eliminar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void cbxFiltrarId_SelectedIndexChanged(object sender, EventArgs e)
        {
            DatosPubs datos = new DatosPubs();
            string idSeleccionado = cbxFiltrarId.SelectedItem?.ToString();
            int selectedIndex = cbxFiltrarId.SelectedIndex;
            cbxNombre.SelectedIndex = selectedIndex;

            if (!string.IsNullOrEmpty(idSeleccionado))
            {

                try
                {
                    // Filtrar los datos del stock basados en el ID de la tienda seleccionada
                    dgvVentas.DataSource = datos.VistaVentas2(idSeleccionado);
                }
                catch (Exception ex)
                {
                    // Manejar la excepción adecuadamente, por ejemplo, mostrar un mensaje de error al usuario
                    MessageBox.Show("Error al cargar los datos: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                // Si no se seleccionó ninguna tienda, mostrar todos los datos del stock
                dgvVentas.DataSource = datos.VistaVentas();
            }
        }

        private void LlenarTienda()
        {
            DataTable data = new DataTable();
            DatosPubs datos = new DatosPubs();

            data = datos.ObtenerTiendas();

            foreach (DataRow row in data.Rows)
            {
                cbxFiltrarId.Items.Add(row["stor_id"].ToString());
                cbxNombre.Items.Add(row["stor_name"].ToString());
            }
        }

        private void LlenarNumeroOrden()
        {
            DataTable data = new DataTable();
            DatosPubs datos = new DatosPubs();

            data = datos.ObtenerNumero();

            foreach (DataRow row in data.Rows)
            {
                cbxNumero.Items.Add(row["ord_num"].ToString());
            }
        }

        private void cbxNumero_SelectedIndexChanged(object sender, EventArgs e)
        {
            DatosPubs datos = new DatosPubs();
            string numeroSeleccionado = cbxNumero.SelectedItem?.ToString();

            if (!string.IsNullOrEmpty(numeroSeleccionado))
            {

                try
                {
                    // Filtrar los datos del stock basados en el ID de la tienda seleccionada
                    dgvVentas.DataSource = datos.VistaVentas3(numeroSeleccionado);
                }
                catch (Exception ex)
                {
                    // Manejar la excepción adecuadamente, por ejemplo, mostrar un mensaje de error al usuario
                    MessageBox.Show("Error al cargar los datos: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                // Si no se seleccionó ninguna tienda, mostrar todos los datos del stock
                dgvVentas.DataSource = datos.VistaVentas();
            }
        }

        private void cbxNombre_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedIndex = cbxNombre.SelectedIndex;
            cbxFiltrarId.SelectedIndex = selectedIndex;
        }

        private void btnModificarVenta_Click(object sender, EventArgs e)
        {
            if (dgvVentas.SelectedRows.Count > 0)
            {
                // Obtener los datos de la fila seleccionada
                DataGridViewRow filaSeleccionada = dgvVentas.CurrentRow;

                // Obtener los valores de las celdas de la fila seleccionada
                string valorColumna1 = filaSeleccionada.Cells["ID Tienda"].Value.ToString();
                string valorColumna2 = filaSeleccionada.Cells["Numero de Orden"].Value.ToString();
                DateTime valorColumna3 = DateTime.Parse(filaSeleccionada.Cells["Fecha de orden"].Value.ToString());
                short valorColumna4 = short.Parse(filaSeleccionada.Cells["Cantidad ventas"].Value.ToString());
                string valorColumna5 = filaSeleccionada.Cells["Payterms"].Value.ToString();
                string valorColumna6 = filaSeleccionada.Cells["ID Titulo"].Value.ToString();
                string valorColumna7 = filaSeleccionada.Cells["Título Libro"].Value.ToString();

                // Crear una instancia del formulario de modificación y pasar los datos a él
                frmModificarVentas modificarVentas = new frmModificarVentas(valorColumna1, valorColumna2, valorColumna3, valorColumna4, valorColumna5, valorColumna6, valorColumna7);
                modificarVentas.Owner = this;
                modificarVentas.ShowDialog();
            }
            else
            {
                MessageBox.Show("Por favor, seleccione una fila para modificar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
