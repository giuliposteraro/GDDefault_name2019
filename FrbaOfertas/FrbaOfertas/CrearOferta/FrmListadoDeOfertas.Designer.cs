namespace FrbaOfertas.CrearOferta
{
    partial class FrmListadoDeOfertas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmListadoDeOfertas));
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblAlertaUsuario = new System.Windows.Forms.Label();
            this.cboProveedor = new System.Windows.Forms.ComboBox();
            this.dtpFechaHasta = new System.Windows.Forms.DateTimePicker();
            this.dtpFechaDesde = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.Label4 = new System.Windows.Forms.Label();
            this.dgvOfertas = new FrbaOfertas.Componentes.GrillaGestionDatos();
            this.colNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEstado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFuncionalidades = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFecha_Publi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFecha_Venc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPrecio_Oferta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPrecioLista = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMaximoPorCompra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.publicarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modificarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panComandos = new System.Windows.Forms.Panel();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.paginador = new FrbaOfertas.Componentes.paginador();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOfertas)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.panComandos.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.CadetBlue;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(0, 119);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(697, 19);
            this.label1.TabIndex = 21;
            this.label1.Text = "Listado";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblAlertaUsuario);
            this.panel1.Controls.Add(this.cboProveedor);
            this.panel1.Controls.Add(this.dtpFechaHasta);
            this.panel1.Controls.Add(this.dtpFechaDesde);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txtCodigo);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.btnLimpiar);
            this.panel1.Controls.Add(this.btnBuscar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 19);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(697, 100);
            this.panel1.TabIndex = 22;
            // 
            // lblAlertaUsuario
            // 
            this.lblAlertaUsuario.AutoSize = true;
            this.lblAlertaUsuario.ForeColor = System.Drawing.Color.Red;
            this.lblAlertaUsuario.Image = global::FrbaOfertas.Properties.Resources.alerta;
            this.lblAlertaUsuario.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.lblAlertaUsuario.Location = new System.Drawing.Point(24, 72);
            this.lblAlertaUsuario.MaximumSize = new System.Drawing.Size(620, 0);
            this.lblAlertaUsuario.Name = "lblAlertaUsuario";
            this.lblAlertaUsuario.Size = new System.Drawing.Size(603, 26);
            this.lblAlertaUsuario.TabIndex = 20;
            this.lblAlertaUsuario.Text = "      El usuario actual no tiene un proveedor asociado, podrá ver las ofertas pub" +
    "licadas pero no podrá cargar o modificar ofertas\r\n.";
            this.lblAlertaUsuario.Visible = false;
            // 
            // cboProveedor
            // 
            this.cboProveedor.Enabled = false;
            this.cboProveedor.FormattingEnabled = true;
            this.cboProveedor.Location = new System.Drawing.Point(339, 9);
            this.cboProveedor.Name = "cboProveedor";
            this.cboProveedor.Size = new System.Drawing.Size(213, 21);
            this.cboProveedor.TabIndex = 12;
            // 
            // dtpFechaHasta
            // 
            this.dtpFechaHasta.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaHasta.Location = new System.Drawing.Point(339, 42);
            this.dtpFechaHasta.Name = "dtpFechaHasta";
            this.dtpFechaHasta.Size = new System.Drawing.Size(143, 20);
            this.dtpFechaHasta.TabIndex = 11;
            // 
            // dtpFechaDesde
            // 
            this.dtpFechaDesde.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaDesde.Location = new System.Drawing.Point(104, 42);
            this.dtpFechaDesde.Name = "dtpFechaDesde";
            this.dtpFechaDesde.Size = new System.Drawing.Size(143, 20);
            this.dtpFechaDesde.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(262, 48);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Fecha Hasta:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(24, 48);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Fecha Desde:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(277, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Proveedor:";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(74, 11);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(174, 20);
            this.txtCodigo.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Código:";
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLimpiar.BackColor = System.Drawing.SystemColors.Control;
            this.btnLimpiar.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnLimpiar.Location = new System.Drawing.Point(610, 37);
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
            this.btnBuscar.Location = new System.Drawing.Point(610, 6);
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
            this.Label4.Size = new System.Drawing.Size(697, 19);
            this.Label4.TabIndex = 19;
            this.Label4.Text = "Filtros";
            this.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dgvOfertas
            // 
            this.dgvOfertas.AjustarColumnas = false;
            this.dgvOfertas.AllowUserToAddRows = false;
            this.dgvOfertas.AllowUserToDeleteRows = false;
            this.dgvOfertas.AllowUserToResizeRows = false;
            this.dgvOfertas.CheckOnClick = false;
            this.dgvOfertas.ChecksDataPropertyName = null;
            this.dgvOfertas.ChecksToolTipText = "";
            this.dgvOfertas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOfertas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colNombre,
            this.colEstado,
            this.colFuncionalidades,
            this.colFecha_Publi,
            this.colFecha_Venc,
            this.colPrecio_Oferta,
            this.colPrecioLista,
            this.colCantidad,
            this.colMaximoPorCompra});
            this.dgvOfertas.ColumnsOcultas = ((System.Collections.Generic.List<string>)(resources.GetObject("dgvOfertas.ColumnsOcultas")));
            this.dgvOfertas.ContextMenuStrip = this.contextMenuStrip1;
            this.dgvOfertas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvOfertas.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvOfertas.EventSyncInvoke = null;
            this.dgvOfertas.Exportar_FinDeColumna = "\t";
            this.dgvOfertas.Exportar_FinDeFila = "\r\n";
            this.dgvOfertas.Exportar_FinDeLineaEnCelda = ",";
            this.dgvOfertas.ItemsChequeados = ((System.Collections.IEnumerable)(resources.GetObject("dgvOfertas.ItemsChequeados")));
            this.dgvOfertas.Location = new System.Drawing.Point(0, 0);
            this.dgvOfertas.MantenerSeleccionAlReordenar = false;
            this.dgvOfertas.MostrarWaitWindowOnDataSourceChanged = false;
            this.dgvOfertas.MultiSelect = false;
            this.dgvOfertas.Name = "dgvOfertas";
            this.dgvOfertas.PermiteOcultarColumnas = true;
            this.dgvOfertas.ResaltarCeldasEditables = false;
            this.dgvOfertas.RowHeadersVisible = false;
            this.dgvOfertas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvOfertas.Size = new System.Drawing.Size(697, 166);
            this.dgvOfertas.StatusTripAMostrarAlerta = null;
            this.dgvOfertas.TabIndex = 18;
            this.dgvOfertas.TieneCheckMasivo = false;
            this.dgvOfertas.TieneCopiarDatos = true;
            this.dgvOfertas.TieneExportarDatos = false;
            this.dgvOfertas.CambioChequeadosMultiplesItems += new System.EventHandler(this.dgvOfertas_CambioChequeadosMultiplesItems);
            this.dgvOfertas.CambioChequeadosUnItem += new System.EventHandler<System.Windows.Forms.DataGridViewCellEventArgs>(this.dgvOfertas_CambioChequeadosUnItem);
            this.dgvOfertas.SelectionChanged += new System.EventHandler(this.dgvOfertas_SelectionChanged);
            // 
            // colNombre
            // 
            this.colNombre.DataPropertyName = "Codigo_of";
            this.colNombre.HeaderText = "Código Oferta";
            this.colNombre.Name = "colNombre";
            // 
            // colEstado
            // 
            this.colEstado.DataPropertyName = "Descripcion_Of";
            this.colEstado.HeaderText = "Descripción";
            this.colEstado.Name = "colEstado";
            // 
            // colFuncionalidades
            // 
            this.colFuncionalidades.DataPropertyName = "ProveedorRazonSocial";
            this.colFuncionalidades.HeaderText = "Proveedor";
            this.colFuncionalidades.Name = "colFuncionalidades";
            this.colFuncionalidades.Width = 120;
            // 
            // colFecha_Publi
            // 
            this.colFecha_Publi.DataPropertyName = "Fecha_Publi_Of";
            this.colFecha_Publi.HeaderText = "Fecha Publicación";
            this.colFecha_Publi.Name = "colFecha_Publi";
            // 
            // colFecha_Venc
            // 
            this.colFecha_Venc.DataPropertyName = "Fecha_Venc_Of";
            this.colFecha_Venc.HeaderText = "Fecha Vencimiento";
            this.colFecha_Venc.Name = "colFecha_Venc";
            // 
            // colPrecio_Oferta
            // 
            this.colPrecio_Oferta.DataPropertyName = "Precio_Oferta";
            this.colPrecio_Oferta.HeaderText = "Precio Oferta";
            this.colPrecio_Oferta.Name = "colPrecio_Oferta";
            // 
            // colPrecioLista
            // 
            this.colPrecioLista.DataPropertyName = "Precio_Lista";
            this.colPrecioLista.HeaderText = "Precio de lista";
            this.colPrecioLista.Name = "colPrecioLista";
            // 
            // colCantidad
            // 
            this.colCantidad.DataPropertyName = "Cant_Disp_Oferta";
            this.colCantidad.HeaderText = "CantidadDisponible";
            this.colCantidad.Name = "colCantidad";
            // 
            // colMaximoPorCompra
            // 
            this.colMaximoPorCompra.DataPropertyName = "Maximo_Por_Compra";
            this.colMaximoPorCompra.HeaderText = "Máximo por Compra";
            this.colMaximoPorCompra.Name = "colMaximoPorCompra";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.publicarToolStripMenuItem,
            this.modificarToolStripMenuItem,
            this.eliminarToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(126, 70);
            // 
            // publicarToolStripMenuItem
            // 
            this.publicarToolStripMenuItem.Name = "publicarToolStripMenuItem";
            this.publicarToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.publicarToolStripMenuItem.Text = "Publicar";
            this.publicarToolStripMenuItem.Click += new System.EventHandler(this.publicarToolStripMenuItem_Click);
            // 
            // modificarToolStripMenuItem
            // 
            this.modificarToolStripMenuItem.Name = "modificarToolStripMenuItem";
            this.modificarToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.modificarToolStripMenuItem.Text = "Modificar";
            this.modificarToolStripMenuItem.Click += new System.EventHandler(this.modificarToolStripMenuItem_Click);
            // 
            // eliminarToolStripMenuItem
            // 
            this.eliminarToolStripMenuItem.Name = "eliminarToolStripMenuItem";
            this.eliminarToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.eliminarToolStripMenuItem.Text = "Eliminar";
            this.eliminarToolStripMenuItem.Click += new System.EventHandler(this.eliminarToolStripMenuItem_Click);
            // 
            // panComandos
            // 
            this.panComandos.BackColor = System.Drawing.Color.LightSteelBlue;
            this.panComandos.Controls.Add(this.btnEliminar);
            this.panComandos.Controls.Add(this.btnModificar);
            this.panComandos.Controls.Add(this.btnAgregar);
            this.panComandos.Controls.Add(this.btnCancelar);
            this.panComandos.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panComandos.Location = new System.Drawing.Point(0, 332);
            this.panComandos.Name = "panComandos";
            this.panComandos.Size = new System.Drawing.Size(697, 32);
            this.panComandos.TabIndex = 20;
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
            this.btnAgregar.Text = "Publicar";
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancelar.BackColor = System.Drawing.SystemColors.Control;
            this.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancelar.Location = new System.Drawing.Point(617, 4);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 25);
            this.btnCancelar.TabIndex = 1;
            this.btnCancelar.Text = "Cerrar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.paginador);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 304);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(697, 28);
            this.panel3.TabIndex = 24;
            // 
            // paginador
            // 
            this.paginador.Location = new System.Drawing.Point(0, 0);
            this.paginador.Name = "paginador";
            this.paginador.Size = new System.Drawing.Size(667, 25);
            this.paginador.TabIndex = 2;
            this.paginador.SolicitarBusqueda += new System.EventHandler(this.paginador_SolicitarBusqueda);
            this.paginador.SeSeleccionaPaginaSiguiente += new System.EventHandler(this.paginador_SeSeleccionaPaginaSiguiente);
            this.paginador.SeSeleccionaUltimaPagina += new System.EventHandler(this.paginador_SeSeleccionaUltimaPagina);
            this.paginador.SeSeleccionaPaginaAnterior += new System.EventHandler(this.paginador_SeSeleccionaPaginaAnterior);
            this.paginador.SeSeleccionaPrimeraPagina += new System.EventHandler(this.paginador_SeSeleccionaPrimeraPagina);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dgvOfertas);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 138);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(697, 166);
            this.panel2.TabIndex = 25;
            // 
            // FrmListadoDeOfertas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(697, 364);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Label4);
            this.Controls.Add(this.panComandos);
            this.MinimumSize = new System.Drawing.Size(686, 353);
            this.Name = "FrmListadoDeOfertas";
            this.Text = "Listado De Ofertas";
            this.Load += new System.EventHandler(this.FrmListadoDeOfertas_Load);
            this.Shown += new System.EventHandler(this.FrmListadoDeOfertas_Shown);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOfertas)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.panComandos.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Label Label4;
        private Componentes.GrillaGestionDatos dgvOfertas;
        private System.Windows.Forms.Panel panComandos;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem publicarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modificarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eliminarToolStripMenuItem;
        private System.Windows.Forms.Panel panel3;
        private Componentes.paginador paginador;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ComboBox cboProveedor;
        private System.Windows.Forms.DateTimePicker dtpFechaHasta;
        private System.Windows.Forms.DateTimePicker dtpFechaDesde;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblAlertaUsuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEstado;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFuncionalidades;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFecha_Publi;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFecha_Venc;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPrecio_Oferta;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPrecioLista;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaximoPorCompra;
    }
}