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
    public partial class frmAltaAutores : Form
    {
        frmAutores autores;
        public frmAltaAutores()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            DatosPubs datos = new DatosPubs();
            N_Autores n_Autores = new N_Autores();
            string Error;
            string IdAutor, Nombre, Apellido, Telefono, Direccion, Ciudad, Estado, CodPostal;
            bool Contrato;
            try
            {
                mtxtIdAutor.TextMaskFormat = MaskFormat.IncludePromptAndLiterals;
                IdAutor = mtxtIdAutor.Text;
                Nombre = txtNombre.Text;
                Apellido = txtApellido.Text;

                mtxtTelefono.TextMaskFormat = MaskFormat.IncludePromptAndLiterals;
                Telefono = mtxtTelefono.Text;

                Direccion = txtDireccion.Text;
                Ciudad = txtCiudad.Text;
                Estado = cbEstado.SelectedItem.ToString();
                CodPostal = txtCodigoPostal.Text;
                Contrato = chkbContrato.Checked;

                Error = n_Autores.AltaAutor(IdAutor, Nombre, Apellido, Telefono, Direccion, Ciudad, Estado, CodPostal, Contrato);

                if (Error == "1")
                {
                    MessageBox.Show("Autor agregado", "Informativo", MessageBoxButtons.OK);
                }
                else
                    MessageBox.Show("Servicio no diponible "+ Error , "Informativo", MessageBoxButtons.OK);

                //Se usa componente MaskedTextBox para dar formato al textbox se puede modificar su propiedad en "Propiedades > Mask dar en los 3 puntos y seleccionar o generar un mascarado
                mtxtIdAutor.Clear();//MaskedTextBox

                txtNombre.Clear();
                txtApellido.Clear();

                mtxtTelefono.Clear();//MaskedTextBox

                txtDireccion.Clear();
                txtCiudad.Clear();
                cbEstado.SelectedIndex = -1;
                txtCodigoPostal.Clear();
                chkbContrato.Checked = false;
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error al agregar autor: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            autores = new frmAutores();
            autores.Show();
            this.Close();
        }

        private void frmAltaAutores_Load(object sender, EventArgs e)
        {
            //LlenarEstados();
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
    }
}
