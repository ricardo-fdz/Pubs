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
    public partial class frmModificarAutor : Form
    {
        public frmModificarAutor()
        {
            InitializeComponent();
        }

        frmAutores autores = new frmAutores();
        public frmModificarAutor(string valorColumna1, string valorColumna2, string valorColumna3, string valorColumna4,
                    string valorColumna5, string valorColumna6, string valorColumna7, string valorColumna8, bool valorColumna9)
        {
            InitializeComponent();
            txtIdAutor.Text = valorColumna1;
            txtNombre.Text = valorColumna3;
            txtApellido.Text = valorColumna2;
            txtTelefono.Text = valorColumna4;
            txtDireccion.Text = valorColumna5;
            txtCiudad.Text = valorColumna6;
            cbEstado.Text = valorColumna7;
            txtCodigoPostal.Text = valorColumna8;
            chkbContrato.Checked = valorColumna9;
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            N_Autores n_Autores = new N_Autores();
            string Error;
            try
            {
                string nuevoId = txtIdAutor.Text;
                string nuevoNombre = txtNombre.Text;
                string nuevoApellido = txtApellido.Text;
                string nuevoTelefono = txtTelefono.Text;
                string nuevaDireccion = txtDireccion.Text;
                string nuevaCiudad = txtCiudad.Text;
                string nuevoEstado = cbEstado.Text;
                string nuevoCodigoPostal = txtCodigoPostal.Text;
                bool nuevoContrato = chkbContrato.Checked;
                // Y así sucesivamente para cada control

                // Llamar al método de actualización en tu clase de acceso a datos
                // Por ejemplo:
                Error = n_Autores.ActualizaAutor(txtIdAutor.Text, nuevoNombre, nuevoApellido, nuevoTelefono, nuevaDireccion, nuevaCiudad, nuevoEstado, nuevoCodigoPostal, nuevoContrato);

                if (Error == "1")
                {
                    MessageBox.Show("Autor modificado", "Informativo", MessageBoxButtons.OK);
                }
                else
                    MessageBox.Show("Servicio no disponible por el momento "+ Error, "Informativo", MessageBoxButtons.OK);

                frmAutores parentForm = (frmAutores)this.Owner;
                parentForm.ActualizarDataGridView();

                // Cerrar el formulario de Modificación
                this.Close();

            }
            catch (Exception ex)
            {

                MessageBox.Show("Error al realizar la modificación: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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

        private void frmModificarAutor_Load(object sender, EventArgs e)
        {
            LlenarEstados();
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
