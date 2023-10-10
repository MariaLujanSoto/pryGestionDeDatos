namespace pryGestionDeDatos
{
    partial class frmMenuPrincipal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStripPrincipal = new System.Windows.Forms.MenuStrip();
            this.clientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registrarClienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buscarClienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mostrarClienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.proveedoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registrarProveedorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buscarProveedorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mostrarPorveedorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ventasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ventasRegistradasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mostarVentasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblTituloMPrincipal = new System.Windows.Forms.Label();
            this.menuStripPrincipal.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStripPrincipal
            // 
            this.menuStripPrincipal.BackColor = System.Drawing.Color.LightGray;
            this.menuStripPrincipal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clientesToolStripMenuItem,
            this.proveedoresToolStripMenuItem,
            this.ventasToolStripMenuItem});
            this.menuStripPrincipal.Location = new System.Drawing.Point(0, 0);
            this.menuStripPrincipal.Name = "menuStripPrincipal";
            this.menuStripPrincipal.Size = new System.Drawing.Size(534, 24);
            this.menuStripPrincipal.TabIndex = 0;
            this.menuStripPrincipal.Text = "menuStrip1";
            // 
            // clientesToolStripMenuItem
            // 
            this.clientesToolStripMenuItem.BackColor = System.Drawing.Color.Wheat;
            this.clientesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registrarClienteToolStripMenuItem,
            this.buscarClienteToolStripMenuItem,
            this.mostrarClienteToolStripMenuItem});
            this.clientesToolStripMenuItem.Name = "clientesToolStripMenuItem";
            this.clientesToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.clientesToolStripMenuItem.Text = "Clientes";
            // 
            // registrarClienteToolStripMenuItem
            // 
            this.registrarClienteToolStripMenuItem.BackColor = System.Drawing.Color.Snow;
            this.registrarClienteToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Transparent;
            this.registrarClienteToolStripMenuItem.Name = "registrarClienteToolStripMenuItem";
            this.registrarClienteToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.registrarClienteToolStripMenuItem.Text = "Cargar  Cliente";
            this.registrarClienteToolStripMenuItem.Click += new System.EventHandler(this.registrarClienteToolStripMenuItem_Click);
            // 
            // buscarClienteToolStripMenuItem
            // 
            this.buscarClienteToolStripMenuItem.BackColor = System.Drawing.Color.Bisque;
            this.buscarClienteToolStripMenuItem.Name = "buscarClienteToolStripMenuItem";
            this.buscarClienteToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.buscarClienteToolStripMenuItem.Text = "Buscar Cliente";
            this.buscarClienteToolStripMenuItem.Click += new System.EventHandler(this.buscarClienteToolStripMenuItem_Click);
            // 
            // mostrarClienteToolStripMenuItem
            // 
            this.mostrarClienteToolStripMenuItem.BackColor = System.Drawing.Color.Beige;
            this.mostrarClienteToolStripMenuItem.Name = "mostrarClienteToolStripMenuItem";
            this.mostrarClienteToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.mostrarClienteToolStripMenuItem.Text = "Mostrar Cliente";
            this.mostrarClienteToolStripMenuItem.Click += new System.EventHandler(this.mostrarClienteToolStripMenuItem_Click);
            // 
            // proveedoresToolStripMenuItem
            // 
            this.proveedoresToolStripMenuItem.BackColor = System.Drawing.Color.Peru;
            this.proveedoresToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registrarProveedorToolStripMenuItem,
            this.buscarProveedorToolStripMenuItem,
            this.mostrarPorveedorToolStripMenuItem});
            this.proveedoresToolStripMenuItem.Name = "proveedoresToolStripMenuItem";
            this.proveedoresToolStripMenuItem.Size = new System.Drawing.Size(77, 20);
            this.proveedoresToolStripMenuItem.Text = "Empleados";
            // 
            // registrarProveedorToolStripMenuItem
            // 
            this.registrarProveedorToolStripMenuItem.BackColor = System.Drawing.Color.Snow;
            this.registrarProveedorToolStripMenuItem.Name = "registrarProveedorToolStripMenuItem";
            this.registrarProveedorToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.registrarProveedorToolStripMenuItem.Text = "Cargar Empleado";
            this.registrarProveedorToolStripMenuItem.Click += new System.EventHandler(this.registrarProveedorToolStripMenuItem_Click);
            // 
            // buscarProveedorToolStripMenuItem
            // 
            this.buscarProveedorToolStripMenuItem.BackColor = System.Drawing.Color.Bisque;
            this.buscarProveedorToolStripMenuItem.Name = "buscarProveedorToolStripMenuItem";
            this.buscarProveedorToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.buscarProveedorToolStripMenuItem.Text = "Buscar Empleado";
            this.buscarProveedorToolStripMenuItem.Click += new System.EventHandler(this.buscarProveedorToolStripMenuItem_Click);
            // 
            // mostrarPorveedorToolStripMenuItem
            // 
            this.mostrarPorveedorToolStripMenuItem.BackColor = System.Drawing.Color.Beige;
            this.mostrarPorveedorToolStripMenuItem.Name = "mostrarPorveedorToolStripMenuItem";
            this.mostrarPorveedorToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.mostrarPorveedorToolStripMenuItem.Text = "Mostrar Empleado";
            this.mostrarPorveedorToolStripMenuItem.Click += new System.EventHandler(this.mostrarPorveedorToolStripMenuItem_Click);
            // 
            // ventasToolStripMenuItem
            // 
            this.ventasToolStripMenuItem.BackColor = System.Drawing.Color.Tan;
            this.ventasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ventasRegistradasToolStripMenuItem,
            this.mostarVentasToolStripMenuItem});
            this.ventasToolStripMenuItem.Name = "ventasToolStripMenuItem";
            this.ventasToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.ventasToolStripMenuItem.Text = "Ventas";
            // 
            // ventasRegistradasToolStripMenuItem
            // 
            this.ventasRegistradasToolStripMenuItem.BackColor = System.Drawing.Color.Snow;
            this.ventasRegistradasToolStripMenuItem.Name = "ventasRegistradasToolStripMenuItem";
            this.ventasRegistradasToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.ventasRegistradasToolStripMenuItem.Text = "Cargar Venta";
            this.ventasRegistradasToolStripMenuItem.Click += new System.EventHandler(this.ventasRegistradasToolStripMenuItem_Click);
            // 
            // mostarVentasToolStripMenuItem
            // 
            this.mostarVentasToolStripMenuItem.BackColor = System.Drawing.Color.Bisque;
            this.mostarVentasToolStripMenuItem.Name = "mostarVentasToolStripMenuItem";
            this.mostarVentasToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.mostarVentasToolStripMenuItem.Text = "Mostar Ventas";
            this.mostarVentasToolStripMenuItem.Click += new System.EventHandler(this.mostarVentasToolStripMenuItem_Click);
            // 
            // lblTituloMPrincipal
            // 
            this.lblTituloMPrincipal.AutoSize = true;
            this.lblTituloMPrincipal.BackColor = System.Drawing.Color.Transparent;
            this.lblTituloMPrincipal.Font = new System.Drawing.Font("MS PGothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloMPrincipal.ForeColor = System.Drawing.Color.Black;
            this.lblTituloMPrincipal.Location = new System.Drawing.Point(147, 123);
            this.lblTituloMPrincipal.Name = "lblTituloMPrincipal";
            this.lblTituloMPrincipal.Size = new System.Drawing.Size(259, 57);
            this.lblTituloMPrincipal.TabIndex = 1;
            this.lblTituloMPrincipal.Text = "Gestion de Datos\r\nEstética Salud y Naturaleza\r\n\r\n";
            this.lblTituloMPrincipal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmMenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.BackgroundImage = global::pryGestionDeDatos.Properties.Resources.Tela_inicial;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(534, 303);
            this.Controls.Add(this.lblTituloMPrincipal);
            this.Controls.Add(this.menuStripPrincipal);
            this.MainMenuStrip = this.menuStripPrincipal;
            this.Name = "frmMenuPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu Principal";
            this.Load += new System.EventHandler(this.frmMenuPrincipal_Load);
            this.menuStripPrincipal.ResumeLayout(false);
            this.menuStripPrincipal.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStripPrincipal;
        private System.Windows.Forms.ToolStripMenuItem clientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registrarClienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem buscarClienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mostrarClienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem proveedoresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registrarProveedorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem buscarProveedorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mostrarPorveedorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ventasToolStripMenuItem;
        private System.Windows.Forms.Label lblTituloMPrincipal;
        private System.Windows.Forms.ToolStripMenuItem ventasRegistradasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mostarVentasToolStripMenuItem;
    }
}

