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
    public partial class frmAltaTitulos : Form
    {
        frmTitulos titulos;
        public frmAltaTitulos()
        {
            InitializeComponent();
        }

        private void frmAltaTitulos_Load(object sender, EventArgs e)
        {
            LlenarPub();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            N_Titulos n_Titulos = new N_Titulos();
            string Error;
            try
            {
                // Obtener los valores seleccionados en los ComboBox
                string pub_id = cbIdPub.SelectedItem.ToString();
                string pub_name = cbPub.SelectedItem.ToString();

               Error = n_Titulos.AltaTitulo(txtId.Text, txtNombre.Text, txtTipo.Text, pub_id, nupPrecio.Value,
                                    nupAnticipo.Value, ((int)nupRegalias.Value), ((int)nupYtd.Value),
                                    rtxtNotas.Text, dtpPublicacion.Value);

                if (Error == "1")
                {
                    MessageBox.Show("Título agregado", "Informativo", MessageBoxButtons.OK);

                    // Limpiar los controles después de agregar el título
                    LimpiarControles();
                }
                else if (Error == "0")
                {
                    MessageBox.Show("No se actualizaron Datos", "Informativo", MessageBoxButtons.OK);
                }
                else
                    MessageBox.Show("Servicio no disponible "+ Error , "Error", MessageBoxButtons.OK);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al agregar el título: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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

        private void LimpiarControles()
        {
            txtId.Clear();
            txtNombre.Clear();
            txtTipo.Clear();
            cbIdPub.SelectedIndex = -1;
            cbPub.SelectedIndex = -1;
            nupPrecio.Value = 0;
            nupAnticipo.Value = 0;
            nupRegalias.Value = 0;
            nupYtd.Value = 0;
            rtxtNotas.Clear();
            dtpPublicacion.Value = DateTime.Today;
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            titulos = new frmTitulos();
            titulos.Show();
            this.Close();
        }

        private void cbPub_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedIndex = cbPub.SelectedIndex;
            // Asignar el mismo índice seleccionado a cbPub
            cbIdPub.SelectedIndex = selectedIndex;
        }
    }
}
