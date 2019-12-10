namespace FrbaOfertas.AbmProveedor
{
    partial class ListaProveedores
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ListaProveedores));
            this.panel2 = new System.Windows.Forms.Panel();
            this.dgvProveedores = new FrbaOfertas.Componentes.GrillaGestionDatos();
            this.ColumnRazonSocial = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnNombreContacto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnCuit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnRubro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnDireccion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnCp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnTelefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnMail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colHabilitado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.textMail = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textCuit = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textNombreContacto = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtRazonSocial = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.Label4 = new System.Windows.Forms.Label();
            this.panComandos = new System.Windows.Forms.Panel();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnActivar = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProveedores)).BeginInit();
            this.panel1.SuspendLayout();
            this.panComandos.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dgvProveedores);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 111);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(804, 174);
            this.panel2.TabIndex = 23;
            // 
            // dgvProveedores
            // 
            this.dgvProveedores.AjustarColumnas = false;
            this.dgvProveedores.AllowUserToAddRows = false;
            this.dgvProveedores.AllowUserToDeleteRows = false;
            this.dgvProveedores.AllowUserToResizeRows = false;
            this.dgvProveedores.CheckOnClick = false;
            this.dgvProveedores.ChecksDataPropertyName = null;
            this.dgvProveedores.ChecksToolTipText = "";
            this.dgvProveedores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProveedores.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnRazonSocial,
            this.ColumnNombreContacto,
            this.ColumnCuit,
            this.ColumnRubro,
            this.ColumnDireccion,
            this.ColumnCp,
            this.ColumnTelefono,
            this.ColumnMail,
            this.colHabilitado});
            this.dgvProveedores.ColumnsOcultas = ((System.Collections.Generic.List<string>)(resources.GetObject("dgvProveedores.ColumnsOcultas")));
            this.dgvProveedores.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvProveedores.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvProveedores.EventSyncInvoke = this.btnAgregar;
            this.dgvProveedores.Exportar_FinDeColumna = "\t";
            this.dgvProveedores.Exportar_FinDeFila = "\r\n";
            this.dgvProveedores.Exportar_FinDeLineaEnCelda = ",";
            this.dgvProveedores.ItemsChequeados = ((System.Collections.IEnumerable)(resources.GetObject("dgvProveedores.ItemsChequeados")));
            this.dgvProveedores.Location = new System.Drawing.Point(0, 0);
            this.dgvProveedores.MantenerSeleccionAlReordenar = false;
            this.dgvProveedores.MostrarWaitWindowOnDataSourceChanged = false;
            this.dgvProveedores.MultiSelect = false;
            this.dgvProveedores.Name = "dgvProveedores";
            this.dgvProveedores.PermiteOcultarColumnas = true;
            this.dgvProveedores.ResaltarCeldasEditables = false;
            this.dgvProveedores.RowHeadersVisible = false;
            this.dgvProveedores.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProveedores.Size = new System.Drawing.Size(804, 174);
            this.dgvProveedores.StatusTripAMostrarAlerta = null;
            this.dgvProveedores.TabIndex = 0;
            this.dgvProveedores.TieneCheckMasivo = false;
            this.dgvProveedores.TieneCopiarDatos = true;
            this.dgvProveedores.TieneExportarDatos = false;
            this.dgvProveedores.CambioChequeadosMultiplesItems += new System.EventHandler(this.dgvProveedores_CambioChequeadosMultiplesItems);
            this.dgvProveedores.CargarMenuContextual += new System.EventHandler(this.dgvProveedores_CargarMenuContextual);
            this.dgvProveedores.CambioChequeadosUnItem += new System.EventHandler<System.Windows.Forms.DataGridViewCellEventArgs>(this.dgvProveedores_CambioChequeadosUnItem);
            this.dgvProveedores.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvRoles_CellContentClick);
            // 
            // ColumnRazonSocial
            // 
            this.ColumnRazonSocial.DataPropertyName = "Razon_Social_Prov";
            this.ColumnRazonSocial.HeaderText = "Razon Social";
            this.ColumnRazonSocial.Name = "ColumnRazonSocial";
            // 
            // ColumnNombreContacto
            // 
            this.ColumnNombreContacto.DataPropertyName = "Nom_Contacto_Prov";
            this.ColumnNombreContacto.HeaderText = "Nombre Contacto";
            this.ColumnNombreContacto.Name = "ColumnNombreContacto";
            // 
            // ColumnCuit
            // 
            this.ColumnCuit.DataPropertyName = "Cuit_Prov";
            this.ColumnCuit.HeaderText = "CUIT";
            this.ColumnCuit.Name = "ColumnCuit";
            // 
            // ColumnRubro
            // 
            this.ColumnRubro.DataPropertyName = "Rubro_Prov";
            this.ColumnRubro.HeaderText = "Rubro";
            this.ColumnRubro.Name = "ColumnRubro";
            // 
            // ColumnDireccion
            // 
            this.ColumnDireccion.DataPropertyName = "DireccionTexto";
            this.ColumnDireccion.HeaderText = "Direccion";
            this.ColumnDireccion.Name = "ColumnDireccion";
            // 
            // ColumnCp
            // 
            this.ColumnCp.DataPropertyName = "CodigoPostalTexto";
            this.ColumnCp.HeaderText = "Codigo Postal";
            this.ColumnCp.Name = "ColumnCp";
            // 
            // ColumnTelefono
            // 
            this.ColumnTelefono.DataPropertyName = "Telefono_Prov";
            this.ColumnTelefono.HeaderText = "Telefono";
            this.ColumnTelefono.Name = "ColumnTelefono";
            // 
            // ColumnMail
            // 
            this.ColumnMail.DataPropertyName = "Mail_Proveedor";
            this.ColumnMail.HeaderText = "Mail";
            this.ColumnMail.Name = "ColumnMail";
            // 
            // colHabilitado
            // 
            this.colHabilitado.DataPropertyName = "HabilitadoTexto";
            this.colHabilitado.HeaderText = "Habilitado";
            this.colHabilitado.Name = "colHabilitado";
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
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.CadetBlue;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(0, 92);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(804, 19);
            this.label1.TabIndex = 21;
            this.label1.Text = "Listado";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.textMail);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.textCuit);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.textNombreContacto);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txtRazonSocial);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.btnLimpiar);
            this.panel1.Controls.Add(this.btnBuscar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 19);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(804, 73);
            this.panel1.TabIndex = 22;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // textMail
            // 
            this.textMail.Location = new System.Drawing.Point(305, 40);
            this.textMail.Name = "textMail";
            this.textMail.Size = new System.Drawing.Size(91, 20);
            this.textMail.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(206, 43);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Mail:";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // textCuit
            // 
            this.textCuit.Location = new System.Drawing.Point(100, 40);
            this.textCuit.Name = "textCuit";
            this.textCuit.Size = new System.Drawing.Size(91, 20);
            this.textCuit.TabIndex = 10;
            this.textCuit.TextChanged += new System.EventHandler(this.textCuit_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(21, 43);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "CUIT:";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // textNombreContacto
            // 
            this.textNombreContacto.Location = new System.Drawing.Point(305, 11);
            this.textNombreContacto.Name = "textNombreContacto";
            this.textNombreContacto.Size = new System.Drawing.Size(91, 20);
            this.textNombreContacto.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(206, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Nombre Contacto:";
            // 
            // txtRazonSocial
            // 
            this.txtRazonSocial.Location = new System.Drawing.Point(100, 11);
            this.txtRazonSocial.Name = "txtRazonSocial";
            this.txtRazonSocial.Size = new System.Drawing.Size(91, 20);
            this.txtRazonSocial.TabIndex = 6;
            this.txtRazonSocial.TextChanged += new System.EventHandler(this.txtNombre_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Razon Social:";
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLimpiar.BackColor = System.Drawing.SystemColors.Control;
            this.btnLimpiar.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnLimpiar.Location = new System.Drawing.Point(717, 37);
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
            this.btnBuscar.Location = new System.Drawing.Point(717, 6);
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
            this.Label4.Size = new System.Drawing.Size(804, 19);
            this.Label4.TabIndex = 19;
            this.Label4.Text = "Filtros";
            this.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Label4.Click += new System.EventHandler(this.Label4_Click);
            // 
            // panComandos
            // 
            this.panComandos.BackColor = System.Drawing.Color.LightSteelBlue;
            this.panComandos.Controls.Add(this.btnActivar);
            this.panComandos.Controls.Add(this.btnEliminar);
            this.panComandos.Controls.Add(this.btnModificar);
            this.panComandos.Controls.Add(this.btnAgregar);
            this.panComandos.Controls.Add(this.btnCancelar);
            this.panComandos.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panComandos.Location = new System.Drawing.Point(0, 285);
            this.panComandos.Name = "panComandos";
            this.panComandos.Size = new System.Drawing.Size(804, 32);
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
            // btnCancelar
            // 
            this.btnCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancelar.BackColor = System.Drawing.SystemColors.Control;
            this.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancelar.Location = new System.Drawing.Point(724, 4);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 25);
            this.btnCancelar.TabIndex = 1;
            this.btnCancelar.Text = "Cerrar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnActivar
            // 
            this.btnActivar.Location = new System.Drawing.Point(249, 5);
            this.btnActivar.Name = "btnActivar";
            this.btnActivar.Size = new System.Drawing.Size(75, 23);
            this.btnActivar.TabIndex = 5;
            this.btnActivar.Text = "Activar";
            this.btnActivar.UseVisualStyleBackColor = true;
            this.btnActivar.Click += new System.EventHandler(this.btnActivar_Click);
            // 
            // ListaProveedores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(804, 317);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Label4);
            this.Controls.Add(this.panComandos);
            this.Name = "ListaProveedores";
            this.Text = "FormProveedor";
            this.Load += new System.EventHandler(this.ListaProveedores_Load);
            this.Shown += new System.EventHandler(this.ListaProveedores_Shown);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProveedores)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panComandos.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private Componentes.GrillaGestionDatos dgvProveedores;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtRazonSocial;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Label Label4;
        private System.Windows.Forms.Panel panComandos;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.TextBox textNombreContacto;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textMail;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textCuit;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnRazonSocial;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnNombreContacto;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnCuit;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnRubro;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnDireccion;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnCp;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnTelefono;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnMail;
        private System.Windows.Forms.DataGridViewTextBoxColumn colHabilitado;
        private System.Windows.Forms.Button btnActivar;
    }
}