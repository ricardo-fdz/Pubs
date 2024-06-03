namespace Pubs
{
    partial class frmModificarEmpleados
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
            this.btnModificar = new System.Windows.Forms.Button();
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
            this.label1.Location = new System.Drawing.Point(30, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(288, 29);
            this.label1.TabIndex = 115;
            this.label1.Text = "MODIFICAR EMPLEADOS";
            // 
            // txtIdEmpleados
            // 
            this.txtIdEmpleados.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtIdEmpleados.Location = new System.Drawing.Point(202, 136);
            this.txtIdEmpleados.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtIdEmpleados.MaxLength = 9;
            this.txtIdEmpleados.Name = "txtIdEmpleados";
            this.txtIdEmpleados.ReadOnly = true;
            this.txtIdEmpleados.Size = new System.Drawing.Size(98, 20);
            this.txtIdEmpleados.TabIndex = 93;
            // 
            // dtpFechaContratacion
            // 
            this.dtpFechaContratacion.Location = new System.Drawing.Point(653, 328);
            this.dtpFechaContratacion.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dtpFechaContratacion.Name = "dtpFechaContratacion";
            this.dtpFechaContratacion.Size = new System.Drawing.Size(287, 20);
            this.dtpFechaContratacion.TabIndex = 114;
            // 
            // cbxEditorial
            // 
            this.cbxEditorial.FormattingEnabled = true;
            this.cbxEditorial.Location = new System.Drawing.Point(653, 258);
            this.cbxEditorial.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbxEditorial.Name = "cbxEditorial";
            this.cbxEditorial.Size = new System.Drawing.Size(180, 21);
            this.cbxEditorial.TabIndex = 113;
            this.cbxEditorial.SelectedIndexChanged += new System.EventHandler(this.cbxEditorial_SelectedIndexChanged);
            // 
            // lblEditorial
            // 
            this.lblEditorial.AutoSize = true;
            this.lblEditorial.Location = new System.Drawing.Point(575, 266);
            this.lblEditorial.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEditorial.Name = "lblEditorial";
            this.lblEditorial.Size = new System.Drawing.Size(47, 13);
            this.lblEditorial.TabIndex = 112;
            this.lblEditorial.Text = "Editorial:";
            // 
            // cbxPuesto
            // 
            this.cbxPuesto.FormattingEnabled = true;
            this.cbxPuesto.Location = new System.Drawing.Point(202, 424);
            this.cbxPuesto.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbxPuesto.Name = "cbxPuesto";
            this.cbxPuesto.Size = new System.Drawing.Size(180, 21);
            this.cbxPuesto.TabIndex = 111;
            this.cbxPuesto.SelectedIndexChanged += new System.EventHandler(this.cbxPuesto_SelectedIndexChanged);
            this.cbxPuesto.RightToLeftChanged += new System.EventHandler(this.cbxPuesto_RightToLeftChanged);
            // 
            // lblPuesto
            // 
            this.lblPuesto.AutoSize = true;
            this.lblPuesto.Location = new System.Drawing.Point(135, 432);
            this.lblPuesto.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPuesto.Name = "lblPuesto";
            this.lblPuesto.Size = new System.Drawing.Size(43, 13);
            this.lblPuesto.TabIndex = 110;
            this.lblPuesto.Text = "Puesto:";
            // 
            // cbxIdTrabajo
            // 
            this.cbxIdTrabajo.FormattingEnabled = true;
            this.cbxIdTrabajo.Location = new System.Drawing.Point(202, 372);
            this.cbxIdTrabajo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbxIdTrabajo.Name = "cbxIdTrabajo";
            this.cbxIdTrabajo.Size = new System.Drawing.Size(180, 21);
            this.cbxIdTrabajo.TabIndex = 109;
            this.cbxIdTrabajo.SelectedIndexChanged += new System.EventHandler(this.cbxIdTrabajo_SelectedIndexChanged);
            // 
            // lblIdTrabajo
            // 
            this.lblIdTrabajo.AutoSize = true;
            this.lblIdTrabajo.Location = new System.Drawing.Point(112, 380);
            this.lblIdTrabajo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblIdTrabajo.Name = "lblIdTrabajo";
            this.lblIdTrabajo.Size = new System.Drawing.Size(58, 13);
            this.lblIdTrabajo.TabIndex = 108;
            this.lblIdTrabajo.Text = "Id Trabajo:";
            // 
            // lblInicial
            // 
            this.lblInicial.AutoSize = true;
            this.lblInicial.Location = new System.Drawing.Point(142, 266);
            this.lblInicial.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblInicial.Name = "lblInicial";
            this.lblInicial.Size = new System.Drawing.Size(37, 13);
            this.lblInicial.TabIndex = 107;
            this.lblInicial.Text = "Inicial:";
            // 
            // txtInicial
            // 
            this.txtInicial.Location = new System.Drawing.Point(202, 258);
            this.txtInicial.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtInicial.MaxLength = 1;
            this.txtInicial.Name = "txtInicial";
            this.txtInicial.Size = new System.Drawing.Size(40, 20);
            this.txtInicial.TabIndex = 106;
            // 
            // cbxIdPub
            // 
            this.cbxIdPub.FormattingEnabled = true;
            this.cbxIdPub.Location = new System.Drawing.Point(653, 202);
            this.cbxIdPub.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbxIdPub.Name = "cbxIdPub";
            this.cbxIdPub.Size = new System.Drawing.Size(180, 21);
            this.cbxIdPub.TabIndex = 105;
            this.cbxIdPub.SelectedIndexChanged += new System.EventHandler(this.cbxIdPub_SelectedIndexChanged);
            // 
            // btnRegresar
            // 
            this.btnRegresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegresar.Location = new System.Drawing.Point(800, 418);
            this.btnRegresar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.Size = new System.Drawing.Size(112, 33);
            this.btnRegresar.TabIndex = 104;
            this.btnRegresar.Text = "Regresar";
            this.btnRegresar.UseVisualStyleBackColor = true;
            this.btnRegresar.Click += new System.EventHandler(this.btnRegresar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModificar.Location = new System.Drawing.Point(653, 418);
            this.btnModificar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(112, 33);
            this.btnModificar.TabIndex = 103;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // lblFechaContratación
            // 
            this.lblFechaContratación.AutoSize = true;
            this.lblFechaContratación.Location = new System.Drawing.Point(500, 336);
            this.lblFechaContratación.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFechaContratación.Name = "lblFechaContratación";
            this.lblFechaContratación.Size = new System.Drawing.Size(103, 13);
            this.lblFechaContratación.TabIndex = 102;
            this.lblFechaContratación.Text = "Fecha Contratación:";
            // 
            // lblIdPub
            // 
            this.lblIdPub.AutoSize = true;
            this.lblIdPub.Location = new System.Drawing.Point(588, 210);
            this.lblIdPub.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblIdPub.Name = "lblIdPub";
            this.lblIdPub.Size = new System.Drawing.Size(41, 13);
            this.lblIdPub.TabIndex = 101;
            this.lblIdPub.Text = "Id Pub:";
            // 
            // lblNivel
            // 
            this.lblNivel.AutoSize = true;
            this.lblNivel.Location = new System.Drawing.Point(597, 154);
            this.lblNivel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNivel.Name = "lblNivel";
            this.lblNivel.Size = new System.Drawing.Size(34, 13);
            this.lblNivel.TabIndex = 100;
            this.lblNivel.Text = "Nivel:";
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Location = new System.Drawing.Point(124, 322);
            this.lblApellido.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(47, 13);
            this.lblApellido.TabIndex = 99;
            this.lblApellido.Text = "Apellido:";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(124, 199);
            this.lblNombre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(47, 13);
            this.lblNombre.TabIndex = 98;
            this.lblNombre.Text = "Nombre:";
            // 
            // lblIdAutor
            // 
            this.lblIdAutor.AutoSize = true;
            this.lblIdAutor.Location = new System.Drawing.Point(168, 144);
            this.lblIdAutor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblIdAutor.Name = "lblIdAutor";
            this.lblIdAutor.Size = new System.Drawing.Size(19, 13);
            this.lblIdAutor.TabIndex = 97;
            this.lblIdAutor.Text = "Id:";
            // 
            // txtNivel
            // 
            this.txtNivel.Location = new System.Drawing.Point(653, 146);
            this.txtNivel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtNivel.MaxLength = 255;
            this.txtNivel.Name = "txtNivel";
            this.txtNivel.Size = new System.Drawing.Size(113, 20);
            this.txtNivel.TabIndex = 96;
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(202, 314);
            this.txtApellido.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtApellido.MaxLength = 30;
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(180, 20);
            this.txtApellido.TabIndex = 95;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(202, 191);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtNombre.MaxLength = 20;
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(180, 20);
            this.txtNombre.TabIndex = 94;
            // 
            // frmModificarEmpleados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(970, 502);
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
            this.Controls.Add(this.btnModificar);
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
            this.Name = "frmModificarEmpleados";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmModificarEmpleados";
            this.Load += new System.EventHandler(this.frmModificarEmpleados_Load);
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
        private System.Windows.Forms.Button btnModificar;
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