namespace Pubs
{
    partial class frmTitulos
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
            this.btnEliminarTitulo = new System.Windows.Forms.Button();
            this.btnModificarTitulo = new System.Windows.Forms.Button();
            this.btnAltaTitulo = new System.Windows.Forms.Button();
            this.dgvTitulos = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTitulos)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft JhengHei", 17F);
            this.label1.Location = new System.Drawing.Point(934, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 29);
            this.label1.TabIndex = 34;
            this.label1.Text = "TITULOS";
            // 
            // cbxFiltrarNombre
            // 
            this.cbxFiltrarNombre.FormattingEnabled = true;
            this.cbxFiltrarNombre.Location = new System.Drawing.Point(940, 383);
            this.cbxFiltrarNombre.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbxFiltrarNombre.Name = "cbxFiltrarNombre";
            this.cbxFiltrarNombre.Size = new System.Drawing.Size(180, 21);
            this.cbxFiltrarNombre.TabIndex = 33;
            this.cbxFiltrarNombre.Text = "Nombre";
            this.cbxFiltrarNombre.SelectedIndexChanged += new System.EventHandler(this.cbxFiltrarNombre_SelectedIndexChanged);
            // 
            // lblFiltrar
            // 
            this.lblFiltrar.AutoSize = true;
            this.lblFiltrar.Location = new System.Drawing.Point(936, 320);
            this.lblFiltrar.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFiltrar.Name = "lblFiltrar";
            this.lblFiltrar.Size = new System.Drawing.Size(53, 13);
            this.lblFiltrar.TabIndex = 32;
            this.lblFiltrar.Text = "Filtrar por:";
            // 
            // cbxFiltrarId
            // 
            this.cbxFiltrarId.FormattingEnabled = true;
            this.cbxFiltrarId.Location = new System.Drawing.Point(940, 344);
            this.cbxFiltrarId.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbxFiltrarId.Name = "cbxFiltrarId";
            this.cbxFiltrarId.Size = new System.Drawing.Size(180, 21);
            this.cbxFiltrarId.TabIndex = 31;
            this.cbxFiltrarId.Text = "Id Titulo";
            this.cbxFiltrarId.SelectedIndexChanged += new System.EventHandler(this.cbxFiltrarId_SelectedIndexChanged);
            // 
            // btnRegresar
            // 
            this.btnRegresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegresar.Location = new System.Drawing.Point(940, 489);
            this.btnRegresar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.Size = new System.Drawing.Size(112, 33);
            this.btnRegresar.TabIndex = 30;
            this.btnRegresar.Text = "Regresar";
            this.btnRegresar.UseVisualStyleBackColor = true;
            this.btnRegresar.Click += new System.EventHandler(this.btnRegresar_Click);
            // 
            // btnEliminarTitulo
            // 
            this.btnEliminarTitulo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminarTitulo.Location = new System.Drawing.Point(940, 209);
            this.btnEliminarTitulo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnEliminarTitulo.Name = "btnEliminarTitulo";
            this.btnEliminarTitulo.Size = new System.Drawing.Size(112, 65);
            this.btnEliminarTitulo.TabIndex = 29;
            this.btnEliminarTitulo.Text = "Eliminar libro";
            this.btnEliminarTitulo.UseVisualStyleBackColor = true;
            this.btnEliminarTitulo.Click += new System.EventHandler(this.btnEliminarTitulo_Click);
            // 
            // btnModificarTitulo
            // 
            this.btnModificarTitulo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModificarTitulo.Location = new System.Drawing.Point(940, 144);
            this.btnModificarTitulo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnModificarTitulo.Name = "btnModificarTitulo";
            this.btnModificarTitulo.Size = new System.Drawing.Size(112, 57);
            this.btnModificarTitulo.TabIndex = 28;
            this.btnModificarTitulo.Text = "Modificar libro";
            this.btnModificarTitulo.UseVisualStyleBackColor = true;
            this.btnModificarTitulo.Click += new System.EventHandler(this.btnModificarTitulo_Click);
            // 
            // btnAltaTitulo
            // 
            this.btnAltaTitulo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAltaTitulo.Location = new System.Drawing.Point(940, 76);
            this.btnAltaTitulo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAltaTitulo.Name = "btnAltaTitulo";
            this.btnAltaTitulo.Size = new System.Drawing.Size(112, 59);
            this.btnAltaTitulo.TabIndex = 27;
            this.btnAltaTitulo.Text = "Agregar libro";
            this.btnAltaTitulo.UseVisualStyleBackColor = true;
            this.btnAltaTitulo.Click += new System.EventHandler(this.btnAltaTitulo_Click);
            // 
            // dgvTitulos
            // 
            this.dgvTitulos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTitulos.Location = new System.Drawing.Point(42, 20);
            this.dgvTitulos.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvTitulos.Name = "dgvTitulos";
            this.dgvTitulos.RowHeadersWidth = 51;
            this.dgvTitulos.Size = new System.Drawing.Size(836, 517);
            this.dgvTitulos.TabIndex = 26;
            // 
            // frmTitulos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1162, 549);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbxFiltrarNombre);
            this.Controls.Add(this.lblFiltrar);
            this.Controls.Add(this.cbxFiltrarId);
            this.Controls.Add(this.btnRegresar);
            this.Controls.Add(this.btnEliminarTitulo);
            this.Controls.Add(this.btnModificarTitulo);
            this.Controls.Add(this.btnAltaTitulo);
            this.Controls.Add(this.dgvTitulos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmTitulos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmTitulos";
            this.Load += new System.EventHandler(this.frmTitulos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTitulos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbxFiltrarNombre;
        private System.Windows.Forms.Label lblFiltrar;
        private System.Windows.Forms.ComboBox cbxFiltrarId;
        private System.Windows.Forms.Button btnRegresar;
        private System.Windows.Forms.Button btnEliminarTitulo;
        private System.Windows.Forms.Button btnModificarTitulo;
        private System.Windows.Forms.Button btnAltaTitulo;
        private System.Windows.Forms.DataGridView dgvTitulos;
    }
}