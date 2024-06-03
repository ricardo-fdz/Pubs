namespace Pubs
{
    partial class frmAutores
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
            this.btnEliminarAutor = new System.Windows.Forms.Button();
            this.btnModificarAutor = new System.Windows.Forms.Button();
            this.btnAlta = new System.Windows.Forms.Button();
            this.dgvAutores = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAutores)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft JhengHei", 17F);
            this.label1.Location = new System.Drawing.Point(934, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 29);
            this.label1.TabIndex = 31;
            this.label1.Text = "AUTORES";
            // 
            // cbxFiltrarNombre
            // 
            this.cbxFiltrarNombre.FormattingEnabled = true;
            this.cbxFiltrarNombre.Location = new System.Drawing.Point(940, 374);
            this.cbxFiltrarNombre.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbxFiltrarNombre.Name = "cbxFiltrarNombre";
            this.cbxFiltrarNombre.Size = new System.Drawing.Size(180, 21);
            this.cbxFiltrarNombre.TabIndex = 30;
            this.cbxFiltrarNombre.Text = "Nombre";
            this.cbxFiltrarNombre.SelectedIndexChanged += new System.EventHandler(this.cbxFiltrarNombre_SelectedIndexChanged);
            // 
            // lblFiltrar
            // 
            this.lblFiltrar.AutoSize = true;
            this.lblFiltrar.Location = new System.Drawing.Point(940, 306);
            this.lblFiltrar.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFiltrar.Name = "lblFiltrar";
            this.lblFiltrar.Size = new System.Drawing.Size(53, 13);
            this.lblFiltrar.TabIndex = 29;
            this.lblFiltrar.Text = "Filtrar por:";
            // 
            // cbxFiltrarId
            // 
            this.cbxFiltrarId.FormattingEnabled = true;
            this.cbxFiltrarId.Location = new System.Drawing.Point(940, 333);
            this.cbxFiltrarId.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbxFiltrarId.Name = "cbxFiltrarId";
            this.cbxFiltrarId.Size = new System.Drawing.Size(180, 21);
            this.cbxFiltrarId.TabIndex = 28;
            this.cbxFiltrarId.Text = "Id Autor";
            this.cbxFiltrarId.SelectedIndexChanged += new System.EventHandler(this.cbxFiltrarId_SelectedIndexChanged);
            // 
            // btnRegresar
            // 
            this.btnRegresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegresar.Location = new System.Drawing.Point(1008, 448);
            this.btnRegresar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.Size = new System.Drawing.Size(112, 33);
            this.btnRegresar.TabIndex = 27;
            this.btnRegresar.Text = "Regresar";
            this.btnRegresar.UseVisualStyleBackColor = true;
            this.btnRegresar.Click += new System.EventHandler(this.btnRegresar_Click);
            // 
            // btnEliminarAutor
            // 
            this.btnEliminarAutor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminarAutor.Location = new System.Drawing.Point(940, 215);
            this.btnEliminarAutor.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnEliminarAutor.Name = "btnEliminarAutor";
            this.btnEliminarAutor.Size = new System.Drawing.Size(112, 56);
            this.btnEliminarAutor.TabIndex = 26;
            this.btnEliminarAutor.Text = "Eliminar autor";
            this.btnEliminarAutor.UseVisualStyleBackColor = true;
            this.btnEliminarAutor.Click += new System.EventHandler(this.btnEliminarAutor_Click);
            // 
            // btnModificarAutor
            // 
            this.btnModificarAutor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModificarAutor.Location = new System.Drawing.Point(940, 149);
            this.btnModificarAutor.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnModificarAutor.Name = "btnModificarAutor";
            this.btnModificarAutor.Size = new System.Drawing.Size(112, 57);
            this.btnModificarAutor.TabIndex = 25;
            this.btnModificarAutor.Text = "Modificar autor";
            this.btnModificarAutor.UseVisualStyleBackColor = true;
            this.btnModificarAutor.Click += new System.EventHandler(this.btnModificarAutor_Click);
            // 
            // btnAlta
            // 
            this.btnAlta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAlta.Location = new System.Drawing.Point(940, 79);
            this.btnAlta.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAlta.Name = "btnAlta";
            this.btnAlta.Size = new System.Drawing.Size(112, 59);
            this.btnAlta.TabIndex = 24;
            this.btnAlta.Text = "Agregar autor";
            this.btnAlta.UseVisualStyleBackColor = true;
            this.btnAlta.Click += new System.EventHandler(this.btnAlta_Click);
            // 
            // dgvAutores
            // 
            this.dgvAutores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAutores.Location = new System.Drawing.Point(42, 20);
            this.dgvAutores.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvAutores.Name = "dgvAutores";
            this.dgvAutores.RowHeadersWidth = 51;
            this.dgvAutores.Size = new System.Drawing.Size(836, 517);
            this.dgvAutores.TabIndex = 23;
            // 
            // frmAutores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1162, 549);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbxFiltrarNombre);
            this.Controls.Add(this.lblFiltrar);
            this.Controls.Add(this.cbxFiltrarId);
            this.Controls.Add(this.btnRegresar);
            this.Controls.Add(this.btnEliminarAutor);
            this.Controls.Add(this.btnModificarAutor);
            this.Controls.Add(this.btnAlta);
            this.Controls.Add(this.dgvAutores);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmAutores";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmAutores";
            this.Load += new System.EventHandler(this.frmAutores_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAutores)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbxFiltrarNombre;
        private System.Windows.Forms.Label lblFiltrar;
        private System.Windows.Forms.ComboBox cbxFiltrarId;
        private System.Windows.Forms.Button btnRegresar;
        private System.Windows.Forms.Button btnEliminarAutor;
        private System.Windows.Forms.Button btnModificarAutor;
        private System.Windows.Forms.Button btnAlta;
        public System.Windows.Forms.DataGridView dgvAutores;
    }
}