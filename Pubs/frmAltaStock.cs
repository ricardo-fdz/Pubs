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
    public partial class frmAltaStock : Form
    {
        frmStock stock;
        public frmAltaStock()
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

                // Verificar si el libro ya existe en la tienda
                if (datos.LibroExistenteEnTienda(stor_id, title_id))
                {
                    // Si el libro ya existe en la tienda, mostrar un mensaje y salir del método
                    MessageBox.Show("El libro ya existe en esta tienda, ingresa otro.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                // Si el libro no existe en la tienda, proceder con la inserción de stock
                datos.AltaBookStock(stor_id, title_id, (int)nupCantidad.Value);

                MessageBox.Show("Stock agregado a tienda", "Informativo", MessageBoxButtons.OK);

                // Limpiar los controles después de agregar el título
                LimpiarControles();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al agregar el stock: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            stock = new frmStock();
            stock.Show();
            this.Close();
        }

        private void cbxIdTienda_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedIndex = cbxIdTienda.SelectedIndex;
            cbxNombreTienda.SelectedIndex = selectedIndex;
        }

        private void cbxNombreTienda_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedIndex = cbxNombreTienda.SelectedIndex;
            cbxIdTienda.SelectedIndex = selectedIndex;
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

        private void frmAltaStock_Load(object sender, EventArgs e)
        {
            LlenarTienda();
            LlenarTitulo();
        }
    }
}
