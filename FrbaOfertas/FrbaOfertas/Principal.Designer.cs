namespace FrbaOfertas
{
    partial class Principal
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario.</param>
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
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.mnuPrincipal = new System.Windows.Forms.MenuStrip();
            this.cuentasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuRoles = new System.Windows.Forms.ToolStripMenuItem();
            this.clientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.creditoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.proveedoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ofertasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuPubicacion = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuCompras = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuEntrega = new System.Windows.Forms.ToolStripMenuItem();
            this.facturaciónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.estadisticasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cambiarContraseñaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aCercaDeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuPrincipal.SuspendLayout();
            this.SuspendLayout();
            // 
            // mnuPrincipal
            // 
            this.mnuPrincipal.BackColor = System.Drawing.SystemColors.Control;
            this.mnuPrincipal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cuentasToolStripMenuItem,
            this.mnuRoles,
            this.clientesToolStripMenuItem,
            this.creditoToolStripMenuItem,
            this.proveedoresToolStripMenuItem,
            this.ofertasToolStripMenuItem,
            this.facturaciónToolStripMenuItem,
            this.estadisticasToolStripMenuItem,
            this.cambiarContraseñaToolStripMenuItem,
            this.aCercaDeToolStripMenuItem});
            this.mnuPrincipal.Location = new System.Drawing.Point(0, 0);
            this.mnuPrincipal.Name = "mnuPrincipal";
            this.mnuPrincipal.Size = new System.Drawing.Size(784, 24);
            this.mnuPrincipal.TabIndex = 0;
            this.mnuPrincipal.Text = "Principal";
            // 
            // cuentasToolStripMenuItem
            // 
            this.cuentasToolStripMenuItem.Name = "cuentasToolStripMenuItem";
            this.cuentasToolStripMenuItem.Size = new System.Drawing.Size(62, 20);
            this.cuentasToolStripMenuItem.Text = "Cuentas";
            this.cuentasToolStripMenuItem.Click += new System.EventHandler(this.cuentasToolStripMenuItem_Click);
            // 
            // mnuRoles
            // 
            this.mnuRoles.Name = "mnuRoles";
            this.mnuRoles.Size = new System.Drawing.Size(47, 20);
            this.mnuRoles.Text = "Roles";
            this.mnuRoles.Click += new System.EventHandler(this.mnuRoles_Click);
            // 
            // clientesToolStripMenuItem
            // 
            this.clientesToolStripMenuItem.Name = "clientesToolStripMenuItem";
            this.clientesToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.clientesToolStripMenuItem.Text = "Clientes";
            this.clientesToolStripMenuItem.Click += new System.EventHandler(this.clientesToolStripMenuItem_Click);
            // 
            // creditoToolStripMenuItem
            // 
            this.creditoToolStripMenuItem.Name = "creditoToolStripMenuItem";
            this.creditoToolStripMenuItem.Size = new System.Drawing.Size(58, 20);
            this.creditoToolStripMenuItem.Text = "Credito";
            this.creditoToolStripMenuItem.Click += new System.EventHandler(this.creditoToolStripMenuItem_Click);
            // 
            // proveedoresToolStripMenuItem
            // 
            this.proveedoresToolStripMenuItem.Name = "proveedoresToolStripMenuItem";
            this.proveedoresToolStripMenuItem.Size = new System.Drawing.Size(84, 20);
            this.proveedoresToolStripMenuItem.Text = "Proveedores";
            this.proveedoresToolStripMenuItem.Click += new System.EventHandler(this.proveedoresToolStripMenuItem_Click);
            // 
            // ofertasToolStripMenuItem
            // 
            this.ofertasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuPubicacion,
            this.toolStripMenuCompras,
            this.toolStripMenuEntrega});
            this.ofertasToolStripMenuItem.Name = "ofertasToolStripMenuItem";
            this.ofertasToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.ofertasToolStripMenuItem.Text = "Ofertas";
            // 
            // toolStripMenuPubicacion
            // 
            this.toolStripMenuPubicacion.Name = "toolStripMenuPubicacion";
            this.toolStripMenuPubicacion.Size = new System.Drawing.Size(175, 22);
            this.toolStripMenuPubicacion.Text = "Lista De Ofertas";
            this.toolStripMenuPubicacion.Click += new System.EventHandler(this.toolStripMenuPubicacion_Click);
            // 
            // toolStripMenuCompras
            // 
            this.toolStripMenuCompras.Name = "toolStripMenuCompras";
            this.toolStripMenuCompras.Size = new System.Drawing.Size(175, 22);
            this.toolStripMenuCompras.Text = "Compra De Ofertas";
            this.toolStripMenuCompras.Click += new System.EventHandler(this.toolStripMenuCompras_Click);
            // 
            // toolStripMenuEntrega
            // 
            this.toolStripMenuEntrega.Name = "toolStripMenuEntrega";
            this.toolStripMenuEntrega.Size = new System.Drawing.Size(219, 22);
            this.toolStripMenuEntrega.Text = "Entrega de Ofertas";
            // 
            // facturaciónToolStripMenuItem
            // 
            this.facturaciónToolStripMenuItem.Name = "facturaciónToolStripMenuItem";
            this.facturaciónToolStripMenuItem.Size = new System.Drawing.Size(81, 20);
            this.facturaciónToolStripMenuItem.Text = "Facturación";
            this.facturaciónToolStripMenuItem.Click += new System.EventHandler(this.facturaciónToolStripMenuItem_Click);
            // 
            // estadisticasToolStripMenuItem
            // 
            this.estadisticasToolStripMenuItem.Name = "estadisticasToolStripMenuItem";
            this.estadisticasToolStripMenuItem.Size = new System.Drawing.Size(79, 20);
            this.estadisticasToolStripMenuItem.Text = "Estadisticas";
            this.estadisticasToolStripMenuItem.Click += new System.EventHandler(this.estadisticasToolStripMenuItem_Click);
            // 
            // cambiarContraseñaToolStripMenuItem
            // 
            this.cambiarContraseñaToolStripMenuItem.Name = "cambiarContraseñaToolStripMenuItem";
            this.cambiarContraseñaToolStripMenuItem.Size = new System.Drawing.Size(127, 20);
            this.cambiarContraseñaToolStripMenuItem.Text = "Cambiar Contraseña";
            this.cambiarContraseñaToolStripMenuItem.Click += new System.EventHandler(this.cambiarContraseñaToolStripMenuItem_Click);
            // 
            // aCercaDeToolStripMenuItem
            // 
            this.aCercaDeToolStripMenuItem.Name = "aCercaDeToolStripMenuItem";
            this.aCercaDeToolStripMenuItem.Size = new System.Drawing.Size(85, 20);
            this.aCercaDeToolStripMenuItem.Text = "A Cerca de...";
            this.aCercaDeToolStripMenuItem.Click += new System.EventHandler(this.aCercaDeToolStripMenuItem_Click);
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.GreenYellow;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.mnuPrincipal);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.mnuPrincipal;
            this.Name = "Principal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Principal";
            this.Load += new System.EventHandler(this.Principal_Load);
            this.mnuPrincipal.ResumeLayout(false);
            this.mnuPrincipal.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnuPrincipal;
        private System.Windows.Forms.ToolStripMenuItem mnuRoles;
        private System.Windows.Forms.ToolStripMenuItem clientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cuentasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aCercaDeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cambiarContraseñaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem proveedoresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem creditoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ofertasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuPubicacion;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuCompras;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuEntrega;
        private System.Windows.Forms.ToolStripMenuItem facturaciónToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem estadisticasToolStripMenuItem;
    }
}

