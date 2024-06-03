namespace Pubs
{
    partial class frmEmpleados
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
            this.cbxFiltrarNombre = new System.Windows.Forms.ComboBox();
            this.lblFiltrar = new System.Windows.Forms.Label();
            this.cbxFiltrarId = new System.Windows.Forms.ComboBox();
            this.btnRegresar = new System.Windows.Forms.Button();
            this.btnEliminarEmpleado = new System.Windows.Forms.Button();
            this.btnModificarEmpleado = new System.Windows.Forms.Button();
            this.btnAltaEmpleados = new System.Windows.Forms.Button();
            this.dgvEmpleados = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmpleados)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft JhengHei", 17F);
            this.label1.Location = new System.Drawing.Point(934, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 29);
            this.label1.TabIndex = 40;
            this.label1.Text = "EMPLEADOS";
            // 
            // cbxFiltrarNombre
            // 
            this.cbxFiltrarNombre.FormattingEnabled = true;
            this.cbxFiltrarNombre.Location = new System.Drawing.Point(940, 387);
            this.cbxFiltrarNombre.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbxFiltrarNombre.Name = "cbxFiltrarNombre";
            this.cbxFiltrarNombre.Size = new System.Drawing.Size(180, 21);
            this.cbxFiltrarNombre.TabIndex = 39;
            this.cbxFiltrarNombre.Text = "Nombre";
            this.cbxFiltrarNombre.SelectedIndexChanged += new System.EventHandler(this.cbxFiltrarNombre_SelectedIndexChanged);
            // 
            // lblFiltrar
            // 
            this.lblFiltrar.AutoSize = true;
            this.lblFiltrar.Location = new System.Drawing.Point(940, 323);
            this.lblFiltrar.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFiltrar.Name = "lblFiltrar";
            this.lblFiltrar.Size = new System.Drawing.Size(53, 13);
            this.lblFiltrar.TabIndex = 38;
            this.lblFiltrar.Text = "Filtrar por:";
            // 
            // cbxFiltrarId
            // 
            this.cbxFiltrarId.FormattingEnabled = true;
            this.cbxFiltrarId.Location = new System.Drawing.Point(940, 347);
            this.cbxFiltrarId.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbxFiltrarId.Name = "cbxFiltrarId";
            this.cbxFiltrarId.Size = new System.Drawing.Size(180, 21);
            this.cbxFiltrarId.TabIndex = 37;
            this.cbxFiltrarId.Text = "Id Empleado";
            this.cbxFiltrarId.SelectedIndexChanged += new System.EventHandler(this.cbxFiltrarId_SelectedIndexChanged);
            // 
            // btnRegresar
            // 
            this.btnRegresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegresar.Location = new System.Drawing.Point(940, 489);
            this.btnRegresar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.Size = new System.Drawing.Size(112, 33);
            this.btnRegresar.TabIndex = 36;
            this.btnRegresar.Text = "Regresar";
            this.btnRegresar.UseVisualStyleBackColor = true;
            this.btnRegresar.Click += new System.EventHandler(this.btnRegresar_Click);
            // 
            // btnEliminarEmpleado
            // 
            this.btnEliminarEmpleado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminarEmpleado.Location = new System.Drawing.Point(940, 205);
            this.btnEliminarEmpleado.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnEliminarEmpleado.Name = "btnEliminarEmpleado";
            this.btnEliminarEmpleado.Size = new System.Drawing.Size(112, 65);
            this.btnEliminarEmpleado.TabIndex = 35;
            this.btnEliminarEmpleado.Text = "Eliminar empleado";
            this.btnEliminarEmpleado.UseVisualStyleBackColor = true;
            this.btnEliminarEmpleado.Click += new System.EventHandler(this.btnEliminarEmpleado_Click);
            // 
            // btnModificarEmpleado
            // 
            this.btnModificarEmpleado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModificarEmpleado.Location = new System.Drawing.Point(940, 138);
            this.btnModificarEmpleado.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnModificarEmpleado.Name = "btnModificarEmpleado";
            this.btnModificarEmpleado.Size = new System.Drawing.Size(112, 57);
            this.btnModificarEmpleado.TabIndex = 34;
            this.btnModificarEmpleado.Text = "Modificar empleado";
            this.btnModificarEmpleado.UseVisualStyleBackColor = true;
            this.btnModificarEmpleado.Click += new System.EventHandler(this.btnModificarEmpleado_Click);
            // 
            // btnAltaEmpleados
            // 
            this.btnAltaEmpleados.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAltaEmpleados.Location = new System.Drawing.Point(940, 69);
            this.btnAltaEmpleados.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAltaEmpleados.Name = "btnAltaEmpleados";
            this.btnAltaEmpleados.Size = new System.Drawing.Size(112, 59);
            this.btnAltaEmpleados.TabIndex = 33;
            this.btnAltaEmpleados.Text = "Agregar empleados";
            this.btnAltaEmpleados.UseVisualStyleBackColor = true;
            this.btnAltaEmpleados.Click += new System.EventHandler(this.btnAltaEmpleados_Click);
            // 
            // dgvEmpleados
            // 
            this.dgvEmpleados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEmpleados.Location = new System.Drawing.Point(42, 20);
            this.dgvEmpleados.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvEmpleados.Name = "dgvEmpleados";
            this.dgvEmpleados.RowHeadersWidth = 51;
            this.dgvEmpleados.Size = new System.Drawing.Size(836, 517);
            this.dgvEmpleados.TabIndex = 32;
            // 
            // frmEmpleados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1162, 549);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbxFiltrarNombre);
            this.Controls.Add(this.lblFiltrar);
            this.Controls.Add(this.cbxFiltrarId);
            this.Controls.Add(this.btnRegresar);
            this.Controls.Add(this.btnEliminarEmpleado);
            this.Controls.Add(this.btnModificarEmpleado);
            this.Controls.Add(this.btnAltaEmpleados);
            this.Controls.Add(this.dgvEmpleados);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmEmpleados";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmEmpleados";
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmpleados)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbxFiltrarNombre;
        private System.Windows.Forms.Label lblFiltrar;
        private System.Windows.Forms.ComboBox cbxFiltrarId;
        private System.Windows.Forms.Button btnRegresar;
        private System.Windows.Forms.Button btnEliminarEmpleado;
        private System.Windows.Forms.Button btnModificarEmpleado;
        private System.Windows.Forms.Button btnAltaEmpleados;
        private System.Windows.Forms.DataGridView dgvEmpleados;
    }
}