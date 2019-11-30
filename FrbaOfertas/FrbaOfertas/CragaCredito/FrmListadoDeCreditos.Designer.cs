namespace FrbaOfertas.CragaCredito
{
    partial class FrmListadoDeCreditos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmListadoDeCreditos));
            this.panel2 = new System.Windows.Forms.Panel();
            this.dgvCreditos = new FrbaOfertas.Componentes.GrillaGestionDatos();
            this.colNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colApellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColCarga_Cred = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTarjeta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDetalle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTipo_Pago = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dtpFechaHasta = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.dtpFechaDesde = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.cboTiposDePago = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cboClientes = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.Label4 = new System.Windows.Forms.Label();
            this.panComandos = new System.Windows.Forms.Panel();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.paginador = new FrbaOfertas.Componentes.paginador();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCreditos)).BeginInit();
            this.panel1.SuspendLayout();
            this.panComandos.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dgvCreditos);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 111);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(783, 261);
            this.panel2.TabIndex = 18;
            // 
            // dgvCreditos
            // 
            this.dgvCreditos.AjustarColumnas = false;
            this.dgvCreditos.AllowUserToAddRows = false;
            this.dgvCreditos.AllowUserToDeleteRows = false;
            this.dgvCreditos.AllowUserToResizeRows = false;
            this.dgvCreditos.CheckOnClick = false;
            this.dgvCreditos.ChecksDataPropertyName = null;
            this.dgvCreditos.ChecksToolTipText = "";
            this.dgvCreditos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCreditos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colNombre,
            this.colApellido,
            this.ColCarga_Cred,
            this.colTarjeta,
            this.colDetalle,
            this.colTipo_Pago});
            this.dgvCreditos.ColumnsOcultas = ((System.Collections.Generic.List<string>)(resources.GetObject("dgvCreditos.ColumnsOcultas")));
            this.dgvCreditos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvCreditos.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvCreditos.EventSyncInvoke = null;
            this.dgvCreditos.Exportar_FinDeColumna = "\t";
            this.dgvCreditos.Exportar_FinDeFila = "\r\n";
            this.dgvCreditos.Exportar_FinDeLineaEnCelda = ",";
            this.dgvCreditos.ItemsChequeados = ((System.Collections.IEnumerable)(resources.GetObject("dgvCreditos.ItemsChequeados")));
            this.dgvCreditos.Location = new System.Drawing.Point(0, 0);
            this.dgvCreditos.MantenerSeleccionAlReordenar = false;
            this.dgvCreditos.MostrarWaitWindowOnDataSourceChanged = false;
            this.dgvCreditos.MultiSelect = false;
            this.dgvCreditos.Name = "dgvCreditos";
            this.dgvCreditos.PermiteOcultarColumnas = true;
            this.dgvCreditos.ResaltarCeldasEditables = false;
            this.dgvCreditos.RowHeadersVisible = false;
            this.dgvCreditos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCreditos.Size = new System.Drawing.Size(783, 261);
            this.dgvCreditos.StatusTripAMostrarAlerta = null;
            this.dgvCreditos.TabIndex = 0;
            this.dgvCreditos.TieneCheckMasivo = true;
            this.dgvCreditos.TieneChecks = true;
            this.dgvCreditos.TieneCopiarDatos = true;
            this.dgvCreditos.TieneExportarDatos = false;
            this.dgvCreditos.CambioChequeadosMultiplesItems += new System.EventHandler(this.dgvCreditos_CambioChequeadosMultiplesItems);
            this.dgvCreditos.CambioChequeadosUnItem += new System.EventHandler<System.Windows.Forms.DataGridViewCellEventArgs>(this.dgvCreditos_CambioChequeadosUnItem);
            this.dgvCreditos.SelectionChanged += new System.EventHandler(this.dgvCreditos_SelectionChanged);
            // 
            // colNombre
            // 
            this.colNombre.DataPropertyName = "ClienteNombre";
            this.colNombre.HeaderText = "Cliente";
            this.colNombre.Name = "colNombre";
            // 
            // colApellido
            // 
            this.colApellido.DataPropertyName = "Carga_Fecha";
            this.colApellido.HeaderText = "Fecha";
            this.colApellido.Name = "colApellido";
            // 
            // ColCarga_Cred
            // 
            this.ColCarga_Cred.DataPropertyName = "Carga_Cred";
            this.ColCarga_Cred.HeaderText = "Monto";
            this.ColCarga_Cred.Name = "ColCarga_Cred";
            // 
            // colTarjeta
            // 
            this.colTarjeta.DataPropertyName = "Tarjeta";
            this.colTarjeta.HeaderText = "Tarjeta";
            this.colTarjeta.Name = "colTarjeta";
            // 
            // colDetalle
            // 
            this.colDetalle.DataPropertyName = "Detalle";
            this.colDetalle.HeaderText = "Detalle";
            this.colDetalle.Name = "colDetalle";
            // 
            // colTipo_Pago
            // 
            this.colTipo_Pago.DataPropertyName = "Tipo_Pago";
            this.colTipo_Pago.HeaderText = "Tipo de Pago";
            this.colTipo_Pago.Name = "colTipo_Pago";
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.CadetBlue;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(0, 92);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(783, 19);
            this.label1.TabIndex = 16;
            this.label1.Text = "Listado";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dtpFechaHasta);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.dtpFechaDesde);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.cboTiposDePago);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.cboClientes);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.btnLimpiar);
            this.panel1.Controls.Add(this.btnBuscar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 19);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(783, 73);
            this.panel1.TabIndex = 17;
            // 
            // dtpFechaHasta
            // 
            this.dtpFechaHasta.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaHasta.Location = new System.Drawing.Point(443, 38);
            this.dtpFechaHasta.Name = "dtpFechaHasta";
            this.dtpFechaHasta.Size = new System.Drawing.Size(110, 20);
            this.dtpFechaHasta.TabIndex = 33;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(368, 44);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 13);
            this.label6.TabIndex = 32;
            this.label6.Text = "fecha hasta:";
            // 
            // dtpFechaDesde
            // 
            this.dtpFechaDesde.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaDesde.Location = new System.Drawing.Point(443, 14);
            this.dtpFechaDesde.Name = "dtpFechaDesde";
            this.dtpFechaDesde.Size = new System.Drawing.Size(110, 20);
            this.dtpFechaDesde.TabIndex = 31;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(368, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 13);
            this.label3.TabIndex = 30;
            this.label3.Text = "fecha desde:";
            // 
            // cboTiposDePago
            // 
            this.cboTiposDePago.FormattingEnabled = true;
            this.cboTiposDePago.Location = new System.Drawing.Point(88, 38);
            this.cboTiposDePago.Name = "cboTiposDePago";
            this.cboTiposDePago.Size = new System.Drawing.Size(248, 21);
            this.cboTiposDePago.TabIndex = 28;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 41);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 13);
            this.label5.TabIndex = 29;
            this.label5.Text = "Tipo de Pago:";
            // 
            // cboClientes
            // 
            this.cboClientes.FormattingEnabled = true;
            this.cboClientes.Location = new System.Drawing.Point(88, 11);
            this.cboClientes.Name = "cboClientes";
            this.cboClientes.Size = new System.Drawing.Size(248, 21);
            this.cboClientes.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Cliente:";
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLimpiar.BackColor = System.Drawing.SystemColors.Control;
            this.btnLimpiar.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnLimpiar.Location = new System.Drawing.Point(696, 45);
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
            this.btnBuscar.Location = new System.Drawing.Point(696, 14);
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
            this.Label4.Size = new System.Drawing.Size(783, 19);
            this.Label4.TabIndex = 14;
            this.Label4.Text = "Filtros";
            this.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panComandos
            // 
            this.panComandos.BackColor = System.Drawing.Color.LightSteelBlue;
            this.panComandos.Controls.Add(this.btnCancelar);
            this.panComandos.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panComandos.Location = new System.Drawing.Point(0, 400);
            this.panComandos.Name = "panComandos";
            this.panComandos.Size = new System.Drawing.Size(783, 32);
            this.panComandos.TabIndex = 15;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancelar.BackColor = System.Drawing.SystemColors.Control;
            this.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancelar.Location = new System.Drawing.Point(703, 4);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 25);
            this.btnCancelar.TabIndex = 1;
            this.btnCancelar.Text = "Cerrar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // paginador
            // 
            this.paginador.Location = new System.Drawing.Point(0, 0);
            this.paginador.Name = "paginador";
            this.paginador.Size = new System.Drawing.Size(780, 25);
            this.paginador.TabIndex = 2;
            this.paginador.SolicitarBusqueda += new System.EventHandler(this.paginador_SolicitarBusqueda);
            this.paginador.SeSeleccionaPaginaSiguiente += new System.EventHandler(this.paginador_SeSeleccionaPaginaSiguiente);
            this.paginador.SeSeleccionaUltimaPagina += new System.EventHandler(this.paginador_SeSeleccionaUltimaPagina);
            this.paginador.SeSeleccionaPaginaAnterior += new System.EventHandler(this.paginador_SeSeleccionaPaginaAnterior);
            this.paginador.SeSeleccionaPrimeraPagina += new System.EventHandler(this.paginador_SeSeleccionaPrimeraPagina);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.paginador);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 372);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(783, 28);
            this.panel3.TabIndex = 3;
            // 
            // FrmListadoDeCreditos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancelar;
            this.ClientSize = new System.Drawing.Size(783, 432);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Label4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panComandos);
            this.MinimumSize = new System.Drawing.Size(799, 471);
            this.Name = "FrmListadoDeCreditos";
            this.Text = "Listado De Créditos";
            this.Load += new System.EventHandler(this.FrmListadoDeCreditos_Load);
            this.Shown += new System.EventHandler(this.FrmListadoDeCreditos_Shown);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCreditos)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panComandos.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private Componentes.GrillaGestionDatos dgvCreditos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Label Label4;
        private System.Windows.Forms.Panel panComandos;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.ComboBox cboClientes;
        private Componentes.paginador paginador;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ComboBox cboTiposDePago;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtpFechaHasta;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dtpFechaDesde;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn colApellido;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColCarga_Cred;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTarjeta;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDetalle;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTipo_Pago;
    }
}