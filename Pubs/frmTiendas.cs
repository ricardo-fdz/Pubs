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
    public partial class frmTiendas : Form
    {
        frmMenu menu;
        frmAltaTiendas altaTiendas;
        public frmTiendas()
        {
            InitializeComponent();
        }

        private void frmTiendas_Load(object sender, EventArgs e)
        {
            ActualizarDataGridView();
        }

        public void ActualizarDataGridView()
        {
            DatosPubs datos = new DatosPubs();

            try
            {

                dgvTiendas.DataSource = datos.VistaTiendas();


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            LlenarTienda();
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            menu = new frmMenu();
            menu.Show();
            this.Close();
        }

        private void btnAltaTiendas_Click(object sender, EventArgs e)
        {
            altaTiendas = new frmAltaTiendas();
            altaTiendas.Show();
            this.Hide();
        }

        private void btnEliminarTienda_Click(object sender, EventArgs e)
        {
            DatosPubs datos = new DatosPubs();
            // Verificar si hay una fila seleccionada en el DataGridView
            if (dgvTiendas.SelectedRows.Count > 0)
            {
                // Obtener el valor del ID de la fila seleccionada
                string idSeleccionado = dgvTiendas.SelectedRows[0].Cells["ID Tienda"].Value.ToString();

                // Confirmar con el usuario antes de eliminar
                DialogResult result = MessageBox.Show("¿Estás seguro de que deseas eliminar el registro de tienda con ID " + idSeleccionado + "? Toma en cuenta que el registro se borrará en otros espacios donde también se usaba ",
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
                        datos.EliminarRegistroTienda(idSeleccionado);

                        // Actualizar el DataGridView después de la eliminación
                        try
                        {
                            dgvTiendas.DataSource = datos.VistaTiendas();
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

            if (!string.IsNullOrEmpty(idSeleccionado))
            {

                try
                {
                    // Filtrar los datos del stock basados en el ID de la tienda seleccionada
                    dgvTiendas.DataSource = datos.VistaTiendas2(idSeleccionado);
                }
                catch (Exception ex)
                {
                    // Manejar la excepción adecuadamente, por ejemplo, mostrar un mensaje de error al usuario
                    MessageBox.Show("Error al cargar los datos de la tienda: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                // Si no se seleccionó ninguna tienda, mostrar todos los datos del stock
                dgvTiendas.DataSource = datos.VistaTiendas();
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
            }
        }

        private void btnModificarTienda_Click(object sender, EventArgs e)
        {
            if (dgvTiendas.SelectedRows.Count > 0)
            {
                // Obtener los datos de la fila seleccionada
                DataGridViewRow filaSeleccionada = dgvTiendas.CurrentRow;

                // Obtener los valores de las celdas de la fila seleccionada
                string valorColumna1 = filaSeleccionada.Cells["ID Tienda"].Value.ToString();
                string valorColumna2 = filaSeleccionada.Cells["Nombre Tienda"].Value.ToString();
                string valorColumna3 = filaSeleccionada.Cells["Dirección"].Value.ToString();
                string valorColumna4 = filaSeleccionada.Cells["Ciudad"].Value.ToString();
                string valorColumna5 = filaSeleccionada.Cells["Estado"].Value.ToString();
                string valorColumna6 = filaSeleccionada.Cells["Código Postal"].Value.ToString();

                // Crear una instancia del formulario de modificación y pasar los datos a él
                frmModificarTienda modificarTienda = new frmModificarTienda(valorColumna1, valorColumna2, valorColumna3, valorColumna4,
                    valorColumna5, valorColumna6);
                modificarTienda.Owner = this;
                modificarTienda.ShowDialog();
            }
            else
            {
                MessageBox.Show("Por favor, seleccione una fila para modificar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
