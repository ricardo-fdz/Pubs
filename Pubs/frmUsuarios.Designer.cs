namespace Pubs
{
    partial class frmUsuarios
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
            this.lblFiltrar = new System.Windows.Forms.Label();
            this.cbxFiltrarId = new System.Windows.Forms.ComboBox();
            this.btnRegresar = new System.Windows.Forms.Button();
            this.btnEliminarUsuario = new System.Windows.Forms.Button();
            this.btnModificarUsuario = new System.Windows.Forms.Button();
            this.btnAltaUsuarios = new System.Windows.Forms.Button();
            this.dgvUsuarios = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuarios)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft JhengHei", 17F);
            this.label1.Location = new System.Drawing.Point(934, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 29);
            this.label1.TabIndex = 40;
            this.label1.Text = "USUARIOS";
            // 
            // lblFiltrar
            // 
            this.lblFiltrar.AutoSize = true;
            this.lblFiltrar.Location = new System.Drawing.Point(936, 320);
            this.lblFiltrar.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFiltrar.Name = "lblFiltrar";
            this.lblFiltrar.Size = new System.Drawing.Size(53, 13);
            this.lblFiltrar.TabIndex = 39;
            this.lblFiltrar.Text = "Filtrar por:";
            // 
            // cbxFiltrarId
            // 
            this.cbxFiltrarId.FormattingEnabled = true;
            this.cbxFiltrarId.Location = new System.Drawing.Point(940, 344);
            this.cbxFiltrarId.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbxFiltrarId.Name = "cbxFiltrarId";
            this.cbxFiltrarId.Size = new System.Drawing.Size(180, 21);
            this.cbxFiltrarId.TabIndex = 38;
            this.cbxFiltrarId.Text = "Id Usuario";
            this.cbxFiltrarId.SelectedIndexChanged += new System.EventHandler(this.cbxFiltrarId_SelectedIndexChanged);
            // 
            // btnRegresar
            // 
            this.btnRegresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegresar.Location = new System.Drawing.Point(940, 454);
            this.btnRegresar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.Size = new System.Drawing.Size(112, 33);
            this.btnRegresar.TabIndex = 37;
            this.btnRegresar.Text = "Regresar";
            this.btnRegresar.UseVisualStyleBackColor = true;
            this.btnRegresar.Click += new System.EventHandler(this.btnRegresar_Click);
            // 
            // btnEliminarUsuario
            // 
            this.btnEliminarUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminarUsuario.Location = new System.Drawing.Point(940, 211);
            this.btnEliminarUsuario.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnEliminarUsuario.Name = "btnEliminarUsuario";
            this.btnEliminarUsuario.Size = new System.Drawing.Size(112, 65);
            this.btnEliminarUsuario.TabIndex = 36;
            this.btnEliminarUsuario.Text = "Eliminar usuario";
            this.btnEliminarUsuario.UseVisualStyleBackColor = true;
            this.btnEliminarUsuario.Click += new System.EventHandler(this.btnEliminarUsuario_Click);
            // 
            // btnModificarUsuario
            // 
            this.btnModificarUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModificarUsuario.Location = new System.Drawing.Point(940, 146);
            this.btnModificarUsuario.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnModificarUsuario.Name = "btnModificarUsuario";
            this.btnModificarUsuario.Size = new System.Drawing.Size(112, 57);
            this.btnModificarUsuario.TabIndex = 35;
            this.btnModificarUsuario.Text = "Modificar usuario";
            this.btnModificarUsuario.UseVisualStyleBackColor = true;
            this.btnModificarUsuario.Click += new System.EventHandler(this.btnModificarUsuario_Click);
            // 
            // btnAltaUsuarios
            // 
            this.btnAltaUsuarios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAltaUsuarios.Location = new System.Drawing.Point(940, 76);
            this.btnAltaUsuarios.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAltaUsuarios.Name = "btnAltaUsuarios";
            this.btnAltaUsuarios.Size = new System.Drawing.Size(112, 59);
            this.btnAltaUsuarios.TabIndex = 34;
            this.btnAltaUsuarios.Text = "Agregar usuarios";
            this.btnAltaUsuarios.UseVisualStyleBackColor = true;
            this.btnAltaUsuarios.Click += new System.EventHandler(this.btnAltaUsuarios_Click);
            // 
            // dgvUsuarios
            // 
            this.dgvUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUsuarios.Location = new System.Drawing.Point(42, 20);
            this.dgvUsuarios.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvUsuarios.Name = "dgvUsuarios";
            this.dgvUsuarios.RowHeadersWidth = 51;
            this.dgvUsuarios.Size = new System.Drawing.Size(836, 517);
            this.dgvUsuarios.TabIndex = 33;
            // 
            // frmUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1162, 549);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblFiltrar);
            this.Controls.Add(this.cbxFiltrarId);
            this.Controls.Add(this.btnRegresar);
            this.Controls.Add(this.btnEliminarUsuario);
            this.Controls.Add(this.btnModificarUsuario);
            this.Controls.Add(this.btnAltaUsuarios);
            this.Controls.Add(this.dgvUsuarios);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmUsuarios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmUsuarios";
            this.Load += new System.EventHandler(this.frmUsuarios_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuarios)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblFiltrar;
        private System.Windows.Forms.ComboBox cbxFiltrarId;
        private System.Windows.Forms.Button btnRegresar;
        private System.Windows.Forms.Button btnEliminarUsuario;
        private System.Windows.Forms.Button btnModificarUsuario;
        private System.Windows.Forms.Button btnAltaUsuarios;
        private System.Windows.Forms.DataGridView dgvUsuarios;
    }
}