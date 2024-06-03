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
    public partial class frmModificarTienda : Form
    {
        public frmModificarTienda()
        {
            InitializeComponent();
        }
        public frmModificarTienda(string valorColumna1, string valorColumna2, string valorColumna3, string valorColumna4, string valorColumna5, string valorColumna6)
        {
            InitializeComponent();
            txtIdTienda.Text = valorColumna1;
            txtNombre.Text = valorColumna2;
            txtDireccion.Text = valorColumna3;
            txtCiudad.Text = valorColumna4;
            cbEstado.Text = valorColumna5;
            txtCodigoPostal.Text = valorColumna6;
        }

        private void frmModificarTienda_Load(object sender, EventArgs e)
        {
            LlenarEstados();
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

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            DatosPubs datos = new DatosPubs();
            try
            {
                string nuevoId = txtIdTienda.Text;
                string nuevoNombre = txtNombre.Text;
                string nuevaDireccion = txtDireccion.Text;
                string nuevaCiudad = txtCiudad.Text;
                string nuevoEstado = cbEstado.Text;
                string nuevoCodigoPostal = txtCodigoPostal.Text;

                datos.ActualizarTienda(nuevoId, nuevoNombre, nuevaDireccion, nuevaCiudad, nuevoEstado, nuevoCodigoPostal);

                MessageBox.Show("Tienda modificada", "Informativo", MessageBoxButtons.OK);

                frmTiendas parentForm = (frmTiendas)this.Owner;
                parentForm.ActualizarDataGridView();

                // Cerrar el formulario de Modificación
                this.Close();

            }
            catch (Exception ex)
            {

                MessageBox.Show("Error al realizar la modificación: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
