namespace Pubs
{
    partial class frmAltaStock
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
            this.nupCantidad = new System.Windows.Forms.NumericUpDown();
            this.cbxTitulo = new System.Windows.Forms.ComboBox();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.cbxNombreTienda = new System.Windows.Forms.ComboBox();
            this.lblNombreTienda = new System.Windows.Forms.Label();
            this.cbxIdTienda = new System.Windows.Forms.ComboBox();
            this.lblIdTienda = new System.Windows.Forms.Label();
            this.cbxIdTitulo = new System.Windows.Forms.ComboBox();
            this.btnRegresar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.lblIdTitulo = new System.Windows.Forms.Label();
            this.lblCantidad = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nupCantidad)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft JhengHei", 17F);
            this.label1.Location = new System.Drawing.Point(53, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(202, 29);
            this.label1.TabIndex = 117;
            this.label1.Text = "AGREGAR STOCK";
            // 
            // nupCantidad
            // 
            this.nupCantidad.Location = new System.Drawing.Point(250, 323);
            this.nupCantidad.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.nupCantidad.Name = "nupCantidad";
            this.nupCantidad.Size = new System.Drawing.Size(75, 20);
            this.nupCantidad.TabIndex = 116;
            // 
            // cbxTitulo
            // 
            this.cbxTitulo.FormattingEnabled = true;
            this.cbxTitulo.Location = new System.Drawing.Point(250, 263);
            this.cbxTitulo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbxTitulo.Name = "cbxTitulo";
            this.cbxTitulo.Size = new System.Drawing.Size(180, 21);
            this.cbxTitulo.TabIndex = 115;
            this.cbxTitulo.SelectedIndexChanged += new System.EventHandler(this.cbxTitulo_SelectedIndexChanged);
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft JhengHei", 9.75F);
            this.lblTitulo.Location = new System.Drawing.Point(183, 268);
            this.lblTitulo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(45, 17);
            this.lblTitulo.TabIndex = 114;
            this.lblTitulo.Text = "Título:";
            // 
            // cbxNombreTienda
            // 
            this.cbxNombreTienda.FormattingEnabled = true;
            this.cbxNombreTienda.Location = new System.Drawing.Point(250, 141);
            this.cbxNombreTienda.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbxNombreTienda.Name = "cbxNombreTienda";
            this.cbxNombreTienda.Size = new System.Drawing.Size(180, 21);
            this.cbxNombreTienda.TabIndex = 113;
            this.cbxNombreTienda.SelectedIndexChanged += new System.EventHandler(this.cbxNombreTienda_SelectedIndexChanged);
            // 
            // lblNombreTienda
            // 
            this.lblNombreTienda.AutoSize = true;
            this.lblNombreTienda.Font = new System.Drawing.Font("Microsoft JhengHei", 9.75F);
            this.lblNombreTienda.Location = new System.Drawing.Point(102, 146);
            this.lblNombreTienda.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNombreTienda.Name = "lblNombreTienda";
            this.lblNombreTienda.Size = new System.Drawing.Size(104, 17);
            this.lblNombreTienda.TabIndex = 112;
            this.lblNombreTienda.Text = "Nombre Tienda:";
            // 
            // cbxIdTienda
            // 
            this.cbxIdTienda.FormattingEnabled = true;
            this.cbxIdTienda.Location = new System.Drawing.Point(250, 83);
            this.cbxIdTienda.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbxIdTienda.Name = "cbxIdTienda";
            this.cbxIdTienda.Size = new System.Drawing.Size(180, 21);
            this.cbxIdTienda.TabIndex = 111;
            this.cbxIdTienda.SelectedIndexChanged += new System.EventHandler(this.cbxIdTienda_SelectedIndexChanged);
            // 
            // lblIdTienda
            // 
            this.lblIdTienda.AutoSize = true;
            this.lblIdTienda.Font = new System.Drawing.Font("Microsoft JhengHei", 9.75F);
            this.lblIdTienda.Location = new System.Drawing.Point(154, 88);
            this.lblIdTienda.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblIdTienda.Name = "lblIdTienda";
            this.lblIdTienda.Size = new System.Drawing.Size(66, 17);
            this.lblIdTienda.TabIndex = 110;
            this.lblIdTienda.Text = "Id Tienda:";
            // 
            // cbxIdTitulo
            // 
            this.cbxIdTitulo.FormattingEnabled = true;
            this.cbxIdTitulo.Location = new System.Drawing.Point(250, 207);
            this.cbxIdTitulo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbxIdTitulo.Name = "cbxIdTitulo";
            this.cbxIdTitulo.Size = new System.Drawing.Size(180, 21);
            this.cbxIdTitulo.TabIndex = 109;
            this.cbxIdTitulo.SelectedIndexChanged += new System.EventHandler(this.cbxIdTitulo_SelectedIndexChanged);
            // 
            // btnRegresar
            // 
            this.btnRegresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegresar.Font = new System.Drawing.Font("Microsoft JhengHei", 9.75F);
            this.btnRegresar.Location = new System.Drawing.Point(347, 397);
            this.btnRegresar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.Size = new System.Drawing.Size(112, 33);
            this.btnRegresar.TabIndex = 108;
            this.btnRegresar.Text = "Regresar";
            this.btnRegresar.UseVisualStyleBackColor = true;
            this.btnRegresar.Click += new System.EventHandler(this.btnRegresar_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregar.Font = new System.Drawing.Font("Microsoft JhengHei", 9.75F);
            this.btnAgregar.Location = new System.Drawing.Point(202, 397);
            this.btnAgregar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(112, 33);
            this.btnAgregar.TabIndex = 107;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // lblIdTitulo
            // 
            this.lblIdTitulo.AutoSize = true;
            this.lblIdTitulo.Font = new System.Drawing.Font("Microsoft JhengHei", 9.75F);
            this.lblIdTitulo.Location = new System.Drawing.Point(163, 212);
            this.lblIdTitulo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblIdTitulo.Name = "lblIdTitulo";
            this.lblIdTitulo.Size = new System.Drawing.Size(60, 17);
            this.lblIdTitulo.TabIndex = 106;
            this.lblIdTitulo.Text = "Id Titulo:";
            // 
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.Font = new System.Drawing.Font("Microsoft JhengHei", 9.75F);
            this.lblCantidad.Location = new System.Drawing.Point(157, 328);
            this.lblCantidad.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(66, 17);
            this.lblCantidad.TabIndex = 105;
            this.lblCantidad.Text = "Cantidad:";
            // 
            // frmAltaStock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(513, 461);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nupCantidad);
            this.Controls.Add(this.cbxTitulo);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.cbxNombreTienda);
            this.Controls.Add(this.lblNombreTienda);
            this.Controls.Add(this.cbxIdTienda);
            this.Controls.Add(this.lblIdTienda);
            this.Controls.Add(this.cbxIdTitulo);
            this.Controls.Add(this.btnRegresar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.lblIdTitulo);
            this.Controls.Add(this.lblCantidad);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmAltaStock";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmAltaStock";
            this.Load += new System.EventHandler(this.frmAltaStock_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nupCantidad)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown nupCantidad;
        private System.Windows.Forms.ComboBox cbxTitulo;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.ComboBox cbxNombreTienda;
        private System.Windows.Forms.Label lblNombreTienda;
        private System.Windows.Forms.ComboBox cbxIdTienda;
        private System.Windows.Forms.Label lblIdTienda;
        private System.Windows.Forms.ComboBox cbxIdTitulo;
        private System.Windows.Forms.Button btnRegresar;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Label lblIdTitulo;
        private System.Windows.Forms.Label lblCantidad;
    }
}