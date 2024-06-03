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
    public partial class frmUsuarios : Form
    {
        frmMenu menu;
        frmAltaUsuarios altaUsuarios;
        N_Usuarios n_usuarios = new N_Usuarios();
        
        public frmUsuarios()
        {
            InitializeComponent();
        }

        private void frmUsuarios_Load(object sender, EventArgs e)
        {
            ActualizarDataGridView();
        }

        public void ActualizarDataGridView()
        {
            try
            {
                dgvUsuarios.DataSource = n_usuarios.VistaUsuarios();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            //LlenarUsuario();
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            menu = new frmMenu();
            menu.Show();
            this.Close();
        }

        private void btnAltaUsuarios_Click(object sender, EventArgs e)
        {
            altaUsuarios = new frmAltaUsuarios();
            altaUsuarios.Show();
            this.Hide();
        }

        private void btnEliminarUsuario_Click(object sender, EventArgs e)
        {
            DatosPubs datos = new DatosPubs();
            // Verificar si hay una fila seleccionada en el DataGridView
            if (dgvUsuarios.SelectedRows.Count > 0)
            {
                // Obtener el valor del ID de la fila seleccionada
                string idSeleccionado = dgvUsuarios.SelectedRows[0].Cells["ID Usuario"].Value.ToString();

                // Confirmar con el usuario antes de eliminar
                DialogResult result = MessageBox.Show("¿Estás seguro de que deseas eliminar el registro de usuario con ID " + idSeleccionado + "? Toma en cuenta que el registro se borrará en otros espacios donde también se usaba ",
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
                        datos.EliminarRegistroUsuario(idSeleccionado);

                        // Actualizar el DataGridView después de la eliminación
                        try
                        {
                            dgvUsuarios.DataSource = datos.VistaUsuarios();
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

            if (!string.IsNullOrEmpty(idSeleccionado))
            {

                try
                {
                    // Filtrar los datos del stock basados en el ID de la tienda seleccionada
                    dgvUsuarios.DataSource = datos.VistaUsuarios2(idSeleccionado);
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
                dgvUsuarios.DataSource = datos.VistaUsuarios();
            }
        }

        private void LlenarUsuario()
        {
            DataTable data = new DataTable();
            DatosPubs datos = new DatosPubs();

            data = datos.ObtenerUsuarios();

            foreach (DataRow row in data.Rows)
            {
                cbxFiltrarId.Items.Add(row["idUsuario"].ToString());
            }
        }

        private void btnModificarUsuario_Click(object sender, EventArgs e)
        {
            if (dgvUsuarios.SelectedRows.Count > 0)
            {
                // Obtener los datos de la fila seleccionada
                DataGridViewRow filaSeleccionada = dgvUsuarios.CurrentRow;

                // Obtener los valores de las celdas de la fila seleccionada
                string valorColumna1 = filaSeleccionada.Cells["ID Usuario"].Value.ToString();
                string valorColumna2 = filaSeleccionada.Cells["Nombre Usuario"].Value.ToString();
                string valorColumna3 = filaSeleccionada.Cells["Contraseña Usuario"].Value.ToString();
                bool valorColumna4 = bool.Parse(filaSeleccionada.Cells["Administrador"].Value.ToString());

                // Crear una instancia del formulario de modificación y pasar los datos a él
                frmModificarUsuario modificarUsuario = new frmModificarUsuario(valorColumna1, valorColumna2, valorColumna3, valorColumna4);
                modificarUsuario.Owner = this;
                modificarUsuario.ShowDialog();
            }
            else
            {
                MessageBox.Show("Por favor, seleccione una fila para modificar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
