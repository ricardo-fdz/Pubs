using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaNegocio;

namespace Pubs
{
    public partial class frmTitulos : Form
    {
        frmMenu menu;
        frmAltaTitulos altaTitulos;
        public frmTitulos()
        {
            InitializeComponent();
        }

        private void frmTitulos_Load(object sender, EventArgs e)
        {
            ActualizarDataGridView();
        }
        public void ActualizarDataGridView()
        {
            N_Titulos n_Titulos = new N_Titulos();
            try
            {
                dgvTitulos.DataSource = n_Titulos.ObtenerTitluos();//datos.VistaTitulos();
                LlenarTitulo();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            menu = new frmMenu();
            menu.Show();
            this.Close();
        }

        private void btnAltaTitulo_Click(object sender, EventArgs e)
        {
            altaTitulos = new frmAltaTitulos();
            altaTitulos.Show();
            this.Hide();
        }

        private void btnEliminarTitulo_Click(object sender, EventArgs e)
        {
            DatosPubs datos = new DatosPubs();
            // Verificar si hay una fila seleccionada en el DataGridView
            if (dgvTitulos.SelectedRows.Count > 0)
            {
                // Obtener el valor del ID de la fila seleccionada
                string idTituloSeleccionado = dgvTitulos.SelectedRows[0].Cells["ID Titulo"].Value.ToString();

                // Confirmar con el usuario antes de eliminar
                DialogResult result = MessageBox.Show("¿Estás seguro de que deseas eliminar el registro de titulo con ID " + idTituloSeleccionado + "? Toma en cuenta que el registro se borrará en otros espacios donde también se usaba ",
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
                        datos.EliminarRegistroTitulo(idTituloSeleccionado);

                        // Actualizar el DataGridView después de la eliminación
                        try
                        {

                            dgvTitulos.DataSource = datos.VistaTitulos();
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
            cbxFiltrarNombre.SelectedIndex = selectedIndex;

            if (!string.IsNullOrEmpty(idSeleccionado))
            {

                try
                {
                    // Filtrar los datos del stock basados en el ID de la tienda seleccionada
                    dgvTitulos.DataSource = datos.VistaTitulos2(idSeleccionado);
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
                dgvTitulos.DataSource = datos.VistaTitulos();
            }
        }

        private void LlenarTitulo()
        {
            DataTable data = new DataTable();
            DatosPubs datos = new DatosPubs();

            data = datos.ObtenerTitulos();

            foreach (DataRow row in data.Rows)
            {
                cbxFiltrarId.Items.Add(row["title_id"].ToString());
                cbxFiltrarNombre.Items.Add(row["title"].ToString());
            }
        }

        private void cbxFiltrarNombre_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedIndex = cbxFiltrarNombre.SelectedIndex;
            cbxFiltrarId.SelectedIndex = selectedIndex;
        }

        private void btnModificarTitulo_Click(object sender, EventArgs e)
        {
            if (dgvTitulos.SelectedRows.Count > 0)
            {
                // Obtener los datos de la fila seleccionada
                DataGridViewRow filaSeleccionada = dgvTitulos.CurrentRow;

                // Obtener los valores de las celdas de la fila seleccionada
                string valorColumna1 = filaSeleccionada.Cells[0].Value.ToString();
                string valorColumna2 = filaSeleccionada.Cells[1].Value.ToString();
                string valorColumna3 = filaSeleccionada.Cells[2].Value.ToString();
                string valorColumna4 = filaSeleccionada.Cells[3].Value.ToString();
                decimal valorColumna5 = decimal.Parse(filaSeleccionada.Cells[4].Value.ToString());
                decimal valorColumna6 = decimal.Parse(filaSeleccionada.Cells[5].Value.ToString());
                int valorColumna7 = int.Parse(filaSeleccionada.Cells[6].Value.ToString());
                int valorColumna8 = int.Parse(filaSeleccionada.Cells[7].Value.ToString());
                string valorColumna9 = filaSeleccionada.Cells[8].Value.ToString();
                DateTime valorColumna10 = DateTime.Parse(filaSeleccionada.Cells[9].Value.ToString());

                // Crear una instancia del formulario de modificación y pasar los datos a él
                frmModificarTitulos modificarTitulos = new frmModificarTitulos(valorColumna1, valorColumna2, valorColumna3, valorColumna4,
                    valorColumna5, valorColumna6, valorColumna7, valorColumna8, valorColumna9, valorColumna10);
                modificarTitulos.Owner = this;
                modificarTitulos.ShowDialog();
            }
            else
            {
                MessageBox.Show("Por favor, seleccione una fila para modificar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
