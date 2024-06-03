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
    public partial class frmMenu : Form
    {
        frmAutores autores = new frmAutores();
        frmTitulos titulos = new frmTitulos();
        frmEmpleados empleados = new frmEmpleados();
        frmStock stock = new frmStock();
        frmTiendas tiendas = new frmTiendas();
        frmTitulosAutor titulosautor = new frmTitulosAutor();
        frmUsuarios usuarios = new frmUsuarios();
        frmVentas ventas = new frmVentas();
        FrmLoging inicio = new FrmLoging();
        public frmMenu()
        {
            InitializeComponent();
        }

        private void frmMenu_Load(object sender, EventArgs e)
        {
            tsslNombreUsuario.Text = FrmLoging.nombreUsuario;
        }

        public void ActualizarVisibilidadMenuItem(bool esAdmin)
        {
            agregarUsuariosToolStripMenuItem.Visible = esAdmin;
        }

        private void btnTitulos_Click(object sender, EventArgs e)
        {
            titulos.Show();
            this.Hide();
        }

        private void btnStock_Click(object sender, EventArgs e)
        {
            stock.Show();
            this.Hide();
        }

        private void btnTitulosAutor_Click(object sender, EventArgs e)
        {
            titulosautor.Show();
            this.Hide();
        }

        private void btnTiendas_Click(object sender, EventArgs e)
        {
            tiendas.Show();
            this.Hide();
        }

        private void btnVentas_Click(object sender, EventArgs e)
        {
            ventas.Show();
            this.Hide();
        }

        private void btnEmpleados_Click(object sender, EventArgs e)
        {
            empleados.Show();
            this.Hide();
        }

        private void agregarUsuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            usuarios.Show();
            this.Hide();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            inicio.Show();
            this.Close();
        }

        private void btnAutores_Click(object sender, EventArgs e)
        {
            autores.Show();
            this.Close();
        }
    }
}
