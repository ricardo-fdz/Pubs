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
    public partial class frmAltaTitulosAutor : Form
    {
        frmTitulosAutor titulosAutor;
        public frmAltaTitulosAutor()
        {
            InitializeComponent();
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            titulosAutor = new frmTitulosAutor();
            titulosAutor.Show();
            this.Close();
        }

        private void LimpiarControles()
        {
            nupOrdenAutor.Value = 0;
            nupRoyalty.Value = 0;
            cbIdAutor.SelectedIndex = -1;
            cbNombreAutor.SelectedIndex = -1;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            DatosPubs datos = new DatosPubs();
            try
            {
                // Obtener los valores seleccionados en los ComboBox
                string au_id = cbIdAutor.SelectedItem.ToString();
                string title_id = cbxIdTitulo.SelectedItem.ToString();

                datos.AltaTitulosAutor(au_id, title_id, ((byte)nupOrdenAutor.Value), ((int)nupRoyalty.Value));

                MessageBox.Show("Título de Autor agregado", "Informativo", MessageBoxButtons.OK);

                // Limpiar los controles después de agregar el título
                LimpiarControles();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al agregar el título de autor: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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

        private void frmAltaTitulosAutor_Load(object sender, EventArgs e)
        {
            LlenarAutor();
            LlenarTitulo();
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
