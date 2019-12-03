namespace FrbaOfertas.CrearOferta
{
    partial class FrmAltaOfertas
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
            this.panComandos = new System.Windows.Forms.Panel();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.cboProveedor = new System.Windows.Forms.ComboBox();
            this.dtpFechaPublicacion = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.gtpFechaVencimiento = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.nmPrecioOferta = new System.Windows.Forms.NumericUpDown();
            this.mnPrecioLista = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.nmDisponible = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.mnMaximo = new System.Windows.Forms.NumericUpDown();
            this.label10 = new System.Windows.Forms.Label();
            this.panComandos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmPrecioOferta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mnPrecioLista)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmDisponible)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mnMaximo)).BeginInit();
            this.SuspendLayout();
            // 
            // panComandos
            // 
            this.panComandos.BackColor = System.Drawing.Color.LightSteelBlue;
            this.panComandos.Controls.Add(this.btnAgregar);
            this.panComandos.Controls.Add(this.btnCancelar);
            this.panComandos.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panComandos.Location = new System.Drawing.Point(0, 410);
            this.panComandos.Name = "panComandos";
            this.panComandos.Size = new System.Drawing.Size(393, 32);
            this.panComandos.TabIndex = 31;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAgregar.BackColor = System.Drawing.SystemColors.Control;
            this.btnAgregar.Location = new System.Drawing.Point(232, 4);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 25);
            this.btnAgregar.TabIndex = 2;
            this.btnAgregar.Text = "Guardar";
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancelar.BackColor = System.Drawing.SystemColors.Control;
            this.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancelar.Location = new System.Drawing.Point(313, 4);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 25);
            this.btnCancelar.TabIndex = 1;
            this.btnCancelar.Text = "Cerrar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.CadetBlue;
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(393, 19);
            this.label2.TabIndex = 30;
            this.label2.Text = "Datos de la oferta";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cboProveedor
            // 
            this.cboProveedor.Enabled = false;
            this.cboProveedor.FormattingEnabled = true;
            this.cboProveedor.Location = new System.Drawing.Point(116, 42);
            this.cboProveedor.Name = "cboProveedor";
            this.cboProveedor.Size = new System.Drawing.Size(213, 21);
            this.cboProveedor.TabIndex = 37;
            // 
            // dtpFechaPublicacion
            // 
            this.dtpFechaPublicacion.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaPublicacion.Location = new System.Drawing.Point(116, 95);
            this.dtpFechaPublicacion.Name = "dtpFechaPublicacion";
            this.dtpFechaPublicacion.Size = new System.Drawing.Size(143, 20);
            this.dtpFechaPublicacion.TabIndex = 36;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 101);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 13);
            this.label5.TabIndex = 35;
            this.label5.Text = "Fecha Publicación:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(51, 45);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 13);
            this.label3.TabIndex = 34;
            this.label3.Text = "Proveedor:";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(116, 69);
            this.txtCodigo.MaxLength = 20;
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(213, 20);
            this.txtCodigo.TabIndex = 33;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(67, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 32;
            this.label1.Text = "Código:";
            // 
            // gtpFechaVencimiento
            // 
            this.gtpFechaVencimiento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.gtpFechaVencimiento.Location = new System.Drawing.Point(116, 122);
            this.gtpFechaVencimiento.Name = "gtpFechaVencimiento";
            this.gtpFechaVencimiento.Size = new System.Drawing.Size(143, 20);
            this.gtpFechaVencimiento.TabIndex = 39;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 128);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 13);
            this.label4.TabIndex = 38;
            this.label4.Text = "Fecha Vencimiento:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(47, 151);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 13);
            this.label6.TabIndex = 40;
            this.label6.Text = "Descripción:";
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(116, 148);
            this.txtDescripcion.MaxLength = 500;
            this.txtDescripcion.Multiline = true;
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtDescripcion.Size = new System.Drawing.Size(213, 118);
            this.txtDescripcion.TabIndex = 41;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(41, 275);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(72, 13);
            this.label7.TabIndex = 42;
            this.label7.Text = "Precio Oferta:";
            // 
            // nmPrecioOferta
            // 
            this.nmPrecioOferta.Location = new System.Drawing.Point(116, 273);
            this.nmPrecioOferta.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.nmPrecioOferta.Name = "nmPrecioOferta";
            this.nmPrecioOferta.Size = new System.Drawing.Size(120, 20);
            this.nmPrecioOferta.TabIndex = 44;
            // 
            // mnPrecioLista
            // 
            this.mnPrecioLista.Location = new System.Drawing.Point(116, 299);
            this.mnPrecioLista.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.mnPrecioLista.Name = "mnPrecioLista";
            this.mnPrecioLista.Size = new System.Drawing.Size(120, 20);
            this.mnPrecioLista.TabIndex = 46;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(48, 301);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 13);
            this.label8.TabIndex = 45;
            this.label8.Text = "Precio Lista:";
            // 
            // nmDisponible
            // 
            this.nmDisponible.Location = new System.Drawing.Point(116, 325);
            this.nmDisponible.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.nmDisponible.Name = "nmDisponible";
            this.nmDisponible.Size = new System.Drawing.Size(120, 20);
            this.nmDisponible.TabIndex = 48;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 327);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(104, 13);
            this.label9.TabIndex = 47;
            this.label9.Text = "Cantidad Disponible:";
            // 
            // mnMaximo
            // 
            this.mnMaximo.Location = new System.Drawing.Point(116, 351);
            this.mnMaximo.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.mnMaximo.Name = "mnMaximo";
            this.mnMaximo.Size = new System.Drawing.Size(120, 20);
            this.mnMaximo.TabIndex = 50;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(12, 353);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(103, 13);
            this.label10.TabIndex = 49;
            this.label10.Text = "Máximo por Compra:";
            // 
            // FrmAltaOfertas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancelar;
            this.ClientSize = new System.Drawing.Size(393, 442);
            this.Controls.Add(this.mnMaximo);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.nmDisponible);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.mnPrecioLista);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.nmPrecioOferta);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.gtpFechaVencimiento);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cboProveedor);
            this.Controls.Add(this.dtpFechaPublicacion);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panComandos);
            this.Controls.Add(this.label2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(409, 481);
            this.Name = "FrmAltaOfertas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Alta De Ofertas";
            this.panComandos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nmPrecioOferta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mnPrecioLista)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmDisponible)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mnMaximo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panComandos;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cboProveedor;
        private System.Windows.Forms.DateTimePicker dtpFechaPublicacion;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker gtpFechaVencimiento;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown nmPrecioOferta;
        private System.Windows.Forms.NumericUpDown mnPrecioLista;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown nmDisponible;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.NumericUpDown mnMaximo;
        private System.Windows.Forms.Label label10;
    }
}