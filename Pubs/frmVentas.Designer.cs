namespace Pubs
{
    partial class frmVentas
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
            this.cbxNombre = new System.Windows.Forms.ComboBox();
            this.cbxNumero = new System.Windows.Forms.ComboBox();
            this.lblFiltrar = new System.Windows.Forms.Label();
            this.cbxFiltrarId = new System.Windows.Forms.ComboBox();
            this.btnRegresar = new System.Windows.Forms.Button();
            this.btnEliminarVenta = new System.Windows.Forms.Button();
            this.btnModificarVenta = new System.Windows.Forms.Button();
            this.btnAltaVentas = new System.Windows.Forms.Button();
            this.dgvVentas = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVentas)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft JhengHei", 17F);
            this.label1.Location = new System.Drawing.Point(934, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 29);
            this.label1.TabIndex = 44;
            this.label1.Text = "VENTAS";
            // 
            // cbxNombre
            // 
            this.cbxNombre.FormattingEnabled = true;
            this.cbxNombre.Location = new System.Drawing.Point(940, 383);
            this.cbxNombre.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbxNombre.Name = "cbxNombre";
            this.cbxNombre.Size = new System.Drawing.Size(180, 21);
            this.cbxNombre.TabIndex = 43;
            this.cbxNombre.Text = "Nombre Tienda";
            this.cbxNombre.SelectedIndexChanged += new System.EventHandler(this.cbxNombre_SelectedIndexChanged);
            // 
            // cbxNumero
            // 
            this.cbxNumero.FormattingEnabled = true;
            this.cbxNumero.Location = new System.Drawing.Point(940, 422);
            this.cbxNumero.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbxNumero.Name = "cbxNumero";
            this.cbxNumero.Size = new System.Drawing.Size(180, 21);
            this.cbxNumero.TabIndex = 42;
            this.cbxNumero.Text = "Numero de Orden";
            this.cbxNumero.SelectedIndexChanged += new System.EventHandler(this.cbxNumero_SelectedIndexChanged);
            // 
            // lblFiltrar
            // 
            this.lblFiltrar.AutoSize = true;
            this.lblFiltrar.Location = new System.Drawing.Point(936, 320);
            this.lblFiltrar.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFiltrar.Name = "lblFiltrar";
            this.lblFiltrar.Size = new System.Drawing.Size(53, 13);
            this.lblFiltrar.TabIndex = 41;
            this.lblFiltrar.Text = "Filtrar por:";
            // 
            // cbxFiltrarId
            // 
            this.cbxFiltrarId.FormattingEnabled = true;
            this.cbxFiltrarId.Location = new System.Drawing.Point(940, 344);
            this.cbxFiltrarId.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbxFiltrarId.Name = "cbxFiltrarId";
            this.cbxFiltrarId.Size = new System.Drawing.Size(180, 21);
            this.cbxFiltrarId.TabIndex = 40;
            this.cbxFiltrarId.Text = "Id Tienda";
            this.cbxFiltrarId.SelectedIndexChanged += new System.EventHandler(this.cbxFiltrarId_SelectedIndexChanged);
            // 
            // btnRegresar
            // 
            this.btnRegresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegresar.Location = new System.Drawing.Point(940, 489);
            this.btnRegresar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.Size = new System.Drawing.Size(112, 33);
            this.btnRegresar.TabIndex = 39;
            this.btnRegresar.Text = "Regresar";
            this.btnRegresar.UseVisualStyleBackColor = true;
            this.btnRegresar.Click += new System.EventHandler(this.btnRegresar_Click);
            // 
            // btnEliminarVenta
            // 
            this.btnEliminarVenta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminarVenta.Location = new System.Drawing.Point(940, 210);
            this.btnEliminarVenta.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnEliminarVenta.Name = "btnEliminarVenta";
            this.btnEliminarVenta.Size = new System.Drawing.Size(112, 65);
            this.btnEliminarVenta.TabIndex = 38;
            this.btnEliminarVenta.Text = "Eliminar venta";
            this.btnEliminarVenta.UseVisualStyleBackColor = true;
            this.btnEliminarVenta.Click += new System.EventHandler(this.btnEliminarVenta_Click);
            // 
            // btnModificarVenta
            // 
            this.btnModificarVenta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModificarVenta.Location = new System.Drawing.Point(940, 145);
            this.btnModificarVenta.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnModificarVenta.Name = "btnModificarVenta";
            this.btnModificarVenta.Size = new System.Drawing.Size(112, 57);
            this.btnModificarVenta.TabIndex = 37;
            this.btnModificarVenta.Text = "Modificar venta";
            this.btnModificarVenta.UseVisualStyleBackColor = true;
            this.btnModificarVenta.Click += new System.EventHandler(this.btnModificarVenta_Click);
            // 
            // btnAltaVentas
            // 
            this.btnAltaVentas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAltaVentas.Location = new System.Drawing.Point(940, 76);
            this.btnAltaVentas.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAltaVentas.Name = "btnAltaVentas";
            this.btnAltaVentas.Size = new System.Drawing.Size(112, 59);
            this.btnAltaVentas.TabIndex = 36;
            this.btnAltaVentas.Text = "Agregar venta";
            this.btnAltaVentas.UseVisualStyleBackColor = true;
            this.btnAltaVentas.Click += new System.EventHandler(this.btnAltaVentas_Click);
            // 
            // dgvVentas
            // 
            this.dgvVentas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVentas.Location = new System.Drawing.Point(42, 20);
            this.dgvVentas.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvVentas.Name = "dgvVentas";
            this.dgvVentas.RowHeadersWidth = 51;
            this.dgvVentas.Size = new System.Drawing.Size(836, 517);
            this.dgvVentas.TabIndex = 35;
            // 
            // frmVentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1162, 549);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbxNombre);
            this.Controls.Add(this.cbxNumero);
            this.Controls.Add(this.lblFiltrar);
            this.Controls.Add(this.cbxFiltrarId);
            this.Controls.Add(this.btnRegresar);
            this.Controls.Add(this.btnEliminarVenta);
            this.Controls.Add(this.btnModificarVenta);
            this.Controls.Add(this.btnAltaVentas);
            this.Controls.Add(this.dgvVentas);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmVentas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmVentas";
            this.Load += new System.EventHandler(this.frmVentas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvVentas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbxNombre;
        private System.Windows.Forms.ComboBox cbxNumero;
        private System.Windows.Forms.Label lblFiltrar;
        private System.Windows.Forms.ComboBox cbxFiltrarId;
        private System.Windows.Forms.Button btnRegresar;
        private System.Windows.Forms.Button btnEliminarVenta;
        private System.Windows.Forms.Button btnModificarVenta;
        private System.Windows.Forms.Button btnAltaVentas;
        private System.Windows.Forms.DataGridView dgvVentas;
    }
}