namespace FrbaOfertas.Facturar
{
    partial class FrmListadoDeFacturas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmListadoDeFacturas));
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
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
            this.panel3 = new System.Windows.Forms.Panel();
            this.panComandos = new System.Windows.Forms.Panel();
            this.btnComponer = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dgvFacturas = new FrbaOfertas.Componentes.GrillaGestionDatos();
            this.colFecha_Venc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEstado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFuncionalidades = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFecha_Publi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPrecio_Oferta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.paginador = new FrbaOfertas.Componentes.paginador();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panComandos.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFacturas)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.CadetBlue;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(0, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(759, 19);
            this.label1.TabIndex = 28;
            this.label1.Text = "Listado";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel1
            // 
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
            this.panel1.Size = new System.Drawing.Size(759, 77);
            this.panel1.TabIndex = 29;
            // 
            // cboProveedor
            // 
            this.cboProveedor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboProveedor.FormattingEnabled = true;
            this.cboProveedor.Location = new System.Drawing.Point(87, 10);
            this.cboProveedor.Name = "cboProveedor";
            this.cboProveedor.Size = new System.Drawing.Size(213, 21);
            this.cboProveedor.TabIndex = 12;
            // 
            // dtpFechaHasta
            // 
            this.dtpFechaHasta.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaHasta.Location = new System.Drawing.Point(449, 42);
            this.dtpFechaHasta.Name = "dtpFechaHasta";
            this.dtpFechaHasta.Size = new System.Drawing.Size(143, 20);
            this.dtpFechaHasta.TabIndex = 11;
            // 
            // dtpFechaDesde
            // 
            this.dtpFechaDesde.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaDesde.Location = new System.Drawing.Point(157, 42);
            this.dtpFechaDesde.Name = "dtpFechaDesde";
            this.dtpFechaDesde.Size = new System.Drawing.Size(143, 20);
            this.dtpFechaDesde.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(315, 48);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(107, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Fecha factura Hasta:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(24, 48);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(110, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Fecha factura Desde:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Proveedor:";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(418, 15);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(174, 20);
            this.txtCodigo.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(321, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Número de factura:";
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLimpiar.BackColor = System.Drawing.SystemColors.Control;
            this.btnLimpiar.Location = new System.Drawing.Point(672, 37);
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
            this.btnBuscar.Location = new System.Drawing.Point(672, 6);
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
            this.Label4.Size = new System.Drawing.Size(759, 19);
            this.Label4.TabIndex = 26;
            this.Label4.Text = "Filtros";
            this.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.paginador);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 311);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(759, 28);
            this.panel3.TabIndex = 30;
            // 
            // panComandos
            // 
            this.panComandos.BackColor = System.Drawing.Color.LightSteelBlue;
            this.panComandos.Controls.Add(this.btnComponer);
            this.panComandos.Controls.Add(this.btnCancelar);
            this.panComandos.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panComandos.Location = new System.Drawing.Point(0, 339);
            this.panComandos.Name = "panComandos";
            this.panComandos.Size = new System.Drawing.Size(759, 32);
            this.panComandos.TabIndex = 27;
            // 
            // btnComponer
            // 
            this.btnComponer.BackColor = System.Drawing.SystemColors.Control;
            this.btnComponer.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnComponer.Location = new System.Drawing.Point(11, 4);
            this.btnComponer.Name = "btnComponer";
            this.btnComponer.Size = new System.Drawing.Size(75, 25);
            this.btnComponer.TabIndex = 2;
            this.btnComponer.Text = "Componer Factura";
            this.btnComponer.UseVisualStyleBackColor = false;
            this.btnComponer.Click += new System.EventHandler(this.btnComponer_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancelar.BackColor = System.Drawing.SystemColors.Control;
            this.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancelar.Location = new System.Drawing.Point(679, 4);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 25);
            this.btnCancelar.TabIndex = 1;
            this.btnCancelar.Text = "Cerrar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dgvFacturas);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 115);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(759, 196);
            this.panel2.TabIndex = 31;
            // 
            // dgvFacturas
            // 
            this.dgvFacturas.AjustarColumnas = false;
            this.dgvFacturas.AllowUserToAddRows = false;
            this.dgvFacturas.AllowUserToDeleteRows = false;
            this.dgvFacturas.AllowUserToResizeRows = false;
            this.dgvFacturas.CheckOnClick = false;
            this.dgvFacturas.ChecksDataPropertyName = null;
            this.dgvFacturas.ChecksToolTipText = "";
            this.dgvFacturas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFacturas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colFecha_Venc,
            this.colEstado,
            this.colFuncionalidades,
            this.colFecha_Publi,
            this.colPrecio_Oferta});
            this.dgvFacturas.ColumnsOcultas = ((System.Collections.Generic.List<string>)(resources.GetObject("dgvFacturas.ColumnsOcultas")));
            this.dgvFacturas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvFacturas.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvFacturas.EventSyncInvoke = null;
            this.dgvFacturas.Exportar_FinDeColumna = "\t";
            this.dgvFacturas.Exportar_FinDeFila = "\r\n";
            this.dgvFacturas.Exportar_FinDeLineaEnCelda = ",";
            this.dgvFacturas.ItemsChequeados = ((System.Collections.IEnumerable)(resources.GetObject("dgvFacturas.ItemsChequeados")));
            this.dgvFacturas.Location = new System.Drawing.Point(0, 0);
            this.dgvFacturas.MantenerSeleccionAlReordenar = false;
            this.dgvFacturas.MostrarWaitWindowOnDataSourceChanged = false;
            this.dgvFacturas.MultiSelect = false;
            this.dgvFacturas.Name = "dgvFacturas";
            this.dgvFacturas.PermiteOcultarColumnas = true;
            this.dgvFacturas.ResaltarCeldasEditables = false;
            this.dgvFacturas.RowHeadersVisible = false;
            this.dgvFacturas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvFacturas.Size = new System.Drawing.Size(759, 196);
            this.dgvFacturas.StatusTripAMostrarAlerta = null;
            this.dgvFacturas.TabIndex = 25;
            this.dgvFacturas.TieneCheckMasivo = false;
            this.dgvFacturas.TieneCopiarDatos = true;
            this.dgvFacturas.TieneExportarDatos = false;
            this.dgvFacturas.CambioChequeadosMultiplesItems += new System.EventHandler(this.dgvFacturas_CambioChequeadosMultiplesItems);
            this.dgvFacturas.CargarMenuContextual += new System.EventHandler(this.dgvFacturas_CargarMenuContextual);
            this.dgvFacturas.CambioChequeadosUnItem += new System.EventHandler<System.Windows.Forms.DataGridViewCellEventArgs>(this.dgvFacturas_CambioChequeadosUnItem);
            // 
            // colFecha_Venc
            // 
            this.colFecha_Venc.DataPropertyName = "Tipo_Fact";
            this.colFecha_Venc.HeaderText = "Tipo Factura";
            this.colFecha_Venc.Name = "colFecha_Venc";
            // 
            // colEstado
            // 
            this.colEstado.DataPropertyName = "Numero_Fact";
            this.colEstado.HeaderText = "Número Factura";
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
            this.colFecha_Publi.DataPropertyName = "Fecha_Fact";
            this.colFecha_Publi.HeaderText = "Fecha";
            this.colFecha_Publi.Name = "colFecha_Publi";
            // 
            // colPrecio_Oferta
            // 
            this.colPrecio_Oferta.DataPropertyName = "Total_Fact";
            this.colPrecio_Oferta.HeaderText = "Total Factura";
            this.colPrecio_Oferta.Name = "colPrecio_Oferta";
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
            // FrmListadoDeFacturas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(759, 371);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Label4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panComandos);
            this.Name = "FrmListadoDeFacturas";
            this.Text = "Listado de Facturas";
            this.Load += new System.EventHandler(this.FrmListadoDeFacturas_Load);
            this.Shown += new System.EventHandler(this.FrmListadoDeFacturas_Shown);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panComandos.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFacturas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cboProveedor;
        private System.Windows.Forms.DateTimePicker dtpFechaHasta;
        private System.Windows.Forms.DateTimePicker dtpFechaDesde;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Label Label4;
        private Componentes.GrillaGestionDatos dgvFacturas;
        private Componentes.paginador paginador;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panComandos;
        private System.Windows.Forms.Button btnComponer;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFecha_Venc;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEstado;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFuncionalidades;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFecha_Publi;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPrecio_Oferta;
    }
}