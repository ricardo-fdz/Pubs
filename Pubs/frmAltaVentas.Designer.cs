namespace Pubs
{
    partial class frmAltaVentas
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
            this.label4 = new System.Windows.Forms.Label();
            this.txtPrecioU = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbxDescuento = new System.Windows.Forms.ComboBox();
            this.dtpFechaPublicacion = new System.Windows.Forms.DateTimePicker();
            this.txtAutor = new System.Windows.Forms.TextBox();
            this.lblDescuento = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbxNombreTitulo = new System.Windows.Forms.ComboBox();
            this.cbxIdTitulo = new System.Windows.Forms.ComboBox();
            this.lblNombreTitulo = new System.Windows.Forms.Label();
            this.lblIdTitulo = new System.Windows.Forms.Label();
            this.nupCantidad = new System.Windows.Forms.NumericUpDown();
            this.dtpFechaOrden = new System.Windows.Forms.DateTimePicker();
            this.cbxNombreTienda = new System.Windows.Forms.ComboBox();
            this.cbxIdTienda = new System.Windows.Forms.ComboBox();
            this.btnRegresar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.lblPayterms = new System.Windows.Forms.Label();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.lblFechaOrden = new System.Windows.Forms.Label();
            this.lblOrden = new System.Windows.Forms.Label();
            this.lblNombreTienda = new System.Windows.Forms.Label();
            this.lblIdAutor = new System.Windows.Forms.Label();
            this.txtPayterms = new System.Windows.Forms.TextBox();
            this.txtOrden = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.nupCantidad)).BeginInit();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(562, 92);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 132;
            this.label4.Text = "Precio:";
            // 
            // txtPrecioU
            // 
            this.txtPrecioU.Enabled = false;
            this.txtPrecioU.Location = new System.Drawing.Point(657, 84);
            this.txtPrecioU.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtPrecioU.MaxLength = 12;
            this.txtPrecioU.Name = "txtPrecioU";
            this.txtPrecioU.Size = new System.Drawing.Size(180, 20);
            this.txtPrecioU.TabIndex = 131;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft JhengHei", 17F);
            this.label3.Location = new System.Drawing.Point(35, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(165, 29);
            this.label3.TabIndex = 130;
            this.label3.Text = "ALTA VENTAS";
            // 
            // cbxDescuento
            // 
            this.cbxDescuento.FormattingEnabled = true;
            this.cbxDescuento.Location = new System.Drawing.Point(657, 317);
            this.cbxDescuento.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbxDescuento.Name = "cbxDescuento";
            this.cbxDescuento.Size = new System.Drawing.Size(180, 21);
            this.cbxDescuento.TabIndex = 129;
            // 
            // dtpFechaPublicacion
            // 
            this.dtpFechaPublicacion.Location = new System.Drawing.Point(198, 439);
            this.dtpFechaPublicacion.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dtpFechaPublicacion.Name = "dtpFechaPublicacion";
            this.dtpFechaPublicacion.Size = new System.Drawing.Size(282, 20);
            this.dtpFechaPublicacion.TabIndex = 128;
            // 
            // txtAutor
            // 
            this.txtAutor.Location = new System.Drawing.Point(198, 376);
            this.txtAutor.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtAutor.MaxLength = 80;
            this.txtAutor.Name = "txtAutor";
            this.txtAutor.ReadOnly = true;
            this.txtAutor.Size = new System.Drawing.Size(180, 20);
            this.txtAutor.TabIndex = 127;
            // 
            // lblDescuento
            // 
            this.lblDescuento.AutoSize = true;
            this.lblDescuento.Location = new System.Drawing.Point(556, 325);
            this.lblDescuento.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDescuento.Name = "lblDescuento";
            this.lblDescuento.Size = new System.Drawing.Size(62, 13);
            this.lblDescuento.TabIndex = 126;
            this.lblDescuento.Text = "Descuento:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(66, 446);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 13);
            this.label2.TabIndex = 125;
            this.label2.Text = "Fecha Publicación:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(133, 383);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 124;
            this.label1.Text = "Autor:";
            // 
            // cbxNombreTitulo
            // 
            this.cbxNombreTitulo.FormattingEnabled = true;
            this.cbxNombreTitulo.Location = new System.Drawing.Point(198, 317);
            this.cbxNombreTitulo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbxNombreTitulo.Name = "cbxNombreTitulo";
            this.cbxNombreTitulo.Size = new System.Drawing.Size(180, 21);
            this.cbxNombreTitulo.TabIndex = 121;
            this.cbxNombreTitulo.SelectedIndexChanged += new System.EventHandler(this.cbxNombreTitulo_SelectedIndexChanged);
            // 
            // cbxIdTitulo
            // 
            this.cbxIdTitulo.FormattingEnabled = true;
            this.cbxIdTitulo.Location = new System.Drawing.Point(198, 261);
            this.cbxIdTitulo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbxIdTitulo.Name = "cbxIdTitulo";
            this.cbxIdTitulo.Size = new System.Drawing.Size(180, 21);
            this.cbxIdTitulo.TabIndex = 120;
            this.cbxIdTitulo.SelectedIndexChanged += new System.EventHandler(this.cbxIdTitulo_SelectedIndexChanged);
            // 
            // lblNombreTitulo
            // 
            this.lblNombreTitulo.AutoSize = true;
            this.lblNombreTitulo.Location = new System.Drawing.Point(77, 325);
            this.lblNombreTitulo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNombreTitulo.Name = "lblNombreTitulo";
            this.lblNombreTitulo.Size = new System.Drawing.Size(76, 13);
            this.lblNombreTitulo.TabIndex = 123;
            this.lblNombreTitulo.Text = "Nombre Titulo:";
            // 
            // lblIdTitulo
            // 
            this.lblIdTitulo.AutoSize = true;
            this.lblIdTitulo.Location = new System.Drawing.Point(121, 269);
            this.lblIdTitulo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblIdTitulo.Name = "lblIdTitulo";
            this.lblIdTitulo.Size = new System.Drawing.Size(48, 13);
            this.lblIdTitulo.TabIndex = 122;
            this.lblIdTitulo.Text = "Id Titulo:";
            // 
            // nupCantidad
            // 
            this.nupCantidad.Location = new System.Drawing.Point(657, 200);
            this.nupCantidad.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.nupCantidad.Maximum = new decimal(new int[] {
            3200,
            0,
            0,
            0});
            this.nupCantidad.Name = "nupCantidad";
            this.nupCantidad.Size = new System.Drawing.Size(58, 20);
            this.nupCantidad.TabIndex = 110;
            this.nupCantidad.ValueChanged += new System.EventHandler(this.nupCantidad_ValueChanged);
            // 
            // dtpFechaOrden
            // 
            this.dtpFechaOrden.Location = new System.Drawing.Point(657, 141);
            this.dtpFechaOrden.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dtpFechaOrden.Name = "dtpFechaOrden";
            this.dtpFechaOrden.Size = new System.Drawing.Size(283, 20);
            this.dtpFechaOrden.TabIndex = 109;
            // 
            // cbxNombreTienda
            // 
            this.cbxNombreTienda.FormattingEnabled = true;
            this.cbxNombreTienda.Location = new System.Drawing.Point(198, 140);
            this.cbxNombreTienda.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbxNombreTienda.Name = "cbxNombreTienda";
            this.cbxNombreTienda.Size = new System.Drawing.Size(180, 21);
            this.cbxNombreTienda.TabIndex = 107;
            this.cbxNombreTienda.SelectedIndexChanged += new System.EventHandler(this.cbxNombreTienda_SelectedIndexChanged);
            // 
            // cbxIdTienda
            // 
            this.cbxIdTienda.FormattingEnabled = true;
            this.cbxIdTienda.Location = new System.Drawing.Point(198, 84);
            this.cbxIdTienda.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbxIdTienda.Name = "cbxIdTienda";
            this.cbxIdTienda.Size = new System.Drawing.Size(180, 21);
            this.cbxIdTienda.TabIndex = 106;
            this.cbxIdTienda.SelectedIndexChanged += new System.EventHandler(this.cbxIdTienda_SelectedIndexChanged);
            // 
            // btnRegresar
            // 
            this.btnRegresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegresar.Location = new System.Drawing.Point(728, 429);
            this.btnRegresar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.Size = new System.Drawing.Size(112, 33);
            this.btnRegresar.TabIndex = 119;
            this.btnRegresar.Text = "Regresar";
            this.btnRegresar.UseVisualStyleBackColor = true;
            this.btnRegresar.Click += new System.EventHandler(this.btnRegresar_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregar.Location = new System.Drawing.Point(576, 429);
            this.btnAgregar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(112, 33);
            this.btnAgregar.TabIndex = 118;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // lblPayterms
            // 
            this.lblPayterms.AutoSize = true;
            this.lblPayterms.Location = new System.Drawing.Point(562, 269);
            this.lblPayterms.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPayterms.Name = "lblPayterms";
            this.lblPayterms.Size = new System.Drawing.Size(57, 13);
            this.lblPayterms.TabIndex = 117;
            this.lblPayterms.Text = "PayTerms:";
            // 
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.Location = new System.Drawing.Point(564, 208);
            this.lblCantidad.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(52, 13);
            this.lblCantidad.TabIndex = 116;
            this.lblCantidad.Text = "Cantidad:";
            // 
            // lblFechaOrden
            // 
            this.lblFechaOrden.AutoSize = true;
            this.lblFechaOrden.Location = new System.Drawing.Point(544, 149);
            this.lblFechaOrden.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFechaOrden.Name = "lblFechaOrden";
            this.lblFechaOrden.Size = new System.Drawing.Size(72, 13);
            this.lblFechaOrden.TabIndex = 115;
            this.lblFechaOrden.Text = "Fecha Orden:";
            // 
            // lblOrden
            // 
            this.lblOrden.AutoSize = true;
            this.lblOrden.Location = new System.Drawing.Point(99, 208);
            this.lblOrden.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblOrden.Name = "lblOrden";
            this.lblOrden.Size = new System.Drawing.Size(64, 13);
            this.lblOrden.TabIndex = 114;
            this.lblOrden.Text = "# de Orden:";
            // 
            // lblNombreTienda
            // 
            this.lblNombreTienda.AutoSize = true;
            this.lblNombreTienda.Location = new System.Drawing.Point(69, 148);
            this.lblNombreTienda.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNombreTienda.Name = "lblNombreTienda";
            this.lblNombreTienda.Size = new System.Drawing.Size(83, 13);
            this.lblNombreTienda.TabIndex = 113;
            this.lblNombreTienda.Text = "Nombre Tienda:";
            // 
            // lblIdAutor
            // 
            this.lblIdAutor.AutoSize = true;
            this.lblIdAutor.Location = new System.Drawing.Point(117, 93);
            this.lblIdAutor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblIdAutor.Name = "lblIdAutor";
            this.lblIdAutor.Size = new System.Drawing.Size(52, 13);
            this.lblIdAutor.TabIndex = 112;
            this.lblIdAutor.Text = "IdTienda:";
            // 
            // txtPayterms
            // 
            this.txtPayterms.Location = new System.Drawing.Point(658, 261);
            this.txtPayterms.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtPayterms.MaxLength = 12;
            this.txtPayterms.Name = "txtPayterms";
            this.txtPayterms.Size = new System.Drawing.Size(180, 20);
            this.txtPayterms.TabIndex = 111;
            // 
            // txtOrden
            // 
            this.txtOrden.Location = new System.Drawing.Point(198, 199);
            this.txtOrden.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtOrden.MaxLength = 20;
            this.txtOrden.Name = "txtOrden";
            this.txtOrden.Size = new System.Drawing.Size(180, 20);
            this.txtOrden.TabIndex = 108;
            // 
            // frmAltaVentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(974, 503);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtPrecioU);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbxDescuento);
            this.Controls.Add(this.dtpFechaPublicacion);
            this.Controls.Add(this.txtAutor);
            this.Controls.Add(this.lblDescuento);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbxNombreTitulo);
            this.Controls.Add(this.cbxIdTitulo);
            this.Controls.Add(this.lblNombreTitulo);
            this.Controls.Add(this.lblIdTitulo);
            this.Controls.Add(this.nupCantidad);
            this.Controls.Add(this.dtpFechaOrden);
            this.Controls.Add(this.cbxNombreTienda);
            this.Controls.Add(this.cbxIdTienda);
            this.Controls.Add(this.btnRegresar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.lblPayterms);
            this.Controls.Add(this.lblCantidad);
            this.Controls.Add(this.lblFechaOrden);
            this.Controls.Add(this.lblOrden);
            this.Controls.Add(this.lblNombreTienda);
            this.Controls.Add(this.lblIdAutor);
            this.Controls.Add(this.txtPayterms);
            this.Controls.Add(this.txtOrden);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmAltaVentas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmAltaVentas";
            this.Load += new System.EventHandler(this.frmAltaVentas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nupCantidad)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtPrecioU;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbxDescuento;
        private System.Windows.Forms.DateTimePicker dtpFechaPublicacion;
        private System.Windows.Forms.TextBox txtAutor;
        private System.Windows.Forms.Label lblDescuento;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbxNombreTitulo;
        private System.Windows.Forms.ComboBox cbxIdTitulo;
        private System.Windows.Forms.Label lblNombreTitulo;
        private System.Windows.Forms.Label lblIdTitulo;
        private System.Windows.Forms.NumericUpDown nupCantidad;
        private System.Windows.Forms.DateTimePicker dtpFechaOrden;
        private System.Windows.Forms.ComboBox cbxNombreTienda;
        private System.Windows.Forms.ComboBox cbxIdTienda;
        private System.Windows.Forms.Button btnRegresar;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Label lblPayterms;
        private System.Windows.Forms.Label lblCantidad;
        private System.Windows.Forms.Label lblFechaOrden;
        private System.Windows.Forms.Label lblOrden;
        private System.Windows.Forms.Label lblNombreTienda;
        private System.Windows.Forms.Label lblIdAutor;
        private System.Windows.Forms.TextBox txtPayterms;
        private System.Windows.Forms.TextBox txtOrden;
    }
}