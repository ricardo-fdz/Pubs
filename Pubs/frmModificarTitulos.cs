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
    public partial class frmModificarTitulos : Form
    {
        public frmModificarTitulos(string valorColumna1, string valorColumna2, string valorColumna3, string valorColumna4,
            decimal valorColumna5, decimal valorColumna6, int valorColumna7, int valorColumna8, string valorColumna9, DateTime valorColumna10)
        {
            InitializeComponent();
            txtId.Text = valorColumna1;
            txtNombre.Text = valorColumna2;
            txtTipo.Text = valorColumna3;
            cbIdPub.Text = valorColumna4;
            nupPrecio.Value = valorColumna5;
            nupAnticipo.Value = valorColumna6;
            nupRegalias.Value = valorColumna7;
            nupYtd.Value = valorColumna8;
            rtxtNotas.Text = valorColumna9;
            dtpPublicacion.Value = valorColumna10;
        }

        public frmModificarTitulos()
        {
            InitializeComponent();
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void LlenarPub()
        {
            DataTable data = new DataTable();
            DatosPubs datos = new DatosPubs();

            data = datos.ObtenerPub();

            foreach (DataRow row in data.Rows)
            {
                cbIdPub.Items.Add(row["pub_id"].ToString());
                cbPub.Items.Add(row["pub_name"].ToString());
            }
        }

        private void cbIdPub_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedIndex = cbIdPub.SelectedIndex;
            // Asignar el mismo índice seleccionado a cbPub
            cbPub.SelectedIndex = selectedIndex;
        }

        private void cbPub_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedIndex = cbPub.SelectedIndex;
            // Asignar el mismo índice seleccionado a cbPub
            cbIdPub.SelectedIndex = selectedIndex;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            DatosPubs datos = new DatosPubs();
            try
            {
                string nuevoId = txtId.Text;
                string nuevoNombre = txtNombre.Text;
                string nuevoTipo = txtTipo.Text;
                string nuevoIdPub = cbIdPub.Text;
                decimal nuevoPrecio = decimal.Parse(nupPrecio.Value.ToString());
                decimal nuevoAnticipo = decimal.Parse(nupAnticipo.Value.ToString());
                int nuevasRegalias = int.Parse(nupRegalias.Value.ToString());
                int nuevasVentasYTD = int.Parse(nupYtd.Value.ToString());
                string nuevasNotas = rtxtNotas.Text;
                DateTime nuevaFechaPublicacion = DateTime.Parse(dtpPublicacion.Text);

                datos.ActualizarTitulo(nuevoId, nuevoNombre, nuevoTipo, nuevoIdPub, nuevoPrecio, nuevoAnticipo, nuevasRegalias, nuevasVentasYTD, nuevasNotas, nuevaFechaPublicacion);

                MessageBox.Show("Titulo modificado", "Informativo", MessageBoxButtons.OK);

                frmTitulos parentForm = (frmTitulos)this.Owner;
                parentForm.ActualizarDataGridView();

                // Cerrar el formulario de Modificación
                this.Close();

            }
            catch (Exception ex)
            {

                MessageBox.Show("Error al realizar la modificación: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmModificarTitulos_Load(object sender, EventArgs e)
        {
            LlenarPub();
        }
    }
}
