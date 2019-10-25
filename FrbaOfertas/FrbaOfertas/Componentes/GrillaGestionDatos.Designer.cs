namespace FrbaOfertas.Componentes
{
    partial class GrillaGestionDatos: System.Windows.Forms.DataGridView 
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.chkCheck = new System.Windows.Forms.CheckBox();
            //this._parentForm = new System.Windows.Forms.Form();
            this._btnMostrarTodas = new System.Windows.Forms.Button();
            this._btnAjustarAnchos = new System.Windows.Forms.Button();
            this._btnCerrar = new System.Windows.Forms.Button(); 
            this._lstSelectorDeColumnas = new System.Windows.Forms.CheckedListBox();
            this._mnuExportarDatos = new System.Windows.Forms.ToolStripMenuItem();
            this._mnuExportarDatosTodoConEncabezados = new System.Windows.Forms.ToolStripMenuItem();
            this._mnuExportarDatosSeleccionadoConEncabezados  = new System.Windows.Forms.ToolStripMenuItem() ;
            this._mnuCopiarDatosTodoSinEncabezado = new System.Windows.Forms.ToolStripMenuItem();
            this._mnuCopiarDatosTodoConEncabezados = new System.Windows.Forms.ToolStripMenuItem();
            this._mnuCopiarDatosSeleccionadoSinEncabezado = new  System.Windows.Forms.ToolStripMenuItem();
            this._mnuCopiarDatosSeleccionadoConEncabezados = new  System.Windows.Forms.ToolStripMenuItem();
            this._separatorExportarDatos  = new  System.Windows.Forms.ToolStripSeparator();
            this.pbAlertaColumnasOcultas = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbAlertaColumnasOcultas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // chkCheck
            // 
            this.chkCheck.AutoSize = true;
            this.chkCheck.Location = new System.Drawing.Point(5, 5);
            this.chkCheck.Name = "chkCheck";
            this.chkCheck.Size = new System.Drawing.Size(15, 14);
            this.chkCheck.TabIndex = 0;
            this.chkCheck.UseVisualStyleBackColor = true;
            this.chkCheck.Visible = false;
            this.chkCheck.CheckedChanged += chkCheck_CheckedChanged;
            this.KeyDown += DataGridView_Standard_KeyDown;
            //this._parentForm.Shown += _parentForm_Shown;
            this._btnMostrarTodas.Click += _btnMostrarTodas_Click;
            this._btnAjustarAnchos.Click += _btnAjustarAnchos_Click;
            this._mnuExportarDatosTodoConEncabezados.Click += _mnuExportarDatosTodoConEncabezados_Click;
            this._mnuCopiarDatosTodoSinEncabezado.Click += _mnuCopiarDatosTodoSinEncabezado_Click;
            _mnuCopiarDatosTodoConEncabezados.Click += _mnuCopiarDatosTodoConEncabezados_Click;
            _mnuCopiarDatosSeleccionadoSinEncabezado.Click += _mnuCopiarDatosSeleccionadoSinEncabezado_Click;
            _mnuCopiarDatosSeleccionadoConEncabezados.Click += _mnuCopiarDatosSeleccionadoConEncabezados_Click;
            this._mnuExportarDatosSeleccionadoConEncabezados.Click += _mnuExportarDatosSeleccionadoConEncabezados_Click;
            this.pbAlertaColumnasOcultas.Location = new System.Drawing.Point(0, 0);
            this.pbAlertaColumnasOcultas.Name = "pbAlertaColumnasOcultas";
            this.pbAlertaColumnasOcultas.Size = new System.Drawing.Size(16, 16);
            this.pbAlertaColumnasOcultas.TabIndex = 0;
            this.pbAlertaColumnasOcultas.TabStop = false;
            this.AllowUserToAddRows = false;
            this.AllowUserToDeleteRows = false;
            this.AllowUserToResizeRows = false;
            this.Controls.Add(this.chkCheck);
            this.RowHeadersVisible = false;
            ((System.ComponentModel.ISupportInitialize)(this.pbAlertaColumnasOcultas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        protected System.Windows.Forms.CheckBox chkCheck;
        //protected System.Windows.Forms.Form _parentForm;
        protected System.Windows.Forms.Button _btnMostrarTodas;
        protected System.Windows.Forms.Button _btnAjustarAnchos;
        protected System.Windows.Forms.Button _btnCerrar;
        protected System.Windows.Forms.CheckedListBox _lstSelectorDeColumnas;
        protected System.Windows.Forms.ToolStripMenuItem _mnuExportarDatos;
        protected System.Windows.Forms.ToolStripMenuItem _mnuExportarDatosTodoConEncabezados;
        protected System.Windows.Forms.ToolStripMenuItem _mnuExportarDatosSeleccionadoConEncabezados;
        protected System.Windows.Forms.ToolStripSeparator _separatorExportarDatos;
        protected System.Windows.Forms.ToolStripMenuItem _mnuCopiarDatosTodoSinEncabezado;
        protected System.Windows.Forms.ToolStripMenuItem _mnuCopiarDatosTodoConEncabezados;
        protected System.Windows.Forms.ToolStripMenuItem _mnuCopiarDatosSeleccionadoSinEncabezado;
        protected System.Windows.Forms.ToolStripMenuItem _mnuCopiarDatosSeleccionadoConEncabezados;

        internal System.Windows.Forms.PictureBox pbAlertaColumnasOcultas;

        #endregion


    }
}
