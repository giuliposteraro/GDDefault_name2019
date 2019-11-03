namespace FrbaOfertas.AbmRol
{
    partial class FrmListadoDeRoles
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmListadoDeRoles));
            this.panel2 = new System.Windows.Forms.Panel();
            this.dgvRoles = new FrbaOfertas.Componentes.GrillaGestionDatos();
            this.colNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEstado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFuncionalidades = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.agregarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modificarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.asignarAUsuarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.Label4 = new System.Windows.Forms.Label();
            this.panComandos = new System.Windows.Forms.Panel();
            this.btnAsignar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.reHabilitarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRoles)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panComandos.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dgvRoles);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 111);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(580, 151);
            this.panel2.TabIndex = 18;
            // 
            // dgvRoles
            // 
            this.dgvRoles.AjustarColumnas = false;
            this.dgvRoles.AllowUserToAddRows = false;
            this.dgvRoles.AllowUserToDeleteRows = false;
            this.dgvRoles.AllowUserToResizeRows = false;
            this.dgvRoles.CheckOnClick = false;
            this.dgvRoles.ChecksDataPropertyName = null;
            this.dgvRoles.ChecksToolTipText = "";
            this.dgvRoles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRoles.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colNombre,
            this.colEstado,
            this.colFuncionalidades});
            this.dgvRoles.ColumnsOcultas = ((System.Collections.Generic.List<string>)(resources.GetObject("dgvRoles.ColumnsOcultas")));
            this.dgvRoles.ContextMenuStrip = this.contextMenuStrip1;
            this.dgvRoles.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvRoles.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvRoles.EventSyncInvoke = null;
            this.dgvRoles.Exportar_FinDeColumna = "\t";
            this.dgvRoles.Exportar_FinDeFila = "\r\n";
            this.dgvRoles.Exportar_FinDeLineaEnCelda = ",";
            this.dgvRoles.ItemsChequeados = ((System.Collections.IEnumerable)(resources.GetObject("dgvRoles.ItemsChequeados")));
            this.dgvRoles.Location = new System.Drawing.Point(0, 0);
            this.dgvRoles.MantenerSeleccionAlReordenar = false;
            this.dgvRoles.MostrarWaitWindowOnDataSourceChanged = false;
            this.dgvRoles.MultiSelect = false;
            this.dgvRoles.Name = "dgvRoles";
            this.dgvRoles.PermiteOcultarColumnas = true;
            this.dgvRoles.ResaltarCeldasEditables = false;
            this.dgvRoles.RowHeadersVisible = false;
            this.dgvRoles.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvRoles.Size = new System.Drawing.Size(580, 151);
            this.dgvRoles.StatusTripAMostrarAlerta = null;
            this.dgvRoles.TabIndex = 0;
            this.dgvRoles.TieneCheckMasivo = false;
            this.dgvRoles.TieneCopiarDatos = true;
            this.dgvRoles.TieneExportarDatos = false;
            this.dgvRoles.CambioChequeadosMultiplesItems += new System.EventHandler(this.dgvRoles_CambioChequeadosMultiplesItems);
            this.dgvRoles.CambioChequeadosUnItem += new System.EventHandler<System.Windows.Forms.DataGridViewCellEventArgs>(this.dgvRoles_CambioChequeadosUnItem);
            this.dgvRoles.SelectionChanged += new System.EventHandler(this.dgvRoles_SelectionChanged);
            // 
            // colNombre
            // 
            this.colNombre.DataPropertyName = "Nombre_Rol";
            this.colNombre.HeaderText = "Nombre";
            this.colNombre.Name = "colNombre";
            // 
            // colEstado
            // 
            this.colEstado.DataPropertyName = "EstadoComoString";
            this.colEstado.HeaderText = "Estado";
            this.colEstado.Name = "colEstado";
            // 
            // colFuncionalidades
            // 
            this.colFuncionalidades.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colFuncionalidades.DataPropertyName = "Funcionalidades";
            this.colFuncionalidades.HeaderText = "Funcionalidades";
            this.colFuncionalidades.Name = "colFuncionalidades";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.agregarToolStripMenuItem,
            this.modificarToolStripMenuItem,
            this.eliminarToolStripMenuItem,
            this.asignarAUsuarioToolStripMenuItem,
            this.reHabilitarToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(169, 136);
            // 
            // agregarToolStripMenuItem
            // 
            this.agregarToolStripMenuItem.Name = "agregarToolStripMenuItem";
            this.agregarToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.agregarToolStripMenuItem.Text = "Agregar";
            this.agregarToolStripMenuItem.Click += new System.EventHandler(this.agregarToolStripMenuItem_Click);
            // 
            // modificarToolStripMenuItem
            // 
            this.modificarToolStripMenuItem.Name = "modificarToolStripMenuItem";
            this.modificarToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.modificarToolStripMenuItem.Text = "Modificar";
            this.modificarToolStripMenuItem.Click += new System.EventHandler(this.modificarToolStripMenuItem_Click);
            // 
            // eliminarToolStripMenuItem
            // 
            this.eliminarToolStripMenuItem.Name = "eliminarToolStripMenuItem";
            this.eliminarToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.eliminarToolStripMenuItem.Text = "Eliminar";
            this.eliminarToolStripMenuItem.Click += new System.EventHandler(this.eliminarToolStripMenuItem_Click);
            // 
            // asignarAUsuarioToolStripMenuItem
            // 
            this.asignarAUsuarioToolStripMenuItem.Name = "asignarAUsuarioToolStripMenuItem";
            this.asignarAUsuarioToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.asignarAUsuarioToolStripMenuItem.Text = "Asignar A Usuario";
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.CadetBlue;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(0, 92);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(580, 19);
            this.label1.TabIndex = 16;
            this.label1.Text = "Listado";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtNombre);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.btnLimpiar);
            this.panel1.Controls.Add(this.btnBuscar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 19);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(580, 73);
            this.panel1.TabIndex = 17;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(74, 11);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(174, 20);
            this.txtNombre.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Nombre:";
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLimpiar.BackColor = System.Drawing.SystemColors.Control;
            this.btnLimpiar.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnLimpiar.Location = new System.Drawing.Point(493, 37);
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
            this.btnBuscar.Location = new System.Drawing.Point(493, 6);
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
            this.Label4.Size = new System.Drawing.Size(580, 19);
            this.Label4.TabIndex = 14;
            this.Label4.Text = "Filtros";
            this.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panComandos
            // 
            this.panComandos.BackColor = System.Drawing.Color.LightSteelBlue;
            this.panComandos.Controls.Add(this.btnAsignar);
            this.panComandos.Controls.Add(this.btnEliminar);
            this.panComandos.Controls.Add(this.btnModificar);
            this.panComandos.Controls.Add(this.btnAgregar);
            this.panComandos.Controls.Add(this.btnCancelar);
            this.panComandos.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panComandos.Location = new System.Drawing.Point(0, 262);
            this.panComandos.Name = "panComandos";
            this.panComandos.Size = new System.Drawing.Size(580, 32);
            this.panComandos.TabIndex = 15;
            // 
            // btnAsignar
            // 
            this.btnAsignar.BackColor = System.Drawing.SystemColors.Control;
            this.btnAsignar.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnAsignar.Location = new System.Drawing.Point(249, 4);
            this.btnAsignar.Name = "btnAsignar";
            this.btnAsignar.Size = new System.Drawing.Size(107, 25);
            this.btnAsignar.TabIndex = 5;
            this.btnAsignar.Text = "Asignar A Usuario";
            this.btnAsignar.UseVisualStyleBackColor = false;
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.SystemColors.Control;
            this.btnEliminar.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnEliminar.Location = new System.Drawing.Point(168, 4);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 25);
            this.btnEliminar.TabIndex = 4;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.BackColor = System.Drawing.SystemColors.Control;
            this.btnModificar.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnModificar.Location = new System.Drawing.Point(89, 4);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(75, 25);
            this.btnModificar.TabIndex = 3;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = false;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.SystemColors.Control;
            this.btnAgregar.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnAgregar.Location = new System.Drawing.Point(11, 4);
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
            this.btnCancelar.Location = new System.Drawing.Point(500, 4);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 25);
            this.btnCancelar.TabIndex = 1;
            this.btnCancelar.Text = "Cerrar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            // 
            // reHabilitarToolStripMenuItem
            // 
            this.reHabilitarToolStripMenuItem.Name = "reHabilitarToolStripMenuItem";
            this.reHabilitarToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.reHabilitarToolStripMenuItem.Text = "Re habilitar";
            this.reHabilitarToolStripMenuItem.Click += new System.EventHandler(this.reHabilitarToolStripMenuItem_Click);
            // 
            // FrmListadoDeRoles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(580, 294);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Label4);
            this.Controls.Add(this.panComandos);
            this.MinimumSize = new System.Drawing.Size(596, 333);
            this.Name = "FrmListadoDeRoles";
            this.Text = "Lista de Roles";
            this.Load += new System.EventHandler(this.FrmListadoDeRoles_Load);
            this.Shown += new System.EventHandler(this.FrmListadoDeRoles_Shown);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRoles)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panComandos.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private Componentes.GrillaGestionDatos dgvRoles;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Label Label4;
        private System.Windows.Forms.Panel panComandos;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnAsignar;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEstado;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFuncionalidades;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem agregarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modificarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eliminarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem asignarAUsuarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reHabilitarToolStripMenuItem;
    }
}