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
    public partial class frmModificarUsuario : Form
    {
        public frmModificarUsuario(string valorColumna1, string valorColumna2, string valorColumna3, bool valorColumna4)
        {
            InitializeComponent();
            txtNombre.Text = valorColumna2;
            txtIdUsuario.Text = valorColumna1;
            txtContraseña.Text = valorColumna3;
            cbEsAdministrador.Checked = valorColumna4;
        }

        public frmModificarUsuario()
        {
            InitializeComponent();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            DatosPubs datos = new DatosPubs();
            try
            {
                string nuevoIdUsuario = txtIdUsuario.Text;
                string nuevoNombre = txtNombre.Text;
                string nuevaContraseña = txtContraseña.Text;
                bool nuevoPermiso = bool.Parse(cbEsAdministrador.Checked.ToString());

                datos.ActualizarUsuario(nuevoIdUsuario, nuevoNombre, nuevaContraseña, nuevoPermiso);

                MessageBox.Show("Usuario modificado", "Informativo", MessageBoxButtons.OK);

                frmUsuarios parentForm = (frmUsuarios)this.Owner;
                parentForm.ActualizarDataGridView();

                // Cerrar el formulario de Modificación
                this.Close();

            }
            catch (Exception ex)
            {

                MessageBox.Show("Error al realizar la modificación: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
