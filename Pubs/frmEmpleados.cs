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
    public partial class frmEmpleados : Form
    {
        frmMenu menu;
        frmAltaEmpleados empleados;
        public frmEmpleados()
        {
            InitializeComponent();
        }

        public void ActualizarDataGridView()
        {
            DatosPubs datos = new DatosPubs();
            try
            {
                dgvEmpleados.DataSource = datos.VistaEmpleados();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            Refresh();
            LlenarEmpleado();
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            menu = new frmMenu();
            menu.Show();
            this.Close();
        }

        private void btnAltaEmpleados_Click(object sender, EventArgs e)
        {
            empleados = new frmAltaEmpleados();
            empleados.Show();
            this.Hide();
        }

        private void btnModificarEmpleado_Click(object sender, EventArgs e)
        {
            if (dgvEmpleados.SelectedRows.Count > 0)
            {
                // Obtener los datos de la fila seleccionada
                DataGridViewRow filaSeleccionada = dgvEmpleados.CurrentRow;

                // Obtener los valores de las celdas de la fila seleccionada
                string valorColumna1 = filaSeleccionada.Cells["ID Empleado"].Value.ToString();
                string valorColumna2 = filaSeleccionada.Cells["Nombre"].Value.ToString();
                string valorColumna3 = filaSeleccionada.Cells["Inicial"].Value.ToString();
                string valorColumna4 = filaSeleccionada.Cells["Apellido"].Value.ToString();
                string valorColumna5 = filaSeleccionada.Cells["ID Trabajo"].Value.ToString();
                string valorColumna6 = filaSeleccionada.Cells["Nivel Trabajador"].Value.ToString();
                string valorColumna7 = filaSeleccionada.Cells["ID Editorial"].Value.ToString();
                DateTime valorColumna8 = DateTime.Parse(filaSeleccionada.Cells["Fecha contratación"].Value.ToString());

                // Crear una instancia del formulario de modificación y pasar los datos a él
                frmModificarEmpleados modificarEmpleados = new frmModificarEmpleados(valorColumna1, valorColumna2, valorColumna3, valorColumna4,
                    valorColumna5, valorColumna6, valorColumna7, valorColumna8);
                modificarEmpleados.Owner = this;
                modificarEmpleados.ShowDialog();
            }
            else
            {
                MessageBox.Show("Por favor, seleccione una fila para modificar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                    dgvEmpleados.DataSource = datos.VistaEmpleados2(idSeleccionado);
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
                dgvEmpleados.DataSource = datos.VistaEmpleados();
            }
        }

        private void cbxFiltrarNombre_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedIndex = cbxFiltrarNombre.SelectedIndex;
            cbxFiltrarId.SelectedIndex = selectedIndex;
        }
        private void LlenarEmpleado()
        {
            DataTable data = new DataTable();
            DatosPubs datos = new DatosPubs();

            data = datos.ObtenerEmpleados();

            foreach (DataRow row in data.Rows)
            {
                cbxFiltrarId.Items.Add(row["emp_id"].ToString());
                cbxFiltrarNombre.Items.Add(row["emp_nombre"].ToString());
            }
        }

        private void btnEliminarEmpleado_Click(object sender, EventArgs e)
        {
            DatosPubs datos = new DatosPubs();
            // Verificar si hay una fila seleccionada en el DataGridView
            if (dgvEmpleados.SelectedRows.Count > 0)
            {
                // Obtener el valor del ID de la fila seleccionada
                string idSeleccionado = dgvEmpleados.SelectedRows[0].Cells["ID Empleado"].Value.ToString();

                // Confirmar con el usuario antes de eliminar
                DialogResult result = MessageBox.Show("¿Estás seguro de que deseas eliminar el registro de empleado con ID " + idSeleccionado + "? Toma en cuenta que el registro se borrará en otros espacios donde también se usaba ",
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
                        datos.EliminarRegistroEmpleado(idSeleccionado);

                        // Actualizar el DataGridView después de la eliminación
                        try
                        {
                            dgvEmpleados.DataSource = datos.VistaEmpleados();
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
    }
}
