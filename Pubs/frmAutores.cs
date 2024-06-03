using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaEntidad;
using CapaNegocio;

namespace Pubs
{
    public partial class frmAutores : Form
    {
        frmMenu menu;
        frmAltaAutores altaautores;
        public frmAutores()
        {
            InitializeComponent();
        }

        private void frmAutores_Load(object sender, EventArgs e)
        {
            ActualizarDataGridView();
        }

        public void ActualizarDataGridView()
        {
            N_Autores n_VistaAutores = new N_Autores();
            try
            {
                dgvAutores.DataSource = n_VistaAutores.vistaAutores();
                dgvAutores.ReadOnly = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            Refresh();
            //LlenarAutor();
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            menu = new frmMenu();
            menu.Show();
            this.Close();
        }

        private void btnAlta_Click(object sender, EventArgs e)
        {
            altaautores = new frmAltaAutores();
            altaautores.Show();
            this.Hide();
        }

        private void btnEliminarAutor_Click(object sender, EventArgs e)
        {
            DatosPubs datos = new DatosPubs();
            // Verificar si hay una fila seleccionada en el DataGridView
            if (dgvAutores.SelectedRows.Count > 0)
            {
                // Obtener el valor del ID de la fila seleccionada
                string idAutorSeleccionado = dgvAutores.SelectedRows[0].Cells["ID Autor"].Value.ToString();

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
                        datos.EliminarRegistroAutor(idAutorSeleccionado);

                        // Actualizar el DataGridView después de la eliminación
                        try
                        {

                            dgvAutores.DataSource = datos.VistaAutores();
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

        private void cbxFiltrarId_SelectedIndexChanged(object sender, EventArgs e)
        {
            DatosPubs datos = new DatosPubs();
            string idAutorSeleccionado = cbxFiltrarId.SelectedItem?.ToString();
            int selectedIndex = cbxFiltrarId.SelectedIndex;
            cbxFiltrarNombre.SelectedIndex = selectedIndex;

            if (!string.IsNullOrEmpty(idAutorSeleccionado))
            {

                try
                {
                    // Filtrar los datos del stock basados en el ID de la tienda seleccionada
                    dgvAutores.DataSource = datos.VistaAutores2(idAutorSeleccionado);
                }
                catch (Exception ex)
                {
                    // Manejar la excepción adecuadamente, por ejemplo, mostrar un mensaje de error al usuario
                    MessageBox.Show("Error al cargar los datos del stock: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                // Si no se seleccionó ninguna tienda, mostrar todos los datos del stock
                dgvAutores.DataSource = datos.VistaAutores();
            }
        }

        private void cbxFiltrarNombre_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedIndex = cbxFiltrarNombre.SelectedIndex;
            cbxFiltrarId.SelectedIndex = selectedIndex;
        }

        private void btnModificarAutor_Click(object sender, EventArgs e)
        {
            if (dgvAutores.SelectedRows.Count > 0)
            {
                // Obtener los datos de la fila seleccionada
                DataGridViewRow filaSeleccionada = dgvAutores.CurrentRow;

                // Obtener los valores de las celdas de la fila seleccionada
                string valorColumna1 = filaSeleccionada.Cells["ID Autor"].Value.ToString();
                string valorColumna2 = filaSeleccionada.Cells["Apellido"].Value.ToString();
                string valorColumna3 = filaSeleccionada.Cells["Nombre"].Value.ToString();
                string valorColumna4 = filaSeleccionada.Cells["Teléfono"].Value.ToString();
                string valorColumna5 = filaSeleccionada.Cells["Dirección"].Value.ToString();
                string valorColumna6 = filaSeleccionada.Cells["Ciudad"].Value.ToString();
                string valorColumna7 = filaSeleccionada.Cells["Estado"].Value.ToString();
                string valorColumna8 = filaSeleccionada.Cells["Código Postal"].Value.ToString();
                object valorObjeto = filaSeleccionada.Cells["Contrato"].Value;
                bool valorColumna9;

                // Verificar si el valor de la celda no es nulo antes de intentar la conversión
                if (valorObjeto != null)
                {
                    // Intentar convertir el valor de la celda a bool
                    if (valorObjeto is bool)
                    {
                        // Si el valor es de tipo bool, asignarlo directamente
                        valorColumna9 = (bool)valorObjeto;
                    }
                    else
                    {
                        // Si no es de tipo bool, intentar convertirlo a string y luego a bool
                        if (bool.TryParse(valorObjeto.ToString(), out valorColumna9) == false)
                        {
                            // Si no se puede convertir, manejar el error o asignar un valor predeterminado
                            // Por ejemplo, puedes asignar false si el valor no es válido
                            valorColumna9 = false;
                        }
                    }
                }
                else
                {
                    // Manejar el caso en que el valor de la celda sea nulo
                    // Por ejemplo, asignar un valor predeterminado
                    valorColumna9 = false;
                }

                // Crear una instancia del formulario de modificación y pasar los datos a él
                frmModificarAutor modificarAutor = new frmModificarAutor(valorColumna1, valorColumna2, valorColumna3, valorColumna4,
                    valorColumna5, valorColumna6, valorColumna7, valorColumna8, valorColumna9);
                modificarAutor.Owner = this;
                modificarAutor.ShowDialog();
            }
            else
            {
                MessageBox.Show("Por favor, seleccione una fila para modificar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }


    }
}
