namespace Pubs
{
    partial class frmTitulosAutor
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
            this.label1 = new System.Windows.Forms.Label();
            this.cbxFiltrarNombre = new System.Windows.Forms.ComboBox();
            this.lblFiltrar = new System.Windows.Forms.Label();
            this.cbxFiltrarId = new System.Windows.Forms.ComboBox();
            this.btnRegresar = new System.Windows.Forms.Button();
            this.btnEliminarTituloAutor = new System.Windows.Forms.Button();
            this.btnModificarTituloAutor = new System.Windows.Forms.Button();
            this.btnAltaTituloAutor = new System.Windows.Forms.Button();
            this.dgvTitulosAutor = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTitulosAutor)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft JhengHei", 17F);
            this.label2.Location = new System.Drawing.Point(932, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 29);
            this.label2.TabIndex = 39;
            this.label2.Text = " AUTOR";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft JhengHei", 17F);
            this.label1.Location = new System.Drawing.Point(932, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 29);
            this.label1.TabIndex = 38;
            this.label1.Text = "TITULOS";
            // 
            // cbxFiltrarNombre
            // 
            this.cbxFiltrarNombre.FormattingEnabled = true;
            this.cbxFiltrarNombre.Location = new System.Drawing.Point(942, 392);
            this.cbxFiltrarNombre.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbxFiltrarNombre.Name = "cbxFiltrarNombre";
            this.cbxFiltrarNombre.Size = new System.Drawing.Size(180, 21);
            this.cbxFiltrarNombre.TabIndex = 37;
            this.cbxFiltrarNombre.Text = "Nombre";
            this.cbxFiltrarNombre.SelectedIndexChanged += new System.EventHandler(this.cbxFiltrarNombre_SelectedIndexChanged);
            // 
            // lblFiltrar
            // 
            this.lblFiltrar.AutoSize = true;
            this.lblFiltrar.Location = new System.Drawing.Point(938, 316);
            this.lblFiltrar.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFiltrar.Name = "lblFiltrar";
            this.lblFiltrar.Size = new System.Drawing.Size(53, 13);
            this.lblFiltrar.TabIndex = 36;
            this.lblFiltrar.Text = "Filtrar por:";
            // 
            // cbxFiltrarId
            // 
            this.cbxFiltrarId.FormattingEnabled = true;
            this.cbxFiltrarId.Location = new System.Drawing.Point(942, 355);
            this.cbxFiltrarId.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbxFiltrarId.Name = "cbxFiltrarId";
            this.cbxFiltrarId.Size = new System.Drawing.Size(180, 21);
            this.cbxFiltrarId.TabIndex = 35;
            this.cbxFiltrarId.Text = "Id Autor";
            this.cbxFiltrarId.SelectedIndexChanged += new System.EventHandler(this.cbxFiltrarId_SelectedIndexChanged);
            // 
            // btnRegresar
            // 
            this.btnRegresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegresar.Location = new System.Drawing.Point(938, 489);
            this.btnRegresar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.Size = new System.Drawing.Size(112, 33);
            this.btnRegresar.TabIndex = 34;
            this.btnRegresar.Text = "Regresar";
            this.btnRegresar.UseVisualStyleBackColor = true;
            this.btnRegresar.Click += new System.EventHandler(this.btnRegresar_Click);
            // 
            // btnEliminarTituloAutor
            // 
            this.btnEliminarTituloAutor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminarTituloAutor.Location = new System.Drawing.Point(938, 240);
            this.btnEliminarTituloAutor.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnEliminarTituloAutor.Name = "btnEliminarTituloAutor";
            this.btnEliminarTituloAutor.Size = new System.Drawing.Size(112, 65);
            this.btnEliminarTituloAutor.TabIndex = 33;
            this.btnEliminarTituloAutor.Text = "Eliminar titulo autor";
            this.btnEliminarTituloAutor.UseVisualStyleBackColor = true;
            this.btnEliminarTituloAutor.Click += new System.EventHandler(this.btnEliminarTituloAutor_Click);
            // 
            // btnModificarTituloAutor
            // 
            this.btnModificarTituloAutor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModificarTituloAutor.Location = new System.Drawing.Point(938, 173);
            this.btnModificarTituloAutor.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnModificarTituloAutor.Name = "btnModificarTituloAutor";
            this.btnModificarTituloAutor.Size = new System.Drawing.Size(112, 57);
            this.btnModificarTituloAutor.TabIndex = 32;
            this.btnModificarTituloAutor.Text = "Modificar titulo autor";
            this.btnModificarTituloAutor.UseVisualStyleBackColor = true;
            this.btnModificarTituloAutor.Click += new System.EventHandler(this.btnModificarTituloAutor_Click);
            // 
            // btnAltaTituloAutor
            // 
            this.btnAltaTituloAutor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAltaTituloAutor.Location = new System.Drawing.Point(938, 104);
            this.btnAltaTituloAutor.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAltaTituloAutor.Name = "btnAltaTituloAutor";
            this.btnAltaTituloAutor.Size = new System.Drawing.Size(112, 59);
            this.btnAltaTituloAutor.TabIndex = 31;
            this.btnAltaTituloAutor.Text = "Agregar título autor";
            this.btnAltaTituloAutor.UseVisualStyleBackColor = true;
            this.btnAltaTituloAutor.Click += new System.EventHandler(this.btnAltaTituloAutor_Click);
            // 
            // dgvTitulosAutor
            // 
            this.dgvTitulosAutor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTitulosAutor.Location = new System.Drawing.Point(40, 20);
            this.dgvTitulosAutor.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvTitulosAutor.Name = "dgvTitulosAutor";
            this.dgvTitulosAutor.RowHeadersWidth = 51;
            this.dgvTitulosAutor.Size = new System.Drawing.Size(836, 517);
            this.dgvTitulosAutor.TabIndex = 30;
            // 
            // frmTitulosAutor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1162, 549);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbxFiltrarNombre);
            this.Controls.Add(this.lblFiltrar);
            this.Controls.Add(this.cbxFiltrarId);
            this.Controls.Add(this.btnRegresar);
            this.Controls.Add(this.btnEliminarTituloAutor);
            this.Controls.Add(this.btnModificarTituloAutor);
            this.Controls.Add(this.btnAltaTituloAutor);
            this.Controls.Add(this.dgvTitulosAutor);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmTitulosAutor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmTitulosAutor";
            this.Load += new System.EventHandler(this.frmTitulosAutor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTitulosAutor)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbxFiltrarNombre;
        private System.Windows.Forms.Label lblFiltrar;
        private System.Windows.Forms.ComboBox cbxFiltrarId;
        private System.Windows.Forms.Button btnRegresar;
        private System.Windows.Forms.Button btnEliminarTituloAutor;
        private System.Windows.Forms.Button btnModificarTituloAutor;
        private System.Windows.Forms.Button btnAltaTituloAutor;
        private System.Windows.Forms.DataGridView dgvTitulosAutor;
    }
}