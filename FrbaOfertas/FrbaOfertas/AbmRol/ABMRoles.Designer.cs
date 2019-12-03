namespace FrbaOfertas.AbmRol
{
    partial class ABMRoles
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ABMRoles));
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvFuncionalidades = new FrbaOfertas.Componentes.GrillaGestionDatos();
            this.colFuncionalidades = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panComandos = new System.Windows.Forms.Panel();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFuncionalidades)).BeginInit();
            this.panComandos.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(69, 17);
            this.txtNombre.MaxLength = 250;
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(259, 20);
            this.txtNombre.TabIndex = 19;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 18;
            this.label2.Text = "Nombre:";
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.CadetBlue;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(0, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(353, 42);
            this.label1.TabIndex = 21;
            this.label1.Text = "Funcionalidades";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dgvFuncionalidades
            // 
            this.dgvFuncionalidades.AjustarColumnas = false;
            this.dgvFuncionalidades.AllowUserToAddRows = false;
            this.dgvFuncionalidades.AllowUserToDeleteRows = false;
            this.dgvFuncionalidades.AllowUserToResizeRows = false;
            this.dgvFuncionalidades.CheckOnClick = false;
            this.dgvFuncionalidades.ChecksDataPropertyName = null;
            this.dgvFuncionalidades.ChecksToolTipText = "";
            this.dgvFuncionalidades.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFuncionalidades.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colFuncionalidades});
            this.dgvFuncionalidades.ColumnsOcultas = ((System.Collections.Generic.List<string>)(resources.GetObject("dgvFuncionalidades.ColumnsOcultas")));
            this.dgvFuncionalidades.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvFuncionalidades.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvFuncionalidades.EventSyncInvoke = null;
            this.dgvFuncionalidades.Exportar_FinDeColumna = "\t";
            this.dgvFuncionalidades.Exportar_FinDeFila = "\r\n";
            this.dgvFuncionalidades.Exportar_FinDeLineaEnCelda = ",";
            this.dgvFuncionalidades.ItemsChequeados = ((System.Collections.IEnumerable)(resources.GetObject("dgvFuncionalidades.ItemsChequeados")));
            this.dgvFuncionalidades.Location = new System.Drawing.Point(0, 0);
            this.dgvFuncionalidades.MantenerSeleccionAlReordenar = false;
            this.dgvFuncionalidades.MostrarWaitWindowOnDataSourceChanged = false;
            this.dgvFuncionalidades.MultiSelect = false;
            this.dgvFuncionalidades.Name = "dgvFuncionalidades";
            this.dgvFuncionalidades.PermiteOcultarColumnas = true;
            this.dgvFuncionalidades.ResaltarCeldasEditables = false;
            this.dgvFuncionalidades.RowHeadersVisible = false;
            this.dgvFuncionalidades.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvFuncionalidades.Size = new System.Drawing.Size(353, 177);
            this.dgvFuncionalidades.StatusTripAMostrarAlerta = null;
            this.dgvFuncionalidades.TabIndex = 17;
            this.dgvFuncionalidades.TieneCheckMasivo = true;
            this.dgvFuncionalidades.TieneChecks = true;
            this.dgvFuncionalidades.TieneCopiarDatos = true;
            this.dgvFuncionalidades.TieneExportarDatos = false;
            this.dgvFuncionalidades.CambioChequeadosMultiplesItems += new System.EventHandler(this.dgvFuncionalidades_CambioChequeadosMultiplesItems);
            this.dgvFuncionalidades.CambioChequeadosUnItem += new System.EventHandler<System.Windows.Forms.DataGridViewCellEventArgs>(this.dgvFuncionalidades_CambioChequeadosUnItem);
            this.dgvFuncionalidades.SelectionChanged += new System.EventHandler(this.dgvFuncionalidades_SelectionChanged);
            // 
            // colFuncionalidades
            // 
            this.colFuncionalidades.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colFuncionalidades.DataPropertyName = "Detalle_func";
            this.colFuncionalidades.HeaderText = "Funcionalidades";
            this.colFuncionalidades.Name = "colFuncionalidades";
            // 
            // panComandos
            // 
            this.panComandos.BackColor = System.Drawing.Color.LightSteelBlue;
            this.panComandos.Controls.Add(this.btnAceptar);
            this.panComandos.Controls.Add(this.btnCancelar);
            this.panComandos.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panComandos.Location = new System.Drawing.Point(0, 295);
            this.panComandos.Name = "panComandos";
            this.panComandos.Size = new System.Drawing.Size(353, 32);
            this.panComandos.TabIndex = 20;
            // 
            // btnAceptar
            // 
            this.btnAceptar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAceptar.BackColor = System.Drawing.SystemColors.Control;
            this.btnAceptar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnAceptar.Location = new System.Drawing.Point(192, 4);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(75, 25);
            this.btnAceptar.TabIndex = 2;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = false;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancelar.BackColor = System.Drawing.SystemColors.Control;
            this.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancelar.Location = new System.Drawing.Point(273, 4);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 25);
            this.btnCancelar.TabIndex = 1;
            this.btnCancelar.Text = "Cerrar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtNombre);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(353, 76);
            this.panel1.TabIndex = 22;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dgvFuncionalidades);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 118);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(353, 177);
            this.panel2.TabIndex = 23;
            // 
            // ABMRoles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(353, 327);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panComandos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ABMRoles";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "ABMRoles";
            this.Load += new System.EventHandler(this.ABMRoles_Load);
            this.Shown += new System.EventHandler(this.ABMRoles_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFuncionalidades)).EndInit();
            this.panComandos.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Componentes.GrillaGestionDatos dgvFuncionalidades;
        private System.Windows.Forms.Panel panComandos;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFuncionalidades;
    }
}