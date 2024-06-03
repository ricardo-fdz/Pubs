namespace Pubs
{
    partial class frmMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMenu));
            this.btnVentas = new System.Windows.Forms.Button();
            this.btnTiendas = new System.Windows.Forms.Button();
            this.btnTitulosAutor = new System.Windows.Forms.Button();
            this.btnTitulos = new System.Windows.Forms.Button();
            this.btnAutores = new System.Windows.Forms.Button();
            this.tsslNombreUsuario = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.tsddbConfiguracionAdmin = new System.Windows.Forms.ToolStripDropDownButton();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agregarUsuariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.btnStock = new System.Windows.Forms.Button();
            this.btnEmpleados = new System.Windows.Forms.Button();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnVentas
            // 
            this.btnVentas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVentas.Location = new System.Drawing.Point(568, 168);
            this.btnVentas.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnVentas.Name = "btnVentas";
            this.btnVentas.Size = new System.Drawing.Size(112, 57);
            this.btnVentas.TabIndex = 13;
            this.btnVentas.Text = "Ventas";
            this.btnVentas.UseVisualStyleBackColor = true;
            this.btnVentas.Click += new System.EventHandler(this.btnVentas_Click);
            // 
            // btnTiendas
            // 
            this.btnTiendas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTiendas.Font = new System.Drawing.Font("Microsoft JhengHei", 9.75F);
            this.btnTiendas.Location = new System.Drawing.Point(352, 168);
            this.btnTiendas.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnTiendas.Name = "btnTiendas";
            this.btnTiendas.Size = new System.Drawing.Size(112, 57);
            this.btnTiendas.TabIndex = 12;
            this.btnTiendas.Text = "Tiendas";
            this.btnTiendas.UseVisualStyleBackColor = true;
            this.btnTiendas.Click += new System.EventHandler(this.btnTiendas_Click);
            // 
            // btnTitulosAutor
            // 
            this.btnTitulosAutor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTitulosAutor.Location = new System.Drawing.Point(127, 168);
            this.btnTitulosAutor.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnTitulosAutor.Name = "btnTitulosAutor";
            this.btnTitulosAutor.Size = new System.Drawing.Size(112, 57);
            this.btnTitulosAutor.TabIndex = 11;
            this.btnTitulosAutor.Text = "Títulos de Autor";
            this.btnTitulosAutor.UseVisualStyleBackColor = true;
            this.btnTitulosAutor.Click += new System.EventHandler(this.btnTitulosAutor_Click);
            // 
            // btnTitulos
            // 
            this.btnTitulos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTitulos.Location = new System.Drawing.Point(352, 65);
            this.btnTitulos.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnTitulos.Name = "btnTitulos";
            this.btnTitulos.Size = new System.Drawing.Size(112, 57);
            this.btnTitulos.TabIndex = 10;
            this.btnTitulos.Text = "Títulos";
            this.btnTitulos.UseVisualStyleBackColor = true;
            this.btnTitulos.Click += new System.EventHandler(this.btnTitulos_Click);
            // 
            // btnAutores
            // 
            this.btnAutores.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAutores.Location = new System.Drawing.Point(127, 65);
            this.btnAutores.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAutores.Name = "btnAutores";
            this.btnAutores.Size = new System.Drawing.Size(112, 57);
            this.btnAutores.TabIndex = 9;
            this.btnAutores.Text = "Autores";
            this.btnAutores.UseVisualStyleBackColor = true;
            this.btnAutores.Click += new System.EventHandler(this.btnAutores_Click);
            // 
            // tsslNombreUsuario
            // 
            this.tsslNombreUsuario.Name = "tsslNombreUsuario";
            this.tsslNombreUsuario.Size = new System.Drawing.Size(118, 21);
            this.tsslNombreUsuario.Text = "toolStripStatusLabel1";
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsslNombreUsuario,
            this.tsddbConfiguracionAdmin});
            this.statusStrip1.Location = new System.Drawing.Point(0, 391);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 22, 0);
            this.statusStrip1.Size = new System.Drawing.Size(806, 26);
            this.statusStrip1.TabIndex = 14;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // tsddbConfiguracionAdmin
            // 
            this.tsddbConfiguracionAdmin.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsddbConfiguracionAdmin.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.salirToolStripMenuItem,
            this.agregarUsuariosToolStripMenuItem});
            this.tsddbConfiguracionAdmin.Image = ((System.Drawing.Image)(resources.GetObject("tsddbConfiguracionAdmin.Image")));
            this.tsddbConfiguracionAdmin.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsddbConfiguracionAdmin.Name = "tsddbConfiguracionAdmin";
            this.tsddbConfiguracionAdmin.Size = new System.Drawing.Size(33, 24);
            this.tsddbConfiguracionAdmin.Text = "toolStripDropDownButton1";
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // agregarUsuariosToolStripMenuItem
            // 
            this.agregarUsuariosToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.agregarUsuariosToolStripMenuItem.Name = "agregarUsuariosToolStripMenuItem";
            this.agregarUsuariosToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.agregarUsuariosToolStripMenuItem.Text = "Agregar usuarios";
            this.agregarUsuariosToolStripMenuItem.Click += new System.EventHandler(this.agregarUsuariosToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft JhengHei", 17F);
            this.label1.Location = new System.Drawing.Point(11, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 29);
            this.label1.TabIndex = 17;
            this.label1.Text = "MENÚ";
            // 
            // btnStock
            // 
            this.btnStock.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStock.Location = new System.Drawing.Point(568, 65);
            this.btnStock.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnStock.Name = "btnStock";
            this.btnStock.Size = new System.Drawing.Size(112, 57);
            this.btnStock.TabIndex = 16;
            this.btnStock.Text = "Stock";
            this.btnStock.UseVisualStyleBackColor = true;
            this.btnStock.Click += new System.EventHandler(this.btnStock_Click);
            // 
            // btnEmpleados
            // 
            this.btnEmpleados.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEmpleados.Location = new System.Drawing.Point(352, 270);
            this.btnEmpleados.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnEmpleados.Name = "btnEmpleados";
            this.btnEmpleados.Size = new System.Drawing.Size(112, 57);
            this.btnEmpleados.TabIndex = 15;
            this.btnEmpleados.Text = "Empleados";
            this.btnEmpleados.UseVisualStyleBackColor = true;
            this.btnEmpleados.Click += new System.EventHandler(this.btnEmpleados_Click);
            // 
            // frmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(806, 417);
            this.Controls.Add(this.btnVentas);
            this.Controls.Add(this.btnTiendas);
            this.Controls.Add(this.btnTitulosAutor);
            this.Controls.Add(this.btnTitulos);
            this.Controls.Add(this.btnAutores);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnStock);
            this.Controls.Add(this.btnEmpleados);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmMenu";
            this.Load += new System.EventHandler(this.frmMenu_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnVentas;
        private System.Windows.Forms.Button btnTiendas;
        private System.Windows.Forms.Button btnTitulosAutor;
        private System.Windows.Forms.Button btnTitulos;
        private System.Windows.Forms.Button btnAutores;
        private System.Windows.Forms.ToolStripStatusLabel tsslNombreUsuario;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripDropDownButton tsddbConfiguracionAdmin;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem agregarUsuariosToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnStock;
        private System.Windows.Forms.Button btnEmpleados;
    }
}