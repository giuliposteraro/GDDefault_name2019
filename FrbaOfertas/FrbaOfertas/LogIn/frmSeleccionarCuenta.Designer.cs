namespace FrbaOfertas.LogIn
{
    partial class frmSeleccionarCuenta
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSeleccionarCuenta));
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.chkActivo = new System.Windows.Forms.CheckBox();
            this.txtUsuario_Cuenta = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.Label4 = new System.Windows.Forms.Label();
            this.panComandos = new System.Windows.Forms.Panel();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dgvCuentas = new FrbaOfertas.Componentes.GrillaGestionDatos();
            this.colNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCantidadIngresos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Estado_Cuenta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.panComandos.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCuentas)).BeginInit();
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
            this.label1.Size = new System.Drawing.Size(589, 19);
            this.label1.TabIndex = 20;
            this.label1.Text = "Listado";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.chkActivo);
            this.panel1.Controls.Add(this.txtUsuario_Cuenta);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.btnBuscar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 19);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(589, 73);
            this.panel1.TabIndex = 21;
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
            // btnBuscar
            // 
            this.btnBuscar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBuscar.BackColor = System.Drawing.SystemColors.Control;
            this.btnBuscar.Location = new System.Drawing.Point(502, 14);
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
            this.Label4.Size = new System.Drawing.Size(589, 19);
            this.Label4.TabIndex = 18;
            this.Label4.Text = "Filtros";
            this.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panComandos
            // 
            this.panComandos.BackColor = System.Drawing.Color.LightSteelBlue;
            this.panComandos.Controls.Add(this.btnAgregar);
            this.panComandos.Controls.Add(this.btnCancelar);
            this.panComandos.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panComandos.Location = new System.Drawing.Point(0, 229);
            this.panComandos.Name = "panComandos";
            this.panComandos.Size = new System.Drawing.Size(589, 32);
            this.panComandos.TabIndex = 19;
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.SystemColors.Control;
            this.btnAgregar.Location = new System.Drawing.Point(5, 4);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 25);
            this.btnAgregar.TabIndex = 2;
            this.btnAgregar.Text = "Seleccionar";
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancelar.BackColor = System.Drawing.SystemColors.Control;
            this.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancelar.Location = new System.Drawing.Point(509, 4);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 25);
            this.btnCancelar.TabIndex = 1;
            this.btnCancelar.Text = "Cerrar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dgvCuentas);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 111);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(589, 118);
            this.panel2.TabIndex = 22;
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
            this.dgvCuentas.Size = new System.Drawing.Size(589, 118);
            this.dgvCuentas.StatusTripAMostrarAlerta = null;
            this.dgvCuentas.TabIndex = 14;
            this.dgvCuentas.TieneCheckMasivo = false;
            this.dgvCuentas.TieneCopiarDatos = true;
            this.dgvCuentas.TieneExportarDatos = false;
            this.dgvCuentas.CambioChequeadosMultiplesItems += new System.EventHandler(this.dgvCuentas_CambioChequeadosMultiplesItems);
            this.dgvCuentas.CargarMenuContextual += new System.EventHandler(this.dgvCuentas_CargarMenuContextual);
            this.dgvCuentas.CambioChequeadosUnItem += new System.EventHandler<System.Windows.Forms.DataGridViewCellEventArgs>(this.dgvCuentas_CambioChequeadosUnItem);
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
            // frmSeleccionarCuenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(589, 261);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Label4);
            this.Controls.Add(this.panComandos);
            this.Name = "frmSeleccionarCuenta";
            this.Text = "Seleccionar Usuario";
            this.Load += new System.EventHandler(this.frmSeleccionarCuenta_Load);
            this.Shown += new System.EventHandler(this.frmSeleccionarCuenta_Shown);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panComandos.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCuentas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.CheckBox chkActivo;
        private System.Windows.Forms.TextBox txtUsuario_Cuenta;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Label Label4;
        private System.Windows.Forms.Panel panComandos;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Panel panel2;
        private Componentes.GrillaGestionDatos dgvCuentas;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCantidadIngresos;
        private System.Windows.Forms.DataGridViewTextBoxColumn Estado_Cuenta;
    }
}