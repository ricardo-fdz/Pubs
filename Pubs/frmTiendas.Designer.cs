namespace Pubs
{
    partial class frmTiendas
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
            this.btnEliminarTienda = new System.Windows.Forms.Button();
            this.btnModificarTienda = new System.Windows.Forms.Button();
            this.btnAltaTiendas = new System.Windows.Forms.Button();
            this.dgvTiendas = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTiendas)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft JhengHei", 17F);
            this.label1.Location = new System.Drawing.Point(934, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 29);
            this.label1.TabIndex = 38;
            this.label1.Text = "TIENDAS";
            // 
            // lblFiltrar
            // 
            this.lblFiltrar.AutoSize = true;
            this.lblFiltrar.Location = new System.Drawing.Point(936, 325);
            this.lblFiltrar.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFiltrar.Name = "lblFiltrar";
            this.lblFiltrar.Size = new System.Drawing.Size(53, 13);
            this.lblFiltrar.TabIndex = 37;
            this.lblFiltrar.Text = "Filtrar por:";
            // 
            // cbxFiltrarId
            // 
            this.cbxFiltrarId.FormattingEnabled = true;
            this.cbxFiltrarId.Location = new System.Drawing.Point(940, 349);
            this.cbxFiltrarId.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbxFiltrarId.Name = "cbxFiltrarId";
            this.cbxFiltrarId.Size = new System.Drawing.Size(180, 21);
            this.cbxFiltrarId.TabIndex = 36;
            this.cbxFiltrarId.Text = "Id Tienda";
            this.cbxFiltrarId.SelectedIndexChanged += new System.EventHandler(this.cbxFiltrarId_SelectedIndexChanged);
            // 
            // btnRegresar
            // 
            this.btnRegresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegresar.Location = new System.Drawing.Point(940, 489);
            this.btnRegresar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.Size = new System.Drawing.Size(112, 33);
            this.btnRegresar.TabIndex = 35;
            this.btnRegresar.Text = "Regresar";
            this.btnRegresar.UseVisualStyleBackColor = true;
            this.btnRegresar.Click += new System.EventHandler(this.btnRegresar_Click);
            // 
            // btnEliminarTienda
            // 
            this.btnEliminarTienda.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminarTienda.Location = new System.Drawing.Point(940, 223);
            this.btnEliminarTienda.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnEliminarTienda.Name = "btnEliminarTienda";
            this.btnEliminarTienda.Size = new System.Drawing.Size(112, 65);
            this.btnEliminarTienda.TabIndex = 34;
            this.btnEliminarTienda.Text = "Eliminar tienda";
            this.btnEliminarTienda.UseVisualStyleBackColor = true;
            this.btnEliminarTienda.Click += new System.EventHandler(this.btnEliminarTienda_Click);
            // 
            // btnModificarTienda
            // 
            this.btnModificarTienda.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModificarTienda.Location = new System.Drawing.Point(940, 157);
            this.btnModificarTienda.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnModificarTienda.Name = "btnModificarTienda";
            this.btnModificarTienda.Size = new System.Drawing.Size(112, 57);
            this.btnModificarTienda.TabIndex = 33;
            this.btnModificarTienda.Text = "Modificar tienda";
            this.btnModificarTienda.UseVisualStyleBackColor = true;
            this.btnModificarTienda.Click += new System.EventHandler(this.btnModificarTienda_Click);
            // 
            // btnAltaTiendas
            // 
            this.btnAltaTiendas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAltaTiendas.Location = new System.Drawing.Point(940, 76);
            this.btnAltaTiendas.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAltaTiendas.Name = "btnAltaTiendas";
            this.btnAltaTiendas.Size = new System.Drawing.Size(112, 59);
            this.btnAltaTiendas.TabIndex = 32;
            this.btnAltaTiendas.Text = "Agregar tienda";
            this.btnAltaTiendas.UseVisualStyleBackColor = true;
            this.btnAltaTiendas.Click += new System.EventHandler(this.btnAltaTiendas_Click);
            // 
            // dgvTiendas
            // 
            this.dgvTiendas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTiendas.Location = new System.Drawing.Point(42, 20);
            this.dgvTiendas.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvTiendas.Name = "dgvTiendas";
            this.dgvTiendas.RowHeadersWidth = 51;
            this.dgvTiendas.Size = new System.Drawing.Size(836, 517);
            this.dgvTiendas.TabIndex = 31;
            // 
            // frmTiendas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1162, 549);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblFiltrar);
            this.Controls.Add(this.cbxFiltrarId);
            this.Controls.Add(this.btnRegresar);
            this.Controls.Add(this.btnEliminarTienda);
            this.Controls.Add(this.btnModificarTienda);
            this.Controls.Add(this.btnAltaTiendas);
            this.Controls.Add(this.dgvTiendas);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmTiendas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmTiendas";
            this.Load += new System.EventHandler(this.frmTiendas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTiendas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblFiltrar;
        private System.Windows.Forms.ComboBox cbxFiltrarId;
        private System.Windows.Forms.Button btnRegresar;
        private System.Windows.Forms.Button btnEliminarTienda;
        private System.Windows.Forms.Button btnModificarTienda;
        private System.Windows.Forms.Button btnAltaTiendas;
        private System.Windows.Forms.DataGridView dgvTiendas;
    }
}