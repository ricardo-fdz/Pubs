namespace Pubs
{
    partial class frmStock
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.lblFiltrar = new System.Windows.Forms.Label();
            this.cbxFiltrarNombreTienda = new System.Windows.Forms.ComboBox();
            this.cbxFiltrarIdTiendas = new System.Windows.Forms.ComboBox();
            this.btnAltaStock = new System.Windows.Forms.Button();
            this.btnRegresar = new System.Windows.Forms.Button();
            this.btnAgregarStock = new System.Windows.Forms.Button();
            this.dgvStock = new System.Windows.Forms.DataGridView();
            this.btnReporte = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStock)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft JhengHei", 17F);
            this.label1.Location = new System.Drawing.Point(934, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 29);
            this.label1.TabIndex = 29;
            this.label1.Text = "STOCK ";
            // 
            // btnEliminar
            // 
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminar.Location = new System.Drawing.Point(940, 214);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(112, 75);
            this.btnEliminar.TabIndex = 28;
            this.btnEliminar.Text = "Eliminar registro de stock";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // lblFiltrar
            // 
            this.lblFiltrar.AutoSize = true;
            this.lblFiltrar.Location = new System.Drawing.Point(936, 315);
            this.lblFiltrar.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFiltrar.Name = "lblFiltrar";
            this.lblFiltrar.Size = new System.Drawing.Size(53, 13);
            this.lblFiltrar.TabIndex = 27;
            this.lblFiltrar.Text = "Filtrar por:";
            // 
            // cbxFiltrarNombreTienda
            // 
            this.cbxFiltrarNombreTienda.FormattingEnabled = true;
            this.cbxFiltrarNombreTienda.Location = new System.Drawing.Point(940, 381);
            this.cbxFiltrarNombreTienda.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbxFiltrarNombreTienda.Name = "cbxFiltrarNombreTienda";
            this.cbxFiltrarNombreTienda.Size = new System.Drawing.Size(180, 21);
            this.cbxFiltrarNombreTienda.TabIndex = 26;
            this.cbxFiltrarNombreTienda.Text = "Nombre Tienda";
            this.cbxFiltrarNombreTienda.SelectedIndexChanged += new System.EventHandler(this.cbxFiltrarNombreTienda_SelectedIndexChanged);
            // 
            // cbxFiltrarIdTiendas
            // 
            this.cbxFiltrarIdTiendas.FormattingEnabled = true;
            this.cbxFiltrarIdTiendas.Location = new System.Drawing.Point(940, 342);
            this.cbxFiltrarIdTiendas.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbxFiltrarIdTiendas.Name = "cbxFiltrarIdTiendas";
            this.cbxFiltrarIdTiendas.Size = new System.Drawing.Size(180, 21);
            this.cbxFiltrarIdTiendas.TabIndex = 25;
            this.cbxFiltrarIdTiendas.Text = "Id Tiendas";
            this.cbxFiltrarIdTiendas.SelectedIndexChanged += new System.EventHandler(this.cbxFiltrarIdTiendas_SelectedIndexChanged);
            // 
            // btnAltaStock
            // 
            this.btnAltaStock.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAltaStock.Location = new System.Drawing.Point(939, 76);
            this.btnAltaStock.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAltaStock.Name = "btnAltaStock";
            this.btnAltaStock.Size = new System.Drawing.Size(112, 59);
            this.btnAltaStock.TabIndex = 24;
            this.btnAltaStock.Text = "Agregar nuevo stock";
            this.btnAltaStock.UseVisualStyleBackColor = true;
            this.btnAltaStock.Click += new System.EventHandler(this.btnAltaStock_Click);
            // 
            // btnRegresar
            // 
            this.btnRegresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegresar.Location = new System.Drawing.Point(940, 489);
            this.btnRegresar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.Size = new System.Drawing.Size(112, 33);
            this.btnRegresar.TabIndex = 23;
            this.btnRegresar.Text = "Regresar";
            this.btnRegresar.UseVisualStyleBackColor = true;
            this.btnRegresar.Click += new System.EventHandler(this.btnRegresar_Click);
            // 
            // btnAgregarStock
            // 
            this.btnAgregarStock.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarStock.Location = new System.Drawing.Point(939, 145);
            this.btnAgregarStock.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAgregarStock.Name = "btnAgregarStock";
            this.btnAgregarStock.Size = new System.Drawing.Size(112, 59);
            this.btnAgregarStock.TabIndex = 22;
            this.btnAgregarStock.Text = "Actualizar stock";
            this.btnAgregarStock.UseVisualStyleBackColor = true;
            this.btnAgregarStock.Click += new System.EventHandler(this.btnAgregarStock_Click);
            // 
            // dgvStock
            // 
            this.dgvStock.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStock.Location = new System.Drawing.Point(42, 20);
            this.dgvStock.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvStock.Name = "dgvStock";
            this.dgvStock.RowHeadersWidth = 51;
            this.dgvStock.Size = new System.Drawing.Size(837, 517);
            this.dgvStock.TabIndex = 21;
            // 
            // btnReporte
            // 
            this.btnReporte.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReporte.Location = new System.Drawing.Point(939, 446);
            this.btnReporte.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnReporte.Name = "btnReporte";
            this.btnReporte.Size = new System.Drawing.Size(112, 33);
            this.btnReporte.TabIndex = 30;
            this.btnReporte.Text = "Reporte";
            this.btnReporte.UseVisualStyleBackColor = true;
            this.btnReporte.Click += new System.EventHandler(this.btnReporte_Click);
            // 
            // frmStock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1162, 549);
            this.Controls.Add(this.btnReporte);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.lblFiltrar);
            this.Controls.Add(this.cbxFiltrarNombreTienda);
            this.Controls.Add(this.cbxFiltrarIdTiendas);
            this.Controls.Add(this.btnAltaStock);
            this.Controls.Add(this.btnRegresar);
            this.Controls.Add(this.btnAgregarStock);
            this.Controls.Add(this.dgvStock);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmStock";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmStock";
            this.Load += new System.EventHandler(this.frmStock_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStock)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Label lblFiltrar;
        private System.Windows.Forms.ComboBox cbxFiltrarNombreTienda;
        private System.Windows.Forms.ComboBox cbxFiltrarIdTiendas;
        private System.Windows.Forms.Button btnAltaStock;
        private System.Windows.Forms.Button btnRegresar;
        private System.Windows.Forms.Button btnAgregarStock;
        private System.Windows.Forms.DataGridView dgvStock;
        private System.Windows.Forms.Button btnReporte;
    }
}