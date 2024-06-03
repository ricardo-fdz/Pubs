namespace Pubs
{
    partial class frmAltaEmpleados
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
            this.txtIdEmpleados = new System.Windows.Forms.TextBox();
            this.dtpFechaContratacion = new System.Windows.Forms.DateTimePicker();
            this.cbxEditorial = new System.Windows.Forms.ComboBox();
            this.lblEditorial = new System.Windows.Forms.Label();
            this.cbxPuesto = new System.Windows.Forms.ComboBox();
            this.lblPuesto = new System.Windows.Forms.Label();
            this.cbxIdTrabajo = new System.Windows.Forms.ComboBox();
            this.lblIdTrabajo = new System.Windows.Forms.Label();
            this.lblInicial = new System.Windows.Forms.Label();
            this.txtInicial = new System.Windows.Forms.TextBox();
            this.cbxIdPub = new System.Windows.Forms.ComboBox();
            this.btnRegresar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.lblFechaContratación = new System.Windows.Forms.Label();
            this.lblIdPub = new System.Windows.Forms.Label();
            this.lblNivel = new System.Windows.Forms.Label();
            this.lblApellido = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblIdAutor = new System.Windows.Forms.Label();
            this.txtNivel = new System.Windows.Forms.TextBox();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft JhengHei", 17F);
            this.label1.Location = new System.Drawing.Point(41, 26);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(215, 29);
            this.label1.TabIndex = 93;
            this.label1.Text = "ALTA EMPLEADOS";
            // 
            // txtIdEmpleados
            // 
            this.txtIdEmpleados.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtIdEmpleados.Location = new System.Drawing.Point(214, 94);
            this.txtIdEmpleados.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtIdEmpleados.MaxLength = 9;
            this.txtIdEmpleados.Name = "txtIdEmpleados";
            this.txtIdEmpleados.Size = new System.Drawing.Size(83, 20);
            this.txtIdEmpleados.TabIndex = 71;
            // 
            // dtpFechaContratacion
            // 
            this.dtpFechaContratacion.Location = new System.Drawing.Point(657, 287);
            this.dtpFechaContratacion.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dtpFechaContratacion.Name = "dtpFechaContratacion";
            this.dtpFechaContratacion.Size = new System.Drawing.Size(280, 20);
            this.dtpFechaContratacion.TabIndex = 92;
            // 
            // cbxEditorial
            // 
            this.cbxEditorial.FormattingEnabled = true;
            this.cbxEditorial.Location = new System.Drawing.Point(657, 216);
            this.cbxEditorial.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbxEditorial.Name = "cbxEditorial";
            this.cbxEditorial.Size = new System.Drawing.Size(180, 21);
            this.cbxEditorial.TabIndex = 91;
            this.cbxEditorial.SelectedIndexChanged += new System.EventHandler(this.cbxEditorial_SelectedIndexChanged);
            // 
            // lblEditorial
            // 
            this.lblEditorial.AutoSize = true;
            this.lblEditorial.Font = new System.Drawing.Font("Microsoft JhengHei", 9.75F);
            this.lblEditorial.Location = new System.Drawing.Point(571, 221);
            this.lblEditorial.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEditorial.Name = "lblEditorial";
            this.lblEditorial.Size = new System.Drawing.Size(60, 17);
            this.lblEditorial.TabIndex = 90;
            this.lblEditorial.Text = "Editorial:";
            // 
            // cbxPuesto
            // 
            this.cbxPuesto.FormattingEnabled = true;
            this.cbxPuesto.Location = new System.Drawing.Point(214, 387);
            this.cbxPuesto.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbxPuesto.Name = "cbxPuesto";
            this.cbxPuesto.Size = new System.Drawing.Size(180, 21);
            this.cbxPuesto.TabIndex = 89;
            this.cbxPuesto.SelectedIndexChanged += new System.EventHandler(this.cbxPuesto_SelectedIndexChanged);
            // 
            // lblPuesto
            // 
            this.lblPuesto.AutoSize = true;
            this.lblPuesto.Font = new System.Drawing.Font("Microsoft JhengHei", 9.75F);
            this.lblPuesto.Location = new System.Drawing.Point(137, 392);
            this.lblPuesto.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPuesto.Name = "lblPuesto";
            this.lblPuesto.Size = new System.Drawing.Size(53, 17);
            this.lblPuesto.TabIndex = 88;
            this.lblPuesto.Text = "Puesto:";
            // 
            // cbxIdTrabajo
            // 
            this.cbxIdTrabajo.FormattingEnabled = true;
            this.cbxIdTrabajo.Location = new System.Drawing.Point(214, 328);
            this.cbxIdTrabajo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbxIdTrabajo.Name = "cbxIdTrabajo";
            this.cbxIdTrabajo.Size = new System.Drawing.Size(180, 21);
            this.cbxIdTrabajo.TabIndex = 87;
            this.cbxIdTrabajo.SelectedIndexChanged += new System.EventHandler(this.cbxIdTrabajo_SelectedIndexChanged);
            // 
            // lblIdTrabajo
            // 
            this.lblIdTrabajo.AutoSize = true;
            this.lblIdTrabajo.Font = new System.Drawing.Font("Microsoft JhengHei", 9.75F);
            this.lblIdTrabajo.Location = new System.Drawing.Point(112, 330);
            this.lblIdTrabajo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblIdTrabajo.Name = "lblIdTrabajo";
            this.lblIdTrabajo.Size = new System.Drawing.Size(71, 17);
            this.lblIdTrabajo.TabIndex = 86;
            this.lblIdTrabajo.Text = "Id Trabajo:";
            // 
            // lblInicial
            // 
            this.lblInicial.AutoSize = true;
            this.lblInicial.Font = new System.Drawing.Font("Microsoft JhengHei", 9.75F);
            this.lblInicial.Location = new System.Drawing.Point(148, 221);
            this.lblInicial.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblInicial.Name = "lblInicial";
            this.lblInicial.Size = new System.Drawing.Size(45, 17);
            this.lblInicial.TabIndex = 85;
            this.lblInicial.Text = "Inicial:";
            // 
            // txtInicial
            // 
            this.txtInicial.Location = new System.Drawing.Point(214, 216);
            this.txtInicial.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtInicial.MaxLength = 1;
            this.txtInicial.Name = "txtInicial";
            this.txtInicial.Size = new System.Drawing.Size(40, 20);
            this.txtInicial.TabIndex = 84;
            // 
            // cbxIdPub
            // 
            this.cbxIdPub.FormattingEnabled = true;
            this.cbxIdPub.Location = new System.Drawing.Point(657, 161);
            this.cbxIdPub.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbxIdPub.Name = "cbxIdPub";
            this.cbxIdPub.Size = new System.Drawing.Size(161, 21);
            this.cbxIdPub.TabIndex = 83;
            this.cbxIdPub.SelectedIndexChanged += new System.EventHandler(this.cbxIdPub_SelectedIndexChanged);
            // 
            // btnRegresar
            // 
            this.btnRegresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegresar.Font = new System.Drawing.Font("Microsoft JhengHei", 9.75F);
            this.btnRegresar.Location = new System.Drawing.Point(804, 381);
            this.btnRegresar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.Size = new System.Drawing.Size(100, 33);
            this.btnRegresar.TabIndex = 82;
            this.btnRegresar.Text = "Regresar";
            this.btnRegresar.UseVisualStyleBackColor = true;
            this.btnRegresar.Click += new System.EventHandler(this.btnRegresar_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregar.Font = new System.Drawing.Font("Microsoft JhengHei", 9.75F);
            this.btnAgregar.Location = new System.Drawing.Point(657, 381);
            this.btnAgregar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(110, 33);
            this.btnAgregar.TabIndex = 81;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // lblFechaContratación
            // 
            this.lblFechaContratación.AutoSize = true;
            this.lblFechaContratación.Font = new System.Drawing.Font("Microsoft JhengHei", 9.75F);
            this.lblFechaContratación.Location = new System.Drawing.Point(484, 292);
            this.lblFechaContratación.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFechaContratación.Name = "lblFechaContratación";
            this.lblFechaContratación.Size = new System.Drawing.Size(128, 17);
            this.lblFechaContratación.TabIndex = 80;
            this.lblFechaContratación.Text = "Fecha Contratación:";
            // 
            // lblIdPub
            // 
            this.lblIdPub.AutoSize = true;
            this.lblIdPub.Font = new System.Drawing.Font("Microsoft JhengHei", 9.75F);
            this.lblIdPub.Location = new System.Drawing.Point(584, 166);
            this.lblIdPub.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblIdPub.Name = "lblIdPub";
            this.lblIdPub.Size = new System.Drawing.Size(50, 17);
            this.lblIdPub.TabIndex = 79;
            this.lblIdPub.Text = "Id Pub:";
            // 
            // lblNivel
            // 
            this.lblNivel.AutoSize = true;
            this.lblNivel.Font = new System.Drawing.Font("Microsoft JhengHei", 9.75F);
            this.lblNivel.Location = new System.Drawing.Point(594, 110);
            this.lblNivel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNivel.Name = "lblNivel";
            this.lblNivel.Size = new System.Drawing.Size(41, 17);
            this.lblNivel.TabIndex = 78;
            this.lblNivel.Text = "Nivel:";
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Font = new System.Drawing.Font("Microsoft JhengHei", 9.75F);
            this.lblApellido.Location = new System.Drawing.Point(125, 275);
            this.lblApellido.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(60, 17);
            this.lblApellido.TabIndex = 77;
            this.lblApellido.Text = "Apellido:";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Microsoft JhengHei", 9.75F);
            this.lblNombre.Location = new System.Drawing.Point(125, 153);
            this.lblNombre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(61, 17);
            this.lblNombre.TabIndex = 76;
            this.lblNombre.Text = "Nombre:";
            // 
            // lblIdAutor
            // 
            this.lblIdAutor.AutoSize = true;
            this.lblIdAutor.Font = new System.Drawing.Font("Microsoft JhengHei", 9.75F);
            this.lblIdAutor.Location = new System.Drawing.Point(176, 99);
            this.lblIdAutor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblIdAutor.Name = "lblIdAutor";
            this.lblIdAutor.Size = new System.Drawing.Size(23, 17);
            this.lblIdAutor.TabIndex = 75;
            this.lblIdAutor.Text = "Id:";
            // 
            // txtNivel
            // 
            this.txtNivel.Location = new System.Drawing.Point(657, 105);
            this.txtNivel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtNivel.MaxLength = 255;
            this.txtNivel.Name = "txtNivel";
            this.txtNivel.Size = new System.Drawing.Size(113, 20);
            this.txtNivel.TabIndex = 74;
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(214, 270);
            this.txtApellido.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtApellido.MaxLength = 30;
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(180, 20);
            this.txtApellido.TabIndex = 73;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(214, 148);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtNombre.MaxLength = 20;
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(180, 20);
            this.txtNombre.TabIndex = 72;
            // 
            // frmAltaEmpleados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(978, 440);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtIdEmpleados);
            this.Controls.Add(this.dtpFechaContratacion);
            this.Controls.Add(this.cbxEditorial);
            this.Controls.Add(this.lblEditorial);
            this.Controls.Add(this.cbxPuesto);
            this.Controls.Add(this.lblPuesto);
            this.Controls.Add(this.cbxIdTrabajo);
            this.Controls.Add(this.lblIdTrabajo);
            this.Controls.Add(this.lblInicial);
            this.Controls.Add(this.txtInicial);
            this.Controls.Add(this.cbxIdPub);
            this.Controls.Add(this.btnRegresar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.lblFechaContratación);
            this.Controls.Add(this.lblIdPub);
            this.Controls.Add(this.lblNivel);
            this.Controls.Add(this.lblApellido);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.lblIdAutor);
            this.Controls.Add(this.txtNivel);
            this.Controls.Add(this.txtApellido);
            this.Controls.Add(this.txtNombre);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmAltaEmpleados";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmAltaEmpleados";
            this.Load += new System.EventHandler(this.frmAltaEmpleados_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtIdEmpleados;
        private System.Windows.Forms.DateTimePicker dtpFechaContratacion;
        private System.Windows.Forms.ComboBox cbxEditorial;
        private System.Windows.Forms.Label lblEditorial;
        private System.Windows.Forms.ComboBox cbxPuesto;
        private System.Windows.Forms.Label lblPuesto;
        private System.Windows.Forms.ComboBox cbxIdTrabajo;
        private System.Windows.Forms.Label lblIdTrabajo;
        private System.Windows.Forms.Label lblInicial;
        private System.Windows.Forms.TextBox txtInicial;
        private System.Windows.Forms.ComboBox cbxIdPub;
        private System.Windows.Forms.Button btnRegresar;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Label lblFechaContratación;
        private System.Windows.Forms.Label lblIdPub;
        private System.Windows.Forms.Label lblNivel;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblIdAutor;
        private System.Windows.Forms.TextBox txtNivel;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.TextBox txtNombre;
    }
}