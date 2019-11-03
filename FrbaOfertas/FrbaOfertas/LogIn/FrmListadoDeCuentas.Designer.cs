namespace FrbaOfertas.LogIn
{
    partial class FrmListadoDeCuentas
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmListadoDeCuentas));
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.chkActivo = new System.Windows.Forms.CheckBox();
            this.txtUsuario_Cuenta = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.Label4 = new System.Windows.Forms.Label();
            this.panComandos = new System.Windows.Forms.Panel();
            this.btnCambiarContraseña = new System.Windows.Forms.Button();
            this.btnActivar = new System.Windows.Forms.Button();
            this.btnDesactivar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dgvCuentas = new FrbaOfertas.Componentes.GrillaGestionDatos();
            this.colNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCantidadIngresos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Estado_Cuenta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.agregarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.desactivarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.activarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.cambiarContraseñaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verRolesDeLaCuentaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnRolesCta = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panComandos.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCuentas)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.CadetBlue;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(0, 92);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(607, 19);
            this.label1.TabIndex = 16;
            this.label1.Text = "Listado";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.chkActivo);
            this.panel1.Controls.Add(this.txtUsuario_Cuenta);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.btnLimpiar);
            this.panel1.Controls.Add(this.btnBuscar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 19);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(607, 73);
            this.panel1.TabIndex = 17;
            // 
            // chkActivo
            // 
            this.chkActivo.AutoSize = true;
            this.chkActivo.Location = new System.Drawing.Point(80, 37);
            this.chkActivo.Name = "chkActivo";
            this.chkActivo.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.chkActivo.Size = new System.Drawing.Size(59, 17);
            this.chkActivo.TabIndex = 7;
            this.chkActivo.Text = ":Activo";
            this.chkActivo.UseVisualStyleBackColor = true;
            // 
            // txtUsuario_Cuenta
            // 
            this.txtUsuario_Cuenta.Location = new System.Drawing.Point(125, 11);
            this.txtUsuario_Cuenta.Name = "txtUsuario_Cuenta";
            this.txtUsuario_Cuenta.Size = new System.Drawing.Size(174, 20);
            this.txtUsuario_Cuenta.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Nombre de Usuario:";
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLimpiar.BackColor = System.Drawing.SystemColors.Control;
            this.btnLimpiar.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnLimpiar.Location = new System.Drawing.Point(520, 45);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(75, 25);
            this.btnLimpiar.TabIndex = 3;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = false;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBuscar.BackColor = System.Drawing.SystemColors.Control;
            this.btnBuscar.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnBuscar.Location = new System.Drawing.Point(520, 14);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 25);
            this.btnBuscar.TabIndex = 2;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // Label4
            // 
            this.Label4.BackColor = System.Drawing.Color.CadetBlue;
            this.Label4.Dock = System.Windows.Forms.DockStyle.Top;
            this.Label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label4.ForeColor = System.Drawing.Color.White;
            this.Label4.Location = new System.Drawing.Point(0, 0);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(607, 19);
            this.Label4.TabIndex = 14;
            this.Label4.Text = "Filtros";
            this.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panComandos
            // 
            this.panComandos.BackColor = System.Drawing.Color.LightSteelBlue;
            this.panComandos.Controls.Add(this.btnRolesCta);
            this.panComandos.Controls.Add(this.btnCambiarContraseña);
            this.panComandos.Controls.Add(this.btnActivar);
            this.panComandos.Controls.Add(this.btnDesactivar);
            this.panComandos.Controls.Add(this.btnAgregar);
            this.panComandos.Controls.Add(this.btnCancelar);
            this.panComandos.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panComandos.Location = new System.Drawing.Point(0, 347);
            this.panComandos.Name = "panComandos";
            this.panComandos.Size = new System.Drawing.Size(607, 32);
            this.panComandos.TabIndex = 15;
            // 
            // btnCambiarContraseña
            // 
            this.btnCambiarContraseña.BackColor = System.Drawing.SystemColors.Control;
            this.btnCambiarContraseña.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnCambiarContraseña.Location = new System.Drawing.Point(248, 3);
            this.btnCambiarContraseña.Name = "btnCambiarContraseña";
            this.btnCambiarContraseña.Size = new System.Drawing.Size(118, 25);
            this.btnCambiarContraseña.TabIndex = 5;
            this.btnCambiarContraseña.Text = "Cambiar Contraseña";
            this.btnCambiarContraseña.UseVisualStyleBackColor = false;
            this.btnCambiarContraseña.Click += new System.EventHandler(this.btnCambiarContraseña_Click);
            // 
            // btnActivar
            // 
            this.btnActivar.BackColor = System.Drawing.SystemColors.Control;
            this.btnActivar.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnActivar.Location = new System.Drawing.Point(167, 4);
            this.btnActivar.Name = "btnActivar";
            this.btnActivar.Size = new System.Drawing.Size(75, 25);
            this.btnActivar.TabIndex = 4;
            this.btnActivar.Text = "Activar";
            this.btnActivar.UseVisualStyleBackColor = false;
            this.btnActivar.Click += new System.EventHandler(this.btnActivar_Click);
            // 
            // btnDesactivar
            // 
            this.btnDesactivar.BackColor = System.Drawing.SystemColors.Control;
            this.btnDesactivar.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnDesactivar.Location = new System.Drawing.Point(86, 4);
            this.btnDesactivar.Name = "btnDesactivar";
            this.btnDesactivar.Size = new System.Drawing.Size(75, 25);
            this.btnDesactivar.TabIndex = 3;
            this.btnDesactivar.Text = "Desactivar";
            this.btnDesactivar.UseVisualStyleBackColor = false;
            this.btnDesactivar.Click += new System.EventHandler(this.btnDesactivar_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.SystemColors.Control;
            this.btnAgregar.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnAgregar.Location = new System.Drawing.Point(5, 4);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 25);
            this.btnAgregar.TabIndex = 2;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancelar.BackColor = System.Drawing.SystemColors.Control;
            this.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancelar.Location = new System.Drawing.Point(527, 4);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 25);
            this.btnCancelar.TabIndex = 1;
            this.btnCancelar.Text = "Cerrar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dgvCuentas);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 111);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(607, 236);
            this.panel2.TabIndex = 18;
            // 
            // dgvCuentas
            // 
            this.dgvCuentas.AjustarColumnas = false;
            this.dgvCuentas.AllowUserToAddRows = false;
            this.dgvCuentas.AllowUserToDeleteRows = false;
            this.dgvCuentas.AllowUserToResizeRows = false;
            this.dgvCuentas.CheckOnClick = false;
            this.dgvCuentas.ChecksDataPropertyName = null;
            this.dgvCuentas.ChecksToolTipText = "";
            this.dgvCuentas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCuentas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colNombre,
            this.colCantidadIngresos,
            this.Estado_Cuenta});
            this.dgvCuentas.ColumnsOcultas = ((System.Collections.Generic.List<string>)(resources.GetObject("dgvCuentas.ColumnsOcultas")));
            this.dgvCuentas.ContextMenuStrip = this.contextMenuStrip1;
            this.dgvCuentas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvCuentas.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvCuentas.EventSyncInvoke = null;
            this.dgvCuentas.Exportar_FinDeColumna = "\t";
            this.dgvCuentas.Exportar_FinDeFila = "\r\n";
            this.dgvCuentas.Exportar_FinDeLineaEnCelda = ",";
            this.dgvCuentas.ItemsChequeados = ((System.Collections.IEnumerable)(resources.GetObject("dgvCuentas.ItemsChequeados")));
            this.dgvCuentas.Location = new System.Drawing.Point(0, 0);
            this.dgvCuentas.MantenerSeleccionAlReordenar = false;
            this.dgvCuentas.MostrarWaitWindowOnDataSourceChanged = false;
            this.dgvCuentas.MultiSelect = false;
            this.dgvCuentas.Name = "dgvCuentas";
            this.dgvCuentas.PermiteOcultarColumnas = true;
            this.dgvCuentas.ResaltarCeldasEditables = false;
            this.dgvCuentas.RowHeadersVisible = false;
            this.dgvCuentas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCuentas.Size = new System.Drawing.Size(607, 236);
            this.dgvCuentas.StatusTripAMostrarAlerta = null;
            this.dgvCuentas.TabIndex = 13;
            this.dgvCuentas.TieneCheckMasivo = false;
            this.dgvCuentas.TieneCopiarDatos = true;
            this.dgvCuentas.TieneExportarDatos = false;
            this.dgvCuentas.CambioChequeadosMultiplesItems += new System.EventHandler(this.dgvCuentas_CambioChequeadosMultiplesItems);
            this.dgvCuentas.CambioChequeadosUnItem += new System.EventHandler<System.Windows.Forms.DataGridViewCellEventArgs>(this.dgvCuentas_CambioChequeadosUnItem);
            this.dgvCuentas.SelectionChanged += new System.EventHandler(this.dgvCuentas_SelectionChanged);
            // 
            // colNombre
            // 
            this.colNombre.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colNombre.DataPropertyName = "Usuario_Cuenta";
            this.colNombre.HeaderText = "Nombre";
            this.colNombre.Name = "colNombre";
            // 
            // colCantidadIngresos
            // 
            this.colCantidadIngresos.DataPropertyName = "Cant_Ingresos_Cuenta";
            this.colCantidadIngresos.HeaderText = "Ingresos fallidos";
            this.colCantidadIngresos.Name = "colCantidadIngresos";
            // 
            // Estado_Cuenta
            // 
            this.Estado_Cuenta.DataPropertyName = "Estado_Cuenta";
            this.Estado_Cuenta.HeaderText = "Estado Cuenta";
            this.Estado_Cuenta.Name = "Estado_Cuenta";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.agregarToolStripMenuItem,
            this.toolStripSeparator1,
            this.desactivarToolStripMenuItem,
            this.activarToolStripMenuItem,
            this.toolStripSeparator2,
            this.cambiarContraseñaToolStripMenuItem,
            this.verRolesDeLaCuentaToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(189, 148);
            // 
            // agregarToolStripMenuItem
            // 
            this.agregarToolStripMenuItem.Name = "agregarToolStripMenuItem";
            this.agregarToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.agregarToolStripMenuItem.Text = "Agregar";
            this.agregarToolStripMenuItem.Click += new System.EventHandler(this.agregarToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(185, 6);
            // 
            // desactivarToolStripMenuItem
            // 
            this.desactivarToolStripMenuItem.Name = "desactivarToolStripMenuItem";
            this.desactivarToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.desactivarToolStripMenuItem.Text = "Desactivar";
            this.desactivarToolStripMenuItem.Click += new System.EventHandler(this.desactivarToolStripMenuItem_Click);
            // 
            // activarToolStripMenuItem
            // 
            this.activarToolStripMenuItem.Name = "activarToolStripMenuItem";
            this.activarToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.activarToolStripMenuItem.Text = "Activar";
            this.activarToolStripMenuItem.Click += new System.EventHandler(this.activarToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(185, 6);
            // 
            // cambiarContraseñaToolStripMenuItem
            // 
            this.cambiarContraseñaToolStripMenuItem.Name = "cambiarContraseñaToolStripMenuItem";
            this.cambiarContraseñaToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.cambiarContraseñaToolStripMenuItem.Text = "Cambiar Contraseña";
            this.cambiarContraseñaToolStripMenuItem.Click += new System.EventHandler(this.cambiarContraseñaToolStripMenuItem_Click);
            // 
            // verRolesDeLaCuentaToolStripMenuItem
            // 
            this.verRolesDeLaCuentaToolStripMenuItem.Name = "verRolesDeLaCuentaToolStripMenuItem";
            this.verRolesDeLaCuentaToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.verRolesDeLaCuentaToolStripMenuItem.Text = "Ver Roles de la cuenta";
            this.verRolesDeLaCuentaToolStripMenuItem.Click += new System.EventHandler(this.verRolesDeLaCuentaToolStripMenuItem_Click);
            // 
            // btnRolesCta
            // 
            this.btnRolesCta.BackColor = System.Drawing.SystemColors.Control;
            this.btnRolesCta.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnRolesCta.Location = new System.Drawing.Point(372, 3);
            this.btnRolesCta.Name = "btnRolesCta";
            this.btnRolesCta.Size = new System.Drawing.Size(114, 25);
            this.btnRolesCta.TabIndex = 6;
            this.btnRolesCta.Text = "Roles de la cuenta";
            this.btnRolesCta.UseVisualStyleBackColor = false;
            this.btnRolesCta.Click += new System.EventHandler(this.btnRolesCta_Click);
            // 
            // FrmListadoDeCuentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(607, 379);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Label4);
            this.Controls.Add(this.panComandos);
            this.MinimumSize = new System.Drawing.Size(623, 418);
            this.Name = "FrmListadoDeCuentas";
            this.Text = "Listado De Cuentas";
            this.Load += new System.EventHandler(this.FrmListadoDeCuentas_Load);
            this.Shown += new System.EventHandler(this.FrmListadoDeCuentas_Shown);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panComandos.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCuentas)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.CheckBox chkActivo;
        private System.Windows.Forms.TextBox txtUsuario_Cuenta;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Label Label4;
        private Componentes.GrillaGestionDatos dgvCuentas;
        private System.Windows.Forms.Panel panComandos;
        private System.Windows.Forms.Button btnCambiarContraseña;
        private System.Windows.Forms.Button btnActivar;
        private System.Windows.Forms.Button btnDesactivar;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem agregarToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem desactivarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem activarToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem cambiarContraseñaToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCantidadIngresos;
        private System.Windows.Forms.DataGridViewTextBoxColumn Estado_Cuenta;
        private System.Windows.Forms.Button btnRolesCta;
        private System.Windows.Forms.ToolStripMenuItem verRolesDeLaCuentaToolStripMenuItem;
    }
}