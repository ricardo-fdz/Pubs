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
    public partial class frmModificarStock : Form
    {
        frmStock stock;
        public frmModificarStock()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            DatosPubs datos = new DatosPubs();
            try
            {
                // Obtener los valores seleccionados en los ComboBox
                string title_id = cbxIdTitulo.SelectedItem.ToString();
                string stor_id = cbxIdTienda.SelectedItem.ToString();

                datos.ActualizarBookStock(stor_id, title_id, ((int)nupCantidad.Value));

                MessageBox.Show("Stock actualizado", "Informativo", MessageBoxButtons.OK);

                // Limpiar los controles después de actualizar el stock
                LimpiarControles();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al actualizar el stock: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LimpiarControles()
        {
            cbxIdTienda.SelectedIndex = -1;
            cbxIdTitulo.SelectedIndex = -1;
            cbxNombreTienda.SelectedIndex = -1;
            cbxTitulo.SelectedIndex = -1;
            nupCantidad.Value = 0;
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

        private void LlenarTienda()
        {
            DataTable data = new DataTable();
            DatosPubs datos = new DatosPubs();

            data = datos.ObtenerTiendas();

            foreach (DataRow row in data.Rows)
            {
                cbxIdTienda.Items.Add(row["stor_id"].ToString());
                cbxNombreTienda.Items.Add(row["stor_name"].ToString());
            }
        }

        private void cbxIdTienda_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedIndex = cbxIdTienda.SelectedIndex;
            cbxNombreTienda.SelectedIndex = selectedIndex;
        }

        private void frmAltaStock_Load(object sender, EventArgs e)
        {
            LlenarTienda();
            LlenarTitulo();
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            stock = new frmStock();
            stock.Show();
            this.Close();
        }
    }
}
