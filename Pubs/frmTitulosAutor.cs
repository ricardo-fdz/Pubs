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
    public partial class frmTitulosAutor : Form
    {
        frmMenu menu;
        frmAltaTitulosAutor titulosAutor;
        public frmTitulosAutor()
        {
            InitializeComponent();
        }

        private void frmTitulosAutor_Load(object sender, EventArgs e)
        {
            ActualizarDataGridView();
        }

        public void ActualizarDataGridView()
        {
            DatosPubs datos = new DatosPubs();

            try
            {

                dgvTitulosAutor.DataSource = datos.VistaTitulosAutor();


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            LlenarAutor();
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            menu = new frmMenu();
            menu.Show();
            this.Close();
        }

        private void btnAltaTituloAutor_Click(object sender, EventArgs e)
        {
            titulosAutor = new frmAltaTitulosAutor();
            titulosAutor.Show();
            this.Hide();
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
                    dgvTitulosAutor.DataSource = datos.VistaTitulosAutor2(idSeleccionado);
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
                dgvTitulosAutor.DataSource = datos.VistaAutores();
            }
        }

        private void cbxFiltrarNombre_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedIndex = cbxFiltrarNombre.SelectedIndex;
            cbxFiltrarId.SelectedIndex = selectedIndex;
        }

        private void LlenarAutor()
        {
            DataTable data = new DataTable();
            DatosPubs datos = new DatosPubs();

            data = datos.ObtenerAutor();

            foreach (DataRow row in data.Rows)
            {
                cbxFiltrarId.Items.Add(row["au_id"].ToString());
                cbxFiltrarNombre.Items.Add(row["au_nombre"].ToString());
            }
        }

        private void btnEliminarTituloAutor_Click(object sender, EventArgs e)
        {
            DatosPubs datos = new DatosPubs();
            // Verificar si hay una fila seleccionada en el DataGridView
            if (dgvTitulosAutor.SelectedRows.Count > 0)
            {
                // Obtener el valor del ID de la fila seleccionada
                string idAutorSeleccionado = dgvTitulosAutor.SelectedRows[0].Cells["ID Autor"].Value.ToString();
                string idTituloSeleccionado = dgvTitulosAutor.SelectedRows[0].Cells["ID Titulo"].Value.ToString();

                // Confirmar con el usuario antes de eliminar
                DialogResult result = MessageBox.Show("¿Estás seguro de que deseas eliminar el registro de autor con ID " + idAutorSeleccionado + "? Toma en cuenta que el registro se borrará en otros espacios donde también se usaba ",
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
                        datos.EliminarRegistroTituloAutor(idAutorSeleccionado, idTituloSeleccionado);

                        // Actualizar el DataGridView después de la eliminación
                        try
                        {
                            dgvTitulosAutor.DataSource = datos.VistaTitulosAutor();
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

        private void btnModificarTituloAutor_Click(object sender, EventArgs e)
        {
            if (dgvTitulosAutor.SelectedRows.Count > 0)
            {
                // Obtener los datos de la fila seleccionada
                DataGridViewRow filaSeleccionada = dgvTitulosAutor.CurrentRow;

                // Obtener los valores de las celdas de la fila seleccionada
                string valorColumna1 = filaSeleccionada.Cells["ID Autor"].Value.ToString();
                string valorColumna2 = filaSeleccionada.Cells["ID Titulo"].Value.ToString();
                byte valorColumna3 = byte.Parse(filaSeleccionada.Cells["Orden Autor"].Value.ToString());
                int valorColumna4 = int.Parse(filaSeleccionada.Cells["Royaltyper"].Value.ToString());

                // Crear una instancia del formulario de modificación y pasar los datos a él
                frmModificarTitulosAutor modificarTitulosAutor = new frmModificarTitulosAutor(valorColumna1, valorColumna2, valorColumna3, valorColumna4);
                modificarTitulosAutor.Owner = this;
                modificarTitulosAutor.ShowDialog();
            }
            else
            {
                MessageBox.Show("Por favor, seleccione una fila para modificar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
