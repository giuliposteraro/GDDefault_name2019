using System.Windows.Forms;
namespace FrbaOfertas.AbmCliente
{
    partial class FrmCliente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCliente));
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtMail = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtDNI = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.Label4 = new System.Windows.Forms.Label();
            this.panComandos = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.btnActivar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dgvClientes = new FrbaOfertas.Componentes.GrillaGestionDatos();
            this.colNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colApellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDNI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTelefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFechaNac = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMonto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colHabilitado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.mniModificar = new System.Windows.Forms.ToolStripMenuItem();
            this.mniEliminar = new System.Windows.Forms.ToolStripMenuItem();
            this.btnAsociarCta = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panComandos.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).BeginInit();
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
            this.label1.Size = new System.Drawing.Size(681, 19);
            this.label1.TabIndex = 11;
            this.label1.Text = "Listado";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtMail);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.txtDNI);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.txtApellido);
            this.panel1.Controls.Add(this.txtNombre);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.btnLimpiar);
            this.panel1.Controls.Add(this.btnBuscar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 19);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(681, 73);
            this.panel1.TabIndex = 12;
            // 
            // txtMail
            // 
            this.txtMail.Location = new System.Drawing.Point(308, 37);
            this.txtMail.Name = "txtMail";
            this.txtMail.Size = new System.Drawing.Size(174, 20);
            this.txtMail.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(264, 40);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "E-mail:";
            // 
            // txtDNI
            // 
            this.txtDNI.Location = new System.Drawing.Point(74, 37);
            this.txtDNI.Name = "txtDNI";
            this.txtDNI.Size = new System.Drawing.Size(174, 20);
            this.txtDNI.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(39, 40);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "DNI:";
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(308, 11);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(174, 20);
            this.txtApellido.TabIndex = 7;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(74, 11);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(174, 20);
            this.txtNombre.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(255, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Apellido:";
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
            this.btnLimpiar.Location = new System.Drawing.Point(594, 45);
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
            this.btnBuscar.Location = new System.Drawing.Point(594, 14);
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
            this.Label4.Size = new System.Drawing.Size(681, 19);
            this.Label4.TabIndex = 9;
            this.Label4.Text = "Filtros";
            this.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panComandos
            // 
            this.panComandos.BackColor = System.Drawing.Color.LightSteelBlue;
            this.panComandos.Controls.Add(this.btnAsociarCta);
            this.panComandos.Controls.Add(this.button1);
            this.panComandos.Controls.Add(this.btnActivar);
            this.panComandos.Controls.Add(this.btnEliminar);
            this.panComandos.Controls.Add(this.btnModificar);
            this.panComandos.Controls.Add(this.btnCancelar);
            this.panComandos.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panComandos.Location = new System.Drawing.Point(0, 367);
            this.panComandos.Name = "panComandos";
            this.panComandos.Size = new System.Drawing.Size(681, 32);
            this.panComandos.TabIndex = 10;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(15, 6);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Agregar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnActivar
            // 
            this.btnActivar.Location = new System.Drawing.Point(258, 6);
            this.btnActivar.Name = "btnActivar";
            this.btnActivar.Size = new System.Drawing.Size(75, 23);
            this.btnActivar.TabIndex = 5;
            this.btnActivar.Text = "Activar";
            this.btnActivar.UseVisualStyleBackColor = true;
            this.btnActivar.Click += new System.EventHandler(this.btnActivar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.SystemColors.Control;
            this.btnEliminar.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnEliminar.Location = new System.Drawing.Point(177, 5);
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
            this.btnModificar.Location = new System.Drawing.Point(96, 5);
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
            this.btnCancelar.Location = new System.Drawing.Point(601, 4);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 25);
            this.btnCancelar.TabIndex = 1;
            this.btnCancelar.Text = "Cerrar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dgvClientes);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 111);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(681, 256);
            this.panel2.TabIndex = 13;
            // 
            // dgvClientes
            // 
            this.dgvClientes.AjustarColumnas = false;
            this.dgvClientes.AllowUserToAddRows = false;
            this.dgvClientes.AllowUserToDeleteRows = false;
            this.dgvClientes.AllowUserToResizeRows = false;
            this.dgvClientes.CheckOnClick = false;
            this.dgvClientes.ChecksDataPropertyName = null;
            this.dgvClientes.ChecksToolTipText = "";
            this.dgvClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClientes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colNombre,
            this.colApellido,
            this.colDNI,
            this.colMail,
            this.colTelefono,
            this.colFechaNac,
            this.colMonto,
            this.colHabilitado});
            this.dgvClientes.ColumnsOcultas = ((System.Collections.Generic.List<string>)(resources.GetObject("dgvClientes.ColumnsOcultas")));
            this.dgvClientes.ContextMenuStrip = this.contextMenuStrip1;
            this.dgvClientes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvClientes.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvClientes.EventSyncInvoke = null;
            this.dgvClientes.Exportar_FinDeColumna = "\t";
            this.dgvClientes.Exportar_FinDeFila = "\r\n";
            this.dgvClientes.Exportar_FinDeLineaEnCelda = ",";
            this.dgvClientes.ItemsChequeados = ((System.Collections.IEnumerable)(resources.GetObject("dgvClientes.ItemsChequeados")));
            this.dgvClientes.Location = new System.Drawing.Point(0, 0);
            this.dgvClientes.MantenerSeleccionAlReordenar = false;
            this.dgvClientes.MostrarWaitWindowOnDataSourceChanged = false;
            this.dgvClientes.MultiSelect = false;
            this.dgvClientes.Name = "dgvClientes";
            this.dgvClientes.PermiteOcultarColumnas = true;
            this.dgvClientes.ResaltarCeldasEditables = false;
            this.dgvClientes.RowHeadersVisible = false;
            this.dgvClientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvClientes.Size = new System.Drawing.Size(681, 256);
            this.dgvClientes.StatusTripAMostrarAlerta = null;
            this.dgvClientes.TabIndex = 0;
            this.dgvClientes.TieneCheckMasivo = false;
            this.dgvClientes.TieneCopiarDatos = true;
            this.dgvClientes.TieneExportarDatos = false;
            this.dgvClientes.CambioChequeadosMultiplesItems += new System.EventHandler(this.dgvClientes_CambioChequeadosMultiplesItems);
            this.dgvClientes.CambioChequeadosUnItem += new System.EventHandler<System.Windows.Forms.DataGridViewCellEventArgs>(this.dgvClientes_CambioChequeadosUnItem);
            this.dgvClientes.SelectionChanged += new System.EventHandler(this.dgvClientes_SelectionChanged);
            // 
            // colNombre
            // 
            this.colNombre.DataPropertyName = "Nombre_Clie";
            this.colNombre.HeaderText = "Nombre";
            this.colNombre.Name = "colNombre";
            // 
            // colApellido
            // 
            this.colApellido.DataPropertyName = "Apellido_Clie";
            this.colApellido.HeaderText = "Apellido";
            this.colApellido.Name = "colApellido";
            // 
            // colDNI
            // 
            this.colDNI.DataPropertyName = "DNI_Clie";
            this.colDNI.HeaderText = "DNI";
            this.colDNI.Name = "colDNI";
            // 
            // colMail
            // 
            this.colMail.DataPropertyName = "Mail_Clie";
            this.colMail.HeaderText = "Mail";
            this.colMail.Name = "colMail";
            // 
            // colTelefono
            // 
            this.colTelefono.DataPropertyName = "Tel_Clie";
            this.colTelefono.HeaderText = "Teléfono";
            this.colTelefono.Name = "colTelefono";
            // 
            // colFechaNac
            // 
            this.colFechaNac.DataPropertyName = "Fecha_Nac_Clie";
            this.colFechaNac.HeaderText = "Fecha Nacimiento";
            this.colFechaNac.Name = "colFechaNac";
            // 
            // colMonto
            // 
            this.colMonto.DataPropertyName = "Monto_Total_cred_Clie";
            this.colMonto.HeaderText = "Monto Credito";
            this.colMonto.Name = "colMonto";
            // 
            // colHabilitado
            // 
            this.colHabilitado.DataPropertyName = "HabilitadoTexto";
            this.colHabilitado.HeaderText = "Habilitado";
            this.colHabilitado.Name = "colHabilitado";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mniModificar,
            this.mniEliminar});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(126, 48);
            // 
            // mniModificar
            // 
            this.mniModificar.Name = "mniModificar";
            this.mniModificar.Size = new System.Drawing.Size(125, 22);
            this.mniModificar.Text = "Modificar";
            this.mniModificar.Click += new System.EventHandler(this.mniModificar_Click);
            // 
            // mniEliminar
            // 
            this.mniEliminar.Name = "mniEliminar";
            this.mniEliminar.Size = new System.Drawing.Size(125, 22);
            this.mniEliminar.Text = "Eliminar";
            this.mniEliminar.Click += new System.EventHandler(this.mniEliminar_Click);
            // 
            // btnAsociarCta
            // 
            this.btnAsociarCta.Location = new System.Drawing.Point(340, 7);
            this.btnAsociarCta.Name = "btnAsociarCta";
            this.btnAsociarCta.Size = new System.Drawing.Size(98, 23);
            this.btnAsociarCta.TabIndex = 7;
            this.btnAsociarCta.Text = "Asociar a Usuario";
            this.btnAsociarCta.UseVisualStyleBackColor = true;
            this.btnAsociarCta.Click += new System.EventHandler(this.btnAsociarCta_Click);
            // 
            // FrmCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(681, 399);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Label4);
            this.Controls.Add(this.panComandos);
            this.Name = "FrmCliente";
            this.Text = "Listado de clientes";
            this.Load += new System.EventHandler(this.FrmCliente_Load);
            this.Shown += new System.EventHandler(this.FrmCliente_Shown);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panComandos.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Label Label4;
        private System.Windows.Forms.Panel panComandos;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Panel panel2;
        private Componentes.GrillaGestionDatos dgvClientes;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mniModificar;
        private System.Windows.Forms.ToolStripMenuItem mniEliminar;
        private TextBox txtMail;
        private Label label6;
        private TextBox txtDNI;
        private Label label5;
        private DataGridViewTextBoxColumn colNombre;
        private DataGridViewTextBoxColumn colApellido;
        private DataGridViewTextBoxColumn colDNI;
        private DataGridViewTextBoxColumn colMail;
        private DataGridViewTextBoxColumn colTelefono;
        private DataGridViewTextBoxColumn colFechaNac;
        private DataGridViewTextBoxColumn colMonto;
        private DataGridViewTextBoxColumn colHabilitado;
        private Button btnActivar;
        private Button button1;
        private Button btnAsociarCta;
    }
}