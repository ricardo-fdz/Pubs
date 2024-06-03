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
    public partial class frmAltaEmpleados : Form
    {
        frmEmpleados empleados;
        public frmAltaEmpleados()
        {
            InitializeComponent();
        }

        private void frmAltaEmpleados_Load(object sender, EventArgs e)
        {
            LlenarPub();
            LlenarTrabajoPuesto();
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            empleados = new frmEmpleados();
            empleados.Show();
            this.Close();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            DatosPubs datos = new DatosPubs();
            try
            {
                // Obtener los valores seleccionados en los ComboBox
                short jobId = Convert.ToInt16(cbxIdTrabajo.SelectedItem);
                string job_desc = cbxPuesto.SelectedItem.ToString();
                string pub_id = cbxIdPub.SelectedItem.ToString();
                string pub_name = cbxEditorial.SelectedItem.ToString();

                // Convertir el valor string de txtNivel a int
                int nivel;
                if (!int.TryParse(txtNivel.Text, out nivel))
                {
                    MessageBox.Show("El valor de Nivel debe ser un número entero.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

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
                if (rangosNivelesPorJobId.ContainsKey(jobId))
                {
                    var (nivelMinimo, nivelMaximo) = rangosNivelesPorJobId[jobId];

                    // Verificar si el nivel seleccionado está dentro del rango permitido
                    if (nivel < nivelMinimo || nivel > nivelMaximo)
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

                // Llamar a la función AltaEmpleados con los valores obtenidos
                datos.AltaEmpleados(txtIdEmpleados.Text, txtNombre.Text, txtInicial.Text, txtApellido.Text, jobId, (byte)nivel, pub_id, dtpFechaContratacion.Value);

                MessageBox.Show("Empleado registrado.", "Informativo", MessageBoxButtons.OK);

                // Limpiar los controles después de agregar el título
                LimpiarControles();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al registrar empleado: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LimpiarControles()
        {
            txtIdEmpleados.Clear();
            txtNombre.Clear();
            txtInicial.Clear();
            txtApellido.Clear();
            cbxEditorial.SelectedIndex = -1;
            cbxIdPub.SelectedIndex = -1;
            cbxIdTrabajo.SelectedIndex = -1;
            cbxPuesto.SelectedIndex = -1;
            txtNivel.Clear();
            dtpFechaContratacion.Value = DateTime.Today;
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

        private void cbxIdTrabajo_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedIndex = cbxIdTrabajo.SelectedIndex;
            cbxPuesto.SelectedIndex = selectedIndex;
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
    }
}
