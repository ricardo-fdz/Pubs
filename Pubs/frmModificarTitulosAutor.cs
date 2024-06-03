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
    public partial class frmModificarTitulosAutor : Form
    {
        public frmModificarTitulosAutor(string valorColumna1, string valorColumna2, byte valorColumna3, int valorColumna4)
        {
            InitializeComponent();
            cbIdAutor.Text = valorColumna1;
            cbxIdTitulo.Text = valorColumna2;
            nupOrdenAutor.Value = valorColumna3;
            nupRoyalty.Value = valorColumna4;
        }
        public frmModificarTitulosAutor()
        {
            InitializeComponent();
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void LlenarAutor()
        {
            DataTable data = new DataTable();
            DatosPubs datos = new DatosPubs();

            data = datos.ObtenerAutor();

            foreach (DataRow row in data.Rows)
            {
                cbIdAutor.Items.Add(row["au_id"].ToString());
                cbNombreAutor.Items.Add(row["au_nombre"].ToString());
            }
        }
        private void LlenarTitulo()
        {
            DataTable data = new DataTable();
            DatosPubs datos = new DatosPubs();

            data = datos.ObtenerTitulos();

            foreach (DataRow row in data.Rows)
            {
                cbxIdTitulo.Items.Add(row["title_id"].ToString());
                cbxTitulo.Items.Add(row["title"].ToString());
            }
        }

        private void frmModificarTitulosAutor_Load(object sender, EventArgs e)
        {
            LlenarAutor();
            LlenarTitulo();
        }

        private void cbxIdTitulo_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedIndex = cbxIdTitulo.SelectedIndex;
            cbxTitulo.SelectedIndex = selectedIndex;
        }

        private void cbxTitulo_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedIndex = cbxTitulo.SelectedIndex;
            cbxIdTitulo.SelectedIndex = selectedIndex;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            DatosPubs datos = new DatosPubs();
            try
            {
                string nuevoIdAutor = cbIdAutor.Text;
                string nuevoIdTitulo = cbxIdTitulo.Text;
                byte nuevaOrdenAutor = byte.Parse(nupOrdenAutor.Value.ToString());
                int nuevaRoyalty = int.Parse(nupRoyalty.Value.ToString());

                datos.ActualizarTituloAutor(nuevoIdAutor, nuevoIdTitulo, nuevaOrdenAutor, nuevaRoyalty, nuevoIdAutor, nuevoIdTitulo);

                MessageBox.Show("Titulo de Autor modificado", "Informativo", MessageBoxButtons.OK);

                frmTitulosAutor parentForm = (frmTitulosAutor)this.Owner;
                parentForm.ActualizarDataGridView();

                // Cerrar el formulario de Modificación
                this.Close();

            }
            catch (Exception ex)
            {

                MessageBox.Show("Error al realizar la modificación: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cbIdAutor_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedIndex = cbIdAutor.SelectedIndex;
            cbNombreAutor.SelectedIndex = selectedIndex;
        }

        private void cbNombreAutor_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedIndex = cbNombreAutor.SelectedIndex;
            cbIdAutor.SelectedIndex = selectedIndex;
        }
    }
}
