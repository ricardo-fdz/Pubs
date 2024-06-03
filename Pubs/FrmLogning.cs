using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
using Pubs.Fachada;
using CapaEntidad;
using CapaNegocio;

namespace Pubs
{
    public partial class FrmLoging : Form
    {
        frmMenu menu;
        frmAltaVentas venta;
        N_Logging ObjLoggingNeg = new N_Logging();
        E_Logging ObjLoggingEnt = new E_Logging();
        public static string nombreUsuario;
        public static bool EsAdministrador = false;
        public FrmLoging()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            menu = new frmMenu();
            venta = new frmAltaVentas();
            List<E_Logging> ListaDetalle = null;
            try
            {
                string Usuario = txtUsuario.Text;
                string Contrasena = txtContrasena.Text;

                ListaDetalle = ObjLoggingNeg.ObtenerUsuario(Usuario, Contrasena);


                if (ListaDetalle.Count > 0)
                {
                    foreach (E_Logging obj in ListaDetalle)
                    {
                        nombreUsuario = Usuario;
                        menu.Load += (a, args) =>
                        {
                            txtUsuario.Clear();
                            txtContrasena.Clear();
                        };
                        menu.Show();
                        this.Hide();

                        if (obj.EsAdmin)
                        {
                            menu.ActualizarVisibilidadMenuItem(true);
                        }
                        else
                        {
                            menu.ActualizarVisibilidadMenuItem(false);

                        }
                    }
                }
                else
                    MessageBox.Show("Nombre de usuario o contraseña incorrectos.");
                
            }
            catch (Exception ex)
            {

                throw;
            }
        }

        private void FrmLoging_Load(object sender, EventArgs e)
        {
            
        }
    }
}
