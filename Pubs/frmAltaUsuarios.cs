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
    public partial class frmAltaUsuarios : Form
    {
        frmUsuarios usuarios;

        public frmAltaUsuarios()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            DatosPubs datos = new DatosPubs();
            try
            {

                datos.AltaUsuarios(txtNombre.Text, txtContraseña.Text, cbEsAdministrador.Checked);

                MessageBox.Show("Usuario agregado", "Informativo", MessageBoxButtons.OK);
                LimpiarControles();

            }

            catch (Exception ex)
            {

                MessageBox.Show("Error al agregar usuario: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LimpiarControles()
        {
            txtNombre.Clear();
            txtContraseña.Clear();
            cbEsAdministrador.Checked = false;
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            usuarios = new frmUsuarios();
            usuarios.Show();
            this.Close();
        }
    }
}
