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
    public partial class frmModificarEmpleados : Form
    {
        public frmModificarEmpleados()
        {
            InitializeComponent();
        }

        public frmModificarEmpleados(string valorColumna1, string valorColumna2, string valorColumna3, string valorColumna4,
            string valorColumna5, string valorColumna6, string valorColumna7, DateTime valorColumna8)
        {
            InitializeComponent();
            txtIdEmpleados.Text = valorColumna1;
            txtNombre.Text = valorColumna2;
            txtInicial.Text = valorColumna3;
            txtApellido.Text = valorColumna4;
            cbxIdTrabajo.Text = valorColumna5;
            txtNivel.Text = valorColumna6;
            cbxIdPub.Text = valorColumna7;
            dtpFechaContratacion.Value = valorColumna8;
        }

        private void cbxIdTrabajo_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedIndex = cbxIdTrabajo.SelectedIndex;
            cbxPuesto.SelectedIndex = selectedIndex;
        }

        private void cbxPuesto_RightToLeftChanged(object sender, EventArgs e)
        {

        }

        private void cbxPuesto_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedIndex = cbxPuesto.SelectedIndex;
            cbxIdTrabajo.SelectedIndex = selectedIndex;
        }

        private void cbxIdPub_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedIndex = cbxIdPub.SelectedIndex;
            cbxEditorial.SelectedIndex = selectedIndex;
        }

        private void cbxEditorial_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedIndex = cbxEditorial.SelectedIndex;
            cbxIdPub.SelectedIndex = selectedIndex;
        }

        private void LlenarPub()
        {
            DataTable data = new DataTable();
            DatosPubs datos = new DatosPubs();

            data = datos.ObtenerPub();

            foreach (DataRow row in data.Rows)
            {
                cbxIdPub.Items.Add(row["pub_id"].ToString());
                cbxEditorial.Items.Add(row["pub_name"].ToString());
            }
        }

        private void LlenarTrabajoPuesto()
        {
            DataTable data = new DataTable();
            DatosPubs datos = new DatosPubs();

            data = datos.ObtenerJob();

            foreach (DataRow row in data.Rows)
            {
                cbxIdTrabajo.Items.Add(row["job_id"].ToString());
                cbxPuesto.Items.Add(row["job_desc"].ToString());
            }
        }

        private void frmModificarEmpleados_Load(object sender, EventArgs e)
        {
            LlenarPub();
            LlenarTrabajoPuesto();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            DatosPubs datos = new DatosPubs();
            try
            {
                string nuevoId = txtIdEmpleados.Text;
                string nuevoNombre = txtNombre.Text;
                string nuevaInicial = txtInicial.Text;
                string nuevoApellido = txtApellido.Text;
                short nuevoIdTrabajo = short.Parse(cbxIdTrabajo.Text);
                byte nuevaNivel = byte.Parse(txtNivel.Text);
                string nuevaIdEditorial = cbxIdPub.Text;
                DateTime nuevaFechaContratacion = DateTime.Parse(dtpFechaContratacion.Text);

                // Definir una estructura de datos que mapee cada job_id con sus rangos de niveles permitidos
                Dictionary<int, (int, int)> rangosNivelesPorJobId = new Dictionary<int, (int, int)> {
                { 1, (10, 10) },
                { 2, (200, 250) },
                { 3, (175, 225) },
                { 4, (175, 250) },
                { 5, (150, 250) },
                { 6, (140, 225) },
                { 7, (120, 200) },
                { 8, (100, 175) },
                { 9, (75, 175) },
                { 10, (75, 165) },
                { 11, (75, 150) },
                { 12, (25, 100) },
                { 13, (25, 100) },
                { 14, (25, 100) },
                { 15, (46, 120) },
                { 16, (78, 125) },
                { 17, (50, 138) },
                { 18, (34, 100) },
                { 19, (25, 100) },
                };

                // Verificar si el job_id seleccionado tiene rangos de niveles permitidos
                if (rangosNivelesPorJobId.ContainsKey(nuevoIdTrabajo))
                {
                    var (nivelMinimo, nivelMaximo) = rangosNivelesPorJobId[nuevoIdTrabajo];

                    // Verificar si el nivel seleccionado está dentro del rango permitido
                    if (nuevaNivel < nivelMinimo || nuevaNivel > nivelMaximo)
                    {
                        MessageBox.Show($"El nivel debe estar entre {nivelMinimo} y {nivelMaximo} para el job ID seleccionado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
                else
                {
                    MessageBox.Show("No se encontraron rangos de niveles permitidos para el job ID seleccionado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                datos.ActualizarEmpleado(nuevoId, nuevoNombre, nuevaInicial, nuevoApellido, nuevoIdTrabajo, nuevaNivel,
                        nuevaIdEditorial, nuevaFechaContratacion);

                MessageBox.Show("Empleado modificado", "Informativo", MessageBoxButtons.OK);

                frmEmpleados parentForm = (frmEmpleados)this.Owner;
                parentForm.ActualizarDataGridView();

                // Cerrar el formulario de Modificación
                this.Close();

            }
            catch (Exception ex)
            {

                MessageBox.Show("Error al realizar la modificación: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
