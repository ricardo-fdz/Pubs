using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using iTextSharp.text.pdf;
using iTextSharp.text;
using System.IO;

namespace Pubs
{
    public partial class frmStock : Form
    {
        frmMenu menu;
        frmModificarStock ModifcarStock;
        frmAltaStock altaStock;
        public frmStock()
        {
            InitializeComponent();
        }

        private void frmStock_Load(object sender, EventArgs e)
        {
            DatosPubs datos = new DatosPubs();

            try
            {
                dgvStock.DataSource = datos.VistaStock();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            LlenarTienda();
        }

        
        private void btnRegresar_Click(object sender, EventArgs e)
        {
            menu = new frmMenu();
            menu.Show();
            this.Close();
        }

        //Modificar Stock
        private void btnAgregarStock_Click(object sender, EventArgs e)
        {
            ModifcarStock = new frmModificarStock();
            ModifcarStock.Show();
            this.Hide();
        }

        private void cbxFiltrarIdTiendas_SelectedIndexChanged(object sender, EventArgs e)
        {
            DatosPubs datos = new DatosPubs();
            string idTiendaSeleccionada = cbxFiltrarIdTiendas.SelectedItem?.ToString();
            int selectedIndex = cbxFiltrarIdTiendas.SelectedIndex;
            cbxFiltrarNombreTienda.SelectedIndex = selectedIndex;

            if (!string.IsNullOrEmpty(idTiendaSeleccionada))
            {

                try
                {
                    // Filtrar los datos del stock basados en el ID de la tienda seleccionada
                    dgvStock.DataSource = datos.VistaStock2(idTiendaSeleccionada);
                }
                catch (Exception ex)
                {
                    // Manejar la excepción adecuadamente, por ejemplo, mostrar un mensaje de error al usuario
                    MessageBox.Show("Error al cargar los datos del stock: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                // Si no se seleccionó ninguna tienda, mostrar todos los datos del stock
                dgvStock.DataSource = datos.VistaStock();
            }
        }

        private void LlenarTienda()
        {
            DataTable data = new DataTable();
            DatosPubs datos = new DatosPubs();

            data = datos.ObtenerTiendas();

            foreach (DataRow row in data.Rows)
            {
                cbxFiltrarIdTiendas.Items.Add(row["stor_id"].ToString());
                cbxFiltrarNombreTienda.Items.Add(row["stor_name"].ToString());
            }
        }

        private void cbxFiltrarNombreTienda_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedIndex = cbxFiltrarNombreTienda.SelectedIndex;
            cbxFiltrarIdTiendas.SelectedIndex = selectedIndex;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            DatosPubs datos = new DatosPubs();
            // Verificar si hay una fila seleccionada en el DataGridView
            if (dgvStock.SelectedRows.Count > 0)
            {
                // Obtener el valor del ID de la fila seleccionada
                string idTiendaSeleccionado = dgvStock.SelectedRows[0].Cells["ID Tienda"].Value.ToString();
                string idLibroSeleccionado = dgvStock.SelectedRows[0].Cells["ID Título"].Value.ToString();

                // Confirmar con el usuario antes de eliminar
                DialogResult result = MessageBox.Show("¿Estás seguro de que deseas eliminar el registro con ID de Tienda " + idTiendaSeleccionado + "?",
                                                        "Confirmar Eliminación",
                                                        MessageBoxButtons.YesNo,
                                                        MessageBoxIcon.Question);

                // Si el usuario confirma la eliminación
                if (result == DialogResult.Yes)
                {
                    // Realizar la eliminación del registro utilizando el ID obtenido
                    try
                    {
                        // Llamar a un método en tu clase de acceso a datos para eliminar el registro por su ID
                        // Por ejemplo:
                        // datos.EliminarRegistro(idSeleccionado);
                        datos.EliminarRegistroStock(idTiendaSeleccionado, idLibroSeleccionado);

                        // Actualizar el DataGridView después de la eliminación
                        try
                        {

                            dgvStock.DataSource = datos.VistaStock();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.ToString());
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error al eliminar el registro: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Por favor, seleccione una fila para eliminar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnAltaStock_Click(object sender, EventArgs e)
        {
            altaStock = new frmAltaStock();
            altaStock.Show();
            this.Hide();
        }

        private void btnReporte_Click(object sender, EventArgs e)
        {
            DataTable table = new DataTable();
            DatosPubs datosPubs = new DatosPubs();
            int columnas = 0;
        
            table = datosPubs.VistaStock();

            columnas = table.Columns.Count;

            SaveFileDialog Ruta = new SaveFileDialog();

            // Establecer propiedades del SaveFileDialog
            Ruta.Filter = "Archivos PDF (*.pdf)|*.pdf"; // Filtro para mostrar solo archivos PDF
            Ruta.Title = "Guardar PDF"; // Título del diálogo
            Ruta.FileName = "ReporteStock.pdf"; // Nombre predeterminado del archivo
            Ruta.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments); // Directorio inicial (Mis documentos)

            // Mostrar el diálogo para que el usuario seleccione la ubicación del archivo
            if (Ruta.ShowDialog() == DialogResult.OK)
            {

                GeneraPdf(columnas, table, Ruta.FileName);
            }
        }

        private void GeneraPdf(int NumeroColumnas, DataTable VistaStock, string RutaArchivo)
        {
            string FileName = RutaArchivo;
            Document document = new Document(PageSize.A4.Rotate(), 50, 50, 25, 25);
            PdfWriter.GetInstance(document, new FileStream(FileName, FileMode.Create));
            //PdfWriter.GetInstance(document, new FileStream(@"C:\Users\Zule\Desktop\Asesor.pdf", FileMode.OpenOrCreate));
            document.Open();

            iTextSharp.text.Image jpg = iTextSharp.text.Image.GetInstance(@"C:\Users\Uriel\Documents\SQL Server Management Studio\Ejemplos 6c\Doc_Pdf\Doc_Pdf\Resources\encabezado.png");
            jpg.ScalePercent(32f);
            jpg.Alignment = iTextSharp.text.Image.ALIGN_CENTER;
            document.Add(jpg);


            Paragraph Parrafo = new Paragraph();
            Parrafo.Alignment = Element.ALIGN_RIGHT;
            Parrafo.Font = FontFactory.GetFont("Arial", 8);
            Parrafo.Font.SetStyle(iTextSharp.text.Font.BOLD);
            Parrafo.Font.SetStyle(iTextSharp.text.Font.UNDEFINED);

            Parrafo.Add("Departamento: Sistemas");
            document.Add(Parrafo);


            Paragraph P2 = new Paragraph();
            P2.Alignment = Element.ALIGN_RIGHT;
            P2.Font = FontFactory.GetFont("Arial", 8);
            //P2.Font.SetStyle(iTextSharp.text.Font.BOLD);//negrita  //italic-cursiva //underline-subrayado //strike-tachado
            //P2.Font.SetStyle(iTextSharp.text.Font.UNDEFINED);

            Chunk text = new Chunk("Reporte de Stock por tienda", FontFactory.GetFont("Soberana Sans", 8, iTextSharp.text.Font.BOLD));
            P2.Add(text);
            document.Add(P2);

            document.Add(new Paragraph(" "));
            document.Add(new Paragraph(" "));
            
            Paragraph P6 = new Paragraph();
            P6.Alignment = Element.ALIGN_JUSTIFIED;
            P6.Font = FontFactory.GetFont("Arial", 9);
            //P6.Font.SetStyle(iTextSharp.text.Font.BOLD);
            //P6.Font.SetStyle(iTextSharp.text.Font.UNDEFINED);


            P6.Add("En este reporte se detalla la cantidad de libros que se encuentran en cada tienda");
            document.Add(P6);
            document.Add(new Paragraph(" "));

            float TotalWidth = PageSize.A4.Rotate().Width;
            
            float Columnwidth = TotalWidth / NumeroColumnas;

            PdfPTable tabla = new PdfPTable(NumeroColumnas);
            tabla.SetWidthPercentage(new float[] { 56, Columnwidth, 56, Columnwidth, Columnwidth }, PageSize.A4.Rotate());

            PdfPCell celda1 = new PdfPCell(new Paragraph("Id Tienda", FontFactory.GetFont("Arial", 9,iTextSharp.text.Font.BOLD)));
            PdfPCell celda2 = new PdfPCell(new Paragraph("Nombre Tienda", FontFactory.GetFont("Arial", 9, iTextSharp.text.Font.BOLD)));
            PdfPCell celda3 = new PdfPCell(new Paragraph("Id Libro", FontFactory.GetFont("Arial", 9, iTextSharp.text.Font.BOLD)));
            PdfPCell celda4 = new PdfPCell(new Paragraph("Nombre Libro", FontFactory.GetFont("Arial", 9, iTextSharp.text.Font.BOLD)));
            PdfPCell celda5 = new PdfPCell(new Paragraph("Cantidad Disponible", FontFactory.GetFont("Arial", 9, iTextSharp.text.Font.BOLD)));
            tabla.AddCell(celda1);
            tabla.AddCell(celda2);
            tabla.AddCell(celda3);
            tabla.AddCell(celda4);
            tabla.AddCell(celda5);
            
            foreach (DataRow item in VistaStock.Rows)
            {
                PdfPCell celda6 = new PdfPCell(new Paragraph(item[0].ToString(), FontFactory.GetFont("Arial", 9)));
                tabla.AddCell(celda6);
                

                PdfPCell celda7 = new PdfPCell(new Paragraph(item[1].ToString(), FontFactory.GetFont("Arial", 9)));
                tabla.AddCell(celda7);

                PdfPCell celda8 = new PdfPCell(new Paragraph(item[2].ToString(), FontFactory.GetFont("Arial", 9)));
                tabla.AddCell(celda8);

                PdfPCell celda9 = new PdfPCell(new Paragraph(item[3].ToString(), FontFactory.GetFont("Arial", 9)));
                tabla.AddCell(celda9);

                PdfPCell celda10 = new PdfPCell(new Paragraph(item[4].ToString(), FontFactory.GetFont("Arial", 9)));
                tabla.AddCell(celda10);

                //VistaStock.Rows.Remove(item);

            }

            document.Add(tabla);

            


            //TERMINAR
            document.Close();
            Process prc = new System.Diagnostics.Process();
            prc.StartInfo.FileName = FileName;
            prc.Start();
        }

    }
}
