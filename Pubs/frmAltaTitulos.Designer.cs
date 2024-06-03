namespace Pubs
{
    partial class frmAltaTitulos
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
            this.label2 = new System.Windows.Forms.Label();
            this.nupPrecio = new System.Windows.Forms.NumericUpDown();
            this.nupYtd = new System.Windows.Forms.NumericUpDown();
            this.nupRegalias = new System.Windows.Forms.NumericUpDown();
            this.nupAnticipo = new System.Windows.Forms.NumericUpDown();
            this.txtId = new System.Windows.Forms.TextBox();
            this.rtxtNotas = new System.Windows.Forms.RichTextBox();
            this.dtpPublicacion = new System.Windows.Forms.DateTimePicker();
            this.lblNotas = new System.Windows.Forms.Label();
            this.lblPublicacion = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbPub = new System.Windows.Forms.ComboBox();
            this.cbIdPub = new System.Windows.Forms.ComboBox();
            this.btnRegresar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.lblCodigoPostal = new System.Windows.Forms.Label();
            this.lblRegalias = new System.Windows.Forms.Label();
            this.lblCiudad = new System.Windows.Forms.Label();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.lblTelefono = new System.Windows.Forms.Label();
            this.lblTipo = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblIdAutor = new System.Windows.Forms.Label();
            this.txtTipo = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.nupPrecio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupYtd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupRegalias)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupAnticipo)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft JhengHei", 17F);
            this.label2.Location = new System.Drawing.Point(15, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(170, 29);
            this.label2.TabIndex = 93;
            this.label2.Text = "ALTA TITULOS";
            // 
            // nupPrecio
            // 
            this.nupPrecio.DecimalPlaces = 2;
            this.nupPrecio.Location = new System.Drawing.Point(611, 75);
            this.nupPrecio.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.nupPrecio.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.nupPrecio.Name = "nupPrecio";
            this.nupPrecio.Size = new System.Drawing.Size(126, 20);
            this.nupPrecio.TabIndex = 92;
            // 
            // nupYtd
            // 
            this.nupYtd.Location = new System.Drawing.Point(611, 234);
            this.nupYtd.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.nupYtd.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.nupYtd.Name = "nupYtd";
            this.nupYtd.Size = new System.Drawing.Size(130, 20);
            this.nupYtd.TabIndex = 77;
            // 
            // nupRegalias
            // 
            this.nupRegalias.DecimalPlaces = 2;
            this.nupRegalias.Location = new System.Drawing.Point(611, 178);
            this.nupRegalias.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.nupRegalias.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.nupRegalias.Name = "nupRegalias";
            this.nupRegalias.Size = new System.Drawing.Size(130, 20);
            this.nupRegalias.TabIndex = 76;
            // 
            // nupAnticipo
            // 
            this.nupAnticipo.DecimalPlaces = 2;
            this.nupAnticipo.Location = new System.Drawing.Point(611, 120);
            this.nupAnticipo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.nupAnticipo.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.nupAnticipo.Name = "nupAnticipo";
            this.nupAnticipo.Size = new System.Drawing.Size(126, 20);
            this.nupAnticipo.TabIndex = 75;
            // 
            // txtId
            // 
            this.txtId.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtId.Location = new System.Drawing.Point(135, 74);
            this.txtId.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtId.MaxLength = 6;
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(180, 20);
            this.txtId.TabIndex = 69;
            // 
            // rtxtNotas
            // 
            this.rtxtNotas.Location = new System.Drawing.Point(135, 333);
            this.rtxtNotas.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rtxtNotas.MaxLength = 200;
            this.rtxtNotas.Name = "rtxtNotas";
            this.rtxtNotas.Size = new System.Drawing.Size(234, 138);
            this.rtxtNotas.TabIndex = 74;
            this.rtxtNotas.Text = "";
            // 
            // dtpPublicacion
            // 
            this.dtpPublicacion.Location = new System.Drawing.Point(611, 288);
            this.dtpPublicacion.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dtpPublicacion.Name = "dtpPublicacion";
            this.dtpPublicacion.Size = new System.Drawing.Size(283, 20);
            this.dtpPublicacion.TabIndex = 78;
            // 
            // lblNotas
            // 
            this.lblNotas.AutoSize = true;
            this.lblNotas.Location = new System.Drawing.Point(74, 336);
            this.lblNotas.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNotas.Name = "lblNotas";
            this.lblNotas.Size = new System.Drawing.Size(38, 13);
            this.lblNotas.TabIndex = 91;
            this.lblNotas.Text = "Notas:";
            // 
            // lblPublicacion
            // 
            this.lblPublicacion.AutoSize = true;
            this.lblPublicacion.Location = new System.Drawing.Point(446, 296);
            this.lblPublicacion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPublicacion.Name = "lblPublicacion";
            this.lblPublicacion.Size = new System.Drawing.Size(112, 13);
            this.lblPublicacion.TabIndex = 90;
            this.lblPublicacion.Text = "Fecha de publicación:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(88, 294);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 89;
            this.label1.Text = "Pub:";
            // 
            // cbPub
            // 
            this.cbPub.FormattingEnabled = true;
            this.cbPub.Location = new System.Drawing.Point(135, 286);
            this.cbPub.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbPub.Name = "cbPub";
            this.cbPub.Size = new System.Drawing.Size(180, 21);
            this.cbPub.TabIndex = 73;
            this.cbPub.SelectedIndexChanged += new System.EventHandler(this.cbPub_SelectedIndexChanged);
            // 
            // cbIdPub
            // 
            this.cbIdPub.FormattingEnabled = true;
            this.cbIdPub.Location = new System.Drawing.Point(135, 234);
            this.cbIdPub.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbIdPub.Name = "cbIdPub";
            this.cbIdPub.Size = new System.Drawing.Size(180, 21);
            this.cbIdPub.TabIndex = 72;
            this.cbIdPub.SelectedIndexChanged += new System.EventHandler(this.cbIdPub_SelectedIndexChanged);
            // 
            // btnRegresar
            // 
            this.btnRegresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegresar.Location = new System.Drawing.Point(690, 395);
            this.btnRegresar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.Size = new System.Drawing.Size(112, 33);
            this.btnRegresar.TabIndex = 80;
            this.btnRegresar.Text = "Regresar";
            this.btnRegresar.UseVisualStyleBackColor = true;
            this.btnRegresar.Click += new System.EventHandler(this.btnRegresar_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregar.Location = new System.Drawing.Point(540, 395);
            this.btnAgregar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(112, 33);
            this.btnAgregar.TabIndex = 79;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // lblCodigoPostal
            // 
            this.lblCodigoPostal.AutoSize = true;
            this.lblCodigoPostal.Location = new System.Drawing.Point(417, 242);
            this.lblCodigoPostal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCodigoPostal.Name = "lblCodigoPostal";
            this.lblCodigoPostal.Size = new System.Drawing.Size(130, 13);
            this.lblCodigoPostal.TabIndex = 88;
            this.lblCodigoPostal.Text = "Ventas del año hasta hoy:";
            // 
            // lblRegalias
            // 
            this.lblRegalias.AutoSize = true;
            this.lblRegalias.Location = new System.Drawing.Point(532, 186);
            this.lblRegalias.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRegalias.Name = "lblRegalias";
            this.lblRegalias.Size = new System.Drawing.Size(51, 13);
            this.lblRegalias.TabIndex = 87;
            this.lblRegalias.Text = "Regalias:";
            // 
            // lblCiudad
            // 
            this.lblCiudad.AutoSize = true;
            this.lblCiudad.Location = new System.Drawing.Point(534, 128);
            this.lblCiudad.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCiudad.Name = "lblCiudad";
            this.lblCiudad.Size = new System.Drawing.Size(48, 13);
            this.lblCiudad.TabIndex = 86;
            this.lblCiudad.Text = "Anticipo:";
            // 
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.Location = new System.Drawing.Point(548, 83);
            this.lblPrecio.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(40, 13);
            this.lblPrecio.TabIndex = 85;
            this.lblPrecio.Text = "Precio:";
            // 
            // lblTelefono
            // 
            this.lblTelefono.AutoSize = true;
            this.lblTelefono.Location = new System.Drawing.Point(70, 242);
            this.lblTelefono.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTelefono.Name = "lblTelefono";
            this.lblTelefono.Size = new System.Drawing.Size(41, 13);
            this.lblTelefono.TabIndex = 84;
            this.lblTelefono.Text = "Id Pub:";
            // 
            // lblTipo
            // 
            this.lblTipo.AutoSize = true;
            this.lblTipo.Location = new System.Drawing.Point(85, 186);
            this.lblTipo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Size = new System.Drawing.Size(31, 13);
            this.lblTipo.TabIndex = 83;
            this.lblTipo.Text = "Tipo:";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(14, 128);
            this.lblNombre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(76, 13);
            this.lblNombre.TabIndex = 82;
            this.lblNombre.Text = "Nombre Titulo:";
            // 
            // lblIdAutor
            // 
            this.lblIdAutor.AutoSize = true;
            this.lblIdAutor.Location = new System.Drawing.Point(101, 82);
            this.lblIdAutor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblIdAutor.Name = "lblIdAutor";
            this.lblIdAutor.Size = new System.Drawing.Size(19, 13);
            this.lblIdAutor.TabIndex = 81;
            this.lblIdAutor.Text = "Id:";
            // 
            // txtTipo
            // 
            this.txtTipo.Location = new System.Drawing.Point(135, 178);
            this.txtTipo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtTipo.MaxLength = 12;
            this.txtTipo.Name = "txtTipo";
            this.txtTipo.Size = new System.Drawing.Size(180, 20);
            this.txtTipo.TabIndex = 71;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(135, 120);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtNombre.MaxLength = 80;
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(180, 20);
            this.txtNombre.TabIndex = 70;
            // 
            // frmAltaTitulos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(908, 491);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.nupPrecio);
            this.Controls.Add(this.nupYtd);
            this.Controls.Add(this.nupRegalias);
            this.Controls.Add(this.nupAnticipo);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.rtxtNotas);
            this.Controls.Add(this.dtpPublicacion);
            this.Controls.Add(this.lblNotas);
            this.Controls.Add(this.lblPublicacion);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbPub);
            this.Controls.Add(this.cbIdPub);
            this.Controls.Add(this.btnRegresar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.lblCodigoPostal);
            this.Controls.Add(this.lblRegalias);
            this.Controls.Add(this.lblCiudad);
            this.Controls.Add(this.lblPrecio);
            this.Controls.Add(this.lblTelefono);
            this.Controls.Add(this.lblTipo);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.lblIdAutor);
            this.Controls.Add(this.txtTipo);
            this.Controls.Add(this.txtNombre);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmAltaTitulos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmAltaTitulos";
            this.Load += new System.EventHandler(this.frmAltaTitulos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nupPrecio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupYtd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupRegalias)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupAnticipo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown nupPrecio;
        private System.Windows.Forms.NumericUpDown nupYtd;
        private System.Windows.Forms.NumericUpDown nupRegalias;
        private System.Windows.Forms.NumericUpDown nupAnticipo;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.RichTextBox rtxtNotas;
        private System.Windows.Forms.DateTimePicker dtpPublicacion;
        private System.Windows.Forms.Label lblNotas;
        private System.Windows.Forms.Label lblPublicacion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbPub;
        private System.Windows.Forms.ComboBox cbIdPub;
        private System.Windows.Forms.Button btnRegresar;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Label lblCodigoPostal;
        private System.Windows.Forms.Label lblRegalias;
        private System.Windows.Forms.Label lblCiudad;
        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.Label lblTelefono;
        private System.Windows.Forms.Label lblTipo;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblIdAutor;
        private System.Windows.Forms.TextBox txtTipo;
        private System.Windows.Forms.TextBox txtNombre;
    }
}