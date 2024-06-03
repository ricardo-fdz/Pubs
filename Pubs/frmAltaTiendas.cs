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
    public partial class frmAltaTiendas : Form
    {
        frmTiendas tiendas;
        public frmAltaTiendas()
        {
            InitializeComponent();
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            tiendas = new frmTiendas();
            tiendas.Show();
            this.Close();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            DatosPubs datos = new DatosPubs();
            try
            {

                datos.AltaTiendas(txtIdTienda.Text, txtNombre.Text, txtDireccion.Text, txtCiudad.Text, cbEstado.SelectedItem.ToString(),
                                    txtCodigoPostal.Text);

                MessageBox.Show("Tienda agregada", "Informativo", MessageBoxButtons.OK);
                LimpiarControles();

            }
            catch (Exception ex)
            {

                MessageBox.Show("Error al agregar tienda: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LimpiarControles()
        {
            txtIdTienda.Clear();
            txtNombre.Clear();
            txtDireccion.Clear();
            txtCiudad.Clear();
            txtCodigoPostal.Clear();
            cbEstado.SelectedIndex = -1;
        }

        private void LlenarEstados()
        {
            DataTable data = new DataTable();
            DatosPubs datos = new DatosPubs();

            data = datos.ObtenerEstados();

            foreach (DataRow item in data.Rows)
            {
                cbEstado.Items.Add(item[0].ToString());
            }
        }

        private void frmAltaTiendas_Load(object sender, EventArgs e)
        {
            LlenarEstados();
        }
    }
}
