namespace FrbaOfertas.Facturar
{
    partial class FrmAltaFactura
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAltaFactura));
            this.Label4 = new System.Windows.Forms.Label();
            this.panComandos = new System.Windows.Forms.Panel();
            this.btnComponer = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dtpFechaFactura = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.txtMontoTotal = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cboProveedor = new System.Windows.Forms.ComboBox();
            this.dtpFechaHasta = new System.Windows.Forms.DateTimePicker();
            this.dtpFechaDesde = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dgvDisponibles = new FrbaOfertas.Componentes.GrillaGestionDatos();
            this.colFecha_Venc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEstado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFuncionalidades = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFecha_Publi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPrecio_Oferta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEstado_Cupon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPrecioUnitario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.panComandos.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDisponibles)).BeginInit();
            this.SuspendLayout();
            // 
            // Label4
            // 
            this.Label4.BackColor = System.Drawing.Color.CadetBlue;
            this.Label4.Dock = System.Windows.Forms.DockStyle.Top;
            this.Label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label4.ForeColor = System.Drawing.Color.White;
            this.Label4.Location = new System.Drawing.Point(0, 0);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(723, 19);
            this.Label4.TabIndex = 27;
            this.Label4.Text = "Datos Factura";
            this.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panComandos
            // 
            this.panComandos.BackColor = System.Drawing.Color.LightSteelBlue;
            this.panComandos.Controls.Add(this.btnComponer);
            this.panComandos.Controls.Add(this.btnCancelar);
            this.panComandos.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panComandos.Location = new System.Drawing.Point(0, 497);
            this.panComandos.Name = "panComandos";
            this.panComandos.Size = new System.Drawing.Size(723, 32);
            this.panComandos.TabIndex = 28;
            // 
            // btnComponer
            // 
            this.btnComponer.BackColor = System.Drawing.SystemColors.Control;
            this.btnComponer.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnComponer.Location = new System.Drawing.Point(562, 3);
            this.btnComponer.Name = "btnComponer";
            this.btnComponer.Size = new System.Drawing.Size(75, 25);
            this.btnComponer.TabIndex = 2;
            this.btnComponer.Text = "Guardar";
            this.btnComponer.UseVisualStyleBackColor = false;
            this.btnComponer.Click += new System.EventHandler(this.btnComponer_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancelar.BackColor = System.Drawing.SystemColors.Control;
            this.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancelar.Location = new System.Drawing.Point(643, 3);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 25);
            this.btnCancelar.TabIndex = 1;
            this.btnCancelar.Text = "Cerrar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dtpFechaFactura);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.txtMontoTotal);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.cboProveedor);
            this.panel1.Controls.Add(this.dtpFechaHasta);
            this.panel1.Controls.Add(this.dtpFechaDesde);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txtCodigo);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.btnBuscar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 19);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(723, 89);
            this.panel1.TabIndex = 29;
            // 
            // dtpFechaFactura
            // 
            this.dtpFechaFactura.Enabled = false;
            this.dtpFechaFactura.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaFactura.Location = new System.Drawing.Point(391, 57);
            this.dtpFechaFactura.Name = "dtpFechaFactura";
            this.dtpFechaFactura.Size = new System.Drawing.Size(143, 20);
            this.dtpFechaFactura.TabIndex = 25;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(287, 62);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(99, 13);
            this.label9.TabIndex = 24;
            this.label9.Text = "Fecha Facturación:";
            // 
            // txtMontoTotal
            // 
            this.txtMontoTotal.Enabled = false;
            this.txtMontoTotal.Location = new System.Drawing.Point(128, 57);
            this.txtMontoTotal.Name = "txtMontoTotal";
            this.txtMontoTotal.Size = new System.Drawing.Size(143, 20);
            this.txtMontoTotal.TabIndex = 23;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(81, 60);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(40, 13);
            this.label8.TabIndex = 22;
            this.label8.Text = "Monto:";
            // 
            // cboProveedor
            // 
            this.cboProveedor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboProveedor.FormattingEnabled = true;
            this.cboProveedor.Location = new System.Drawing.Point(68, 4);
            this.cboProveedor.Name = "cboProveedor";
            this.cboProveedor.Size = new System.Drawing.Size(213, 21);
            this.cboProveedor.TabIndex = 21;
            this.cboProveedor.SelectedIndexChanged += new System.EventHandler(this.cboProveedor_SelectedIndexChanged);
            // 
            // dtpFechaHasta
            // 
            this.dtpFechaHasta.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaHasta.Location = new System.Drawing.Point(391, 31);
            this.dtpFechaHasta.Name = "dtpFechaHasta";
            this.dtpFechaHasta.Size = new System.Drawing.Size(143, 20);
            this.dtpFechaHasta.TabIndex = 20;
            this.dtpFechaHasta.ValueChanged += new System.EventHandler(this.dtpFechaHasta_ValueChanged);
            // 
            // dtpFechaDesde
            // 
            this.dtpFechaDesde.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaDesde.Location = new System.Drawing.Point(128, 31);
            this.dtpFechaDesde.Name = "dtpFechaDesde";
            this.dtpFechaDesde.Size = new System.Drawing.Size(143, 20);
            this.dtpFechaDesde.TabIndex = 19;
            this.dtpFechaDesde.ValueChanged += new System.EventHandler(this.dtpFechaDesde_ValueChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(287, 36);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(98, 13);
            this.label6.TabIndex = 18;
            this.label6.Text = "Fecha items Hasta:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 36);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(101, 13);
            this.label5.TabIndex = 17;
            this.label5.Text = "Fecha items Desde:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 7);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "Proveedor:";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Enabled = false;
            this.txtCodigo.Location = new System.Drawing.Point(391, 5);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(143, 20);
            this.txtCodigo.TabIndex = 15;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(287, 7);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(98, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Número de factura:";
            // 
            // btnBuscar
            // 
            this.btnBuscar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBuscar.BackColor = System.Drawing.SystemColors.Control;
            this.btnBuscar.Location = new System.Drawing.Point(636, 7);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 25);
            this.btnBuscar.TabIndex = 13;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dgvDisponibles);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 127);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(723, 370);
            this.panel2.TabIndex = 31;
            // 
            // dgvDisponibles
            // 
            this.dgvDisponibles.AjustarColumnas = false;
            this.dgvDisponibles.AllowUserToAddRows = false;
            this.dgvDisponibles.AllowUserToDeleteRows = false;
            this.dgvDisponibles.AllowUserToResizeRows = false;
            this.dgvDisponibles.CheckOnClick = false;
            this.dgvDisponibles.ChecksDataPropertyName = null;
            this.dgvDisponibles.ChecksToolTipText = "";
            this.dgvDisponibles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDisponibles.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colFecha_Venc,
            this.colEstado,
            this.colFuncionalidades,
            this.colFecha_Publi,
            this.colPrecio_Oferta,
            this.colEstado_Cupon,
            this.colCantidad,
            this.colPrecioUnitario});
            this.dgvDisponibles.ColumnsOcultas = ((System.Collections.Generic.List<string>)(resources.GetObject("dgvDisponibles.ColumnsOcultas")));
            this.dgvDisponibles.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDisponibles.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvDisponibles.EventSyncInvoke = null;
            this.dgvDisponibles.Exportar_FinDeColumna = "\t";
            this.dgvDisponibles.Exportar_FinDeFila = "\r\n";
            this.dgvDisponibles.Exportar_FinDeLineaEnCelda = ",";
            this.dgvDisponibles.ItemsChequeados = ((System.Collections.IEnumerable)(resources.GetObject("dgvDisponibles.ItemsChequeados")));
            this.dgvDisponibles.Location = new System.Drawing.Point(0, 0);
            this.dgvDisponibles.MantenerSeleccionAlReordenar = false;
            this.dgvDisponibles.MostrarWaitWindowOnDataSourceChanged = false;
            this.dgvDisponibles.MultiSelect = false;
            this.dgvDisponibles.Name = "dgvDisponibles";
            this.dgvDisponibles.PermiteOcultarColumnas = true;
            this.dgvDisponibles.ResaltarCeldasEditables = false;
            this.dgvDisponibles.RowHeadersVisible = false;
            this.dgvDisponibles.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDisponibles.Size = new System.Drawing.Size(723, 370);
            this.dgvDisponibles.StatusTripAMostrarAlerta = null;
            this.dgvDisponibles.TabIndex = 26;
            this.dgvDisponibles.TieneCheckMasivo = false;
            this.dgvDisponibles.TieneCopiarDatos = true;
            this.dgvDisponibles.TieneExportarDatos = false;
            this.dgvDisponibles.CambioChequeadosMultiplesItems += new System.EventHandler(this.dgvDisponibles_CambioChequeadosMultiplesItems);
            this.dgvDisponibles.CargarMenuContextual += new System.EventHandler(this.dgvDisponibles_CargarMenuContextual);
            this.dgvDisponibles.CambioChequeadosUnItem += new System.EventHandler<System.Windows.Forms.DataGridViewCellEventArgs>(this.dgvDisponibles_CambioChequeadosUnItem);
            // 
            // colFecha_Venc
            // 
            this.colFecha_Venc.DataPropertyName = "ClienteNombre";
            this.colFecha_Venc.HeaderText = "Cliente";
            this.colFecha_Venc.Name = "colFecha_Venc";
            // 
            // colEstado
            // 
            this.colEstado.DataPropertyName = "OfertaNombre";
            this.colEstado.HeaderText = "Oferta";
            this.colEstado.Name = "colEstado";
            // 
            // colFuncionalidades
            // 
            this.colFuncionalidades.DataPropertyName = "Fecha_Compra";
            this.colFuncionalidades.HeaderText = "Fecha de Compra";
            this.colFuncionalidades.Name = "colFuncionalidades";
            this.colFuncionalidades.Width = 120;
            // 
            // colFecha_Publi
            // 
            this.colFecha_Publi.DataPropertyName = "Fecha_Entrega";
            this.colFecha_Publi.HeaderText = "Fecha entrega";
            this.colFecha_Publi.Name = "colFecha_Publi";
            // 
            // colPrecio_Oferta
            // 
            this.colPrecio_Oferta.DataPropertyName = "Codigo_Cupon";
            this.colPrecio_Oferta.HeaderText = "Cupon";
            this.colPrecio_Oferta.Name = "colPrecio_Oferta";
            // 
            // colEstado_Cupon
            // 
            this.colEstado_Cupon.DataPropertyName = "Estado";
            this.colEstado_Cupon.HeaderText = "Estado";
            this.colEstado_Cupon.Name = "colEstado_Cupon";
            // 
            // colCantidad
            // 
            this.colCantidad.DataPropertyName = "Cantidad";
            this.colCantidad.HeaderText = "Cantidad";
            this.colCantidad.Name = "colCantidad";
            // 
            // colPrecioUnitario
            // 
            this.colPrecioUnitario.DataPropertyName = "Monto";
            this.colPrecioUnitario.HeaderText = "Precio Unitario";
            this.colPrecioUnitario.Name = "colPrecioUnitario";
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.CadetBlue;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(0, 108);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(723, 19);
            this.label1.TabIndex = 30;
            this.label1.Text = "Compras Disponibles";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // FrmAltaFactura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(723, 529);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panComandos);
            this.Controls.Add(this.Label4);
            this.MinimumSize = new System.Drawing.Size(739, 568);
            this.Name = "FrmAltaFactura";
            this.Text = "FrmAltaFactura";
            this.Load += new System.EventHandler(this.FrmAltaFactura_Load);
            this.Shown += new System.EventHandler(this.FrmAltaFactura_Shown);
            this.panComandos.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDisponibles)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label Label4;
        private System.Windows.Forms.Panel panComandos;
        private System.Windows.Forms.Button btnComponer;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private Componentes.GrillaGestionDatos dgvDisponibles;
        private System.Windows.Forms.DateTimePicker dtpFechaFactura;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtMontoTotal;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cboProveedor;
        private System.Windows.Forms.DateTimePicker dtpFechaHasta;
        private System.Windows.Forms.DateTimePicker dtpFechaDesde;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFecha_Venc;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEstado;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFuncionalidades;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFecha_Publi;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPrecio_Oferta;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEstado_Cupon;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPrecioUnitario;
    }
}