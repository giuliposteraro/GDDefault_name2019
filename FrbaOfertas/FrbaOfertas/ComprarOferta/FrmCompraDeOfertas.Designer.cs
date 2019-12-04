namespace FrbaOfertas.ComprarOferta
{
    partial class FrmCompraDeOfertas
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNombreCliente = new System.Windows.Forms.TextBox();
            this.btnComprar = new System.Windows.Forms.Button();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.txtOferta = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtCredito = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.lblAlertaUsuario = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtStock = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtMaximo = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.nmCantidad = new System.Windows.Forms.NumericUpDown();
            this.txtLista = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtPoferta = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmCantidad)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 183);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Fecha de compra:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Oferta:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 152);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Código de oferta:";
            // 
            // txtNumero
            // 
            this.txtNumero.Enabled = false;
            this.txtNumero.Location = new System.Drawing.Point(110, 149);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(130, 20);
            this.txtNumero.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 34);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Cliente:";
            // 
            // txtNombreCliente
            // 
            this.txtNombreCliente.Enabled = false;
            this.txtNombreCliente.Location = new System.Drawing.Point(65, 31);
            this.txtNombreCliente.Name = "txtNombreCliente";
            this.txtNombreCliente.Size = new System.Drawing.Size(235, 20);
            this.txtNombreCliente.TabIndex = 7;
            // 
            // btnComprar
            // 
            this.btnComprar.Location = new System.Drawing.Point(404, 257);
            this.btnComprar.Name = "btnComprar";
            this.btnComprar.Size = new System.Drawing.Size(75, 23);
            this.btnComprar.TabIndex = 8;
            this.btnComprar.Text = "Comprar";
            this.btnComprar.UseVisualStyleBackColor = true;
            this.btnComprar.Click += new System.EventHandler(this.btnComprar_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCerrar.Location = new System.Drawing.Point(499, 257);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(75, 23);
            this.btnCerrar.TabIndex = 9;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // dtpFecha
            // 
            this.dtpFecha.Enabled = false;
            this.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFecha.Location = new System.Drawing.Point(110, 177);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(130, 20);
            this.dtpFecha.TabIndex = 11;
            // 
            // txtOferta
            // 
            this.txtOferta.Enabled = false;
            this.txtOferta.Location = new System.Drawing.Point(56, 123);
            this.txtOferta.Name = "txtOferta";
            this.txtOferta.Size = new System.Drawing.Size(365, 20);
            this.txtOferta.TabIndex = 12;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtCredito);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.lblAlertaUsuario);
            this.panel1.Controls.Add(this.txtNombreCliente);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(803, 89);
            this.panel1.TabIndex = 19;
            // 
            // txtCredito
            // 
            this.txtCredito.Enabled = false;
            this.txtCredito.Location = new System.Drawing.Point(417, 34);
            this.txtCredito.Name = "txtCredito";
            this.txtCredito.Size = new System.Drawing.Size(175, 20);
            this.txtCredito.TabIndex = 21;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(316, 37);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(95, 13);
            this.label6.TabIndex = 20;
            this.label6.Text = "Credito Disponible:";
            // 
            // lblAlertaUsuario
            // 
            this.lblAlertaUsuario.AutoSize = true;
            this.lblAlertaUsuario.ForeColor = System.Drawing.Color.Red;
            this.lblAlertaUsuario.Image = global::FrbaOfertas.Properties.Resources.alerta;
            this.lblAlertaUsuario.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblAlertaUsuario.Location = new System.Drawing.Point(110, 68);
            this.lblAlertaUsuario.Name = "lblAlertaUsuario";
            this.lblAlertaUsuario.Size = new System.Drawing.Size(661, 13);
            this.lblAlertaUsuario.TabIndex = 19;
            this.lblAlertaUsuario.Text = "      El usuario actual no tiene un cliente asociado, por favor comuniquese con e" +
    "l adinistrador para solicitar se asocie el usuario a un cliente.";
            this.lblAlertaUsuario.Visible = false;
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.CadetBlue;
            this.label7.Dock = System.Windows.Forms.DockStyle.Top;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(0, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(803, 19);
            this.label7.TabIndex = 18;
            this.label7.Text = "Datos del cliente";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.CadetBlue;
            this.label5.Dock = System.Windows.Forms.DockStyle.Top;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(0, 89);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(803, 19);
            this.label5.TabIndex = 20;
            this.label5.Text = "Datos de la Oferta";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBuscar.BackColor = System.Drawing.SystemColors.Control;
            this.btnBuscar.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnBuscar.Image = global::FrbaOfertas.Properties.Resources.botonBuscador;
            this.btnBuscar.Location = new System.Drawing.Point(427, 120);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(33, 25);
            this.btnBuscar.TabIndex = 2;
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Enabled = false;
            this.txtDescripcion.Location = new System.Drawing.Point(544, 126);
            this.txtDescripcion.Multiline = true;
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(227, 74);
            this.txtDescripcion.TabIndex = 22;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(472, 129);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(66, 13);
            this.label8.TabIndex = 21;
            this.label8.Text = "Descripción:";
            // 
            // txtStock
            // 
            this.txtStock.Enabled = false;
            this.txtStock.Location = new System.Drawing.Point(110, 205);
            this.txtStock.Name = "txtStock";
            this.txtStock.Size = new System.Drawing.Size(130, 20);
            this.txtStock.TabIndex = 24;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(15, 208);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(90, 13);
            this.label9.TabIndex = 23;
            this.label9.Text = "Stock Disponible:";
            // 
            // txtMaximo
            // 
            this.txtMaximo.Enabled = false;
            this.txtMaximo.Location = new System.Drawing.Point(111, 233);
            this.txtMaximo.Name = "txtMaximo";
            this.txtMaximo.Size = new System.Drawing.Size(130, 20);
            this.txtMaximo.TabIndex = 26;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(3, 236);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(103, 13);
            this.label10.TabIndex = 25;
            this.label10.Text = "Máximo por Compra:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(443, 210);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(102, 13);
            this.label11.TabIndex = 27;
            this.label11.Text = "Cantidad a comprar:";
            // 
            // nmCantidad
            // 
            this.nmCantidad.Location = new System.Drawing.Point(544, 209);
            this.nmCantidad.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.nmCantidad.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nmCantidad.Name = "nmCantidad";
            this.nmCantidad.Size = new System.Drawing.Size(120, 20);
            this.nmCantidad.TabIndex = 28;
            this.nmCantidad.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // txtLista
            // 
            this.txtLista.Enabled = false;
            this.txtLista.Location = new System.Drawing.Point(330, 149);
            this.txtLista.Name = "txtLista";
            this.txtLista.Size = new System.Drawing.Size(130, 20);
            this.txtLista.TabIndex = 30;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(259, 152);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(65, 13);
            this.label12.TabIndex = 29;
            this.label12.Text = "Precio Lista:";
            // 
            // txtPoferta
            // 
            this.txtPoferta.Enabled = false;
            this.txtPoferta.Location = new System.Drawing.Point(330, 175);
            this.txtPoferta.Name = "txtPoferta";
            this.txtPoferta.Size = new System.Drawing.Size(130, 20);
            this.txtPoferta.TabIndex = 32;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(254, 178);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(70, 13);
            this.label13.TabIndex = 31;
            this.label13.Text = "Precio oferta:";
            // 
            // FrmCompraDeOfertas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(803, 292);
            this.Controls.Add(this.txtPoferta);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.txtLista);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.nmCantidad);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtMaximo);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtStock);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtOferta);
            this.Controls.Add(this.dtpFecha);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.txtNumero);
            this.Controls.Add(this.btnComprar);
            this.Controls.Add(this.label3);
            this.Name = "FrmCompraDeOfertas";
            this.Text = "Compra de ofertas";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmCantidad)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNombreCliente;
        private System.Windows.Forms.Button btnComprar;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.TextBox txtOferta;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblAlertaUsuario;
        private System.Windows.Forms.TextBox txtCredito;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtStock;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtMaximo;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.NumericUpDown nmCantidad;
        private System.Windows.Forms.TextBox txtLista;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtPoferta;
        private System.Windows.Forms.Label label13;
    }
}