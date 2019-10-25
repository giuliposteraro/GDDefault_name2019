namespace FrbaOfertas.AbmProveedor
{
    partial class ViewProveedores
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
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBoxDireccion = new System.Windows.Forms.GroupBox();
            this.textBoxCalle = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.textBoxNro = new System.Windows.Forms.TextBox();
            this.textBoxLocalidad = new System.Windows.Forms.TextBox();
            this.textBoxPiso = new System.Windows.Forms.TextBox();
            this.textBoxDpto = new System.Windows.Forms.TextBox();
            this.textBoxCp = new System.Windows.Forms.TextBox();
            this.textBoxCiudad = new System.Windows.Forms.TextBox();
            this.textBoxNombreContacto = new System.Windows.Forms.TextBox();
            this.textBoxRazonSocial = new System.Windows.Forms.TextBox();
            this.textBoxCuit = new System.Windows.Forms.TextBox();
            this.textBoxRubro = new System.Windows.Forms.TextBox();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.textBoxTelefono = new System.Windows.Forms.TextBox();
            this.panComandos.SuspendLayout();
            this.groupBoxDireccion.SuspendLayout();
            this.SuspendLayout();
            // 
            // panComandos
            // 
            this.panComandos.BackColor = System.Drawing.Color.LightSteelBlue;
            this.panComandos.Controls.Add(this.btnAgregar);
            this.panComandos.Controls.Add(this.btnCancelar);
            this.panComandos.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panComandos.Location = new System.Drawing.Point(0, 439);
            this.panComandos.Name = "panComandos";
            this.panComandos.Size = new System.Drawing.Size(408, 32);
            this.panComandos.TabIndex = 11;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAgregar.BackColor = System.Drawing.SystemColors.Control;
            this.btnAgregar.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnAgregar.Location = new System.Drawing.Point(46, 3);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 25);
            this.btnAgregar.TabIndex = 2;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancelar.BackColor = System.Drawing.SystemColors.Control;
            this.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancelar.Location = new System.Drawing.Point(275, 3);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 25);
            this.btnCancelar.TabIndex = 1;
            this.btnCancelar.Text = "Cerrar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Nombre Contacto";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Razón Social:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "CUIT:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 118);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "Rubro:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(22, 326);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "Email";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(22, 363);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 13);
            this.label6.TabIndex = 17;
            this.label6.Text = "Telefono:";
            // 
            // groupBoxDireccion
            // 
            this.groupBoxDireccion.Controls.Add(this.textBoxCiudad);
            this.groupBoxDireccion.Controls.Add(this.textBoxCp);
            this.groupBoxDireccion.Controls.Add(this.textBoxDpto);
            this.groupBoxDireccion.Controls.Add(this.textBoxPiso);
            this.groupBoxDireccion.Controls.Add(this.textBoxLocalidad);
            this.groupBoxDireccion.Controls.Add(this.textBoxNro);
            this.groupBoxDireccion.Controls.Add(this.label14);
            this.groupBoxDireccion.Controls.Add(this.label13);
            this.groupBoxDireccion.Controls.Add(this.label11);
            this.groupBoxDireccion.Controls.Add(this.label10);
            this.groupBoxDireccion.Controls.Add(this.label9);
            this.groupBoxDireccion.Controls.Add(this.label8);
            this.groupBoxDireccion.Controls.Add(this.label7);
            this.groupBoxDireccion.Controls.Add(this.textBoxCalle);
            this.groupBoxDireccion.Location = new System.Drawing.Point(25, 157);
            this.groupBoxDireccion.Name = "groupBoxDireccion";
            this.groupBoxDireccion.Size = new System.Drawing.Size(341, 146);
            this.groupBoxDireccion.TabIndex = 18;
            this.groupBoxDireccion.TabStop = false;
            this.groupBoxDireccion.Text = "Direccion";
            // 
            // textBoxCalle
            // 
            this.textBoxCalle.Location = new System.Drawing.Point(6, 34);
            this.textBoxCalle.Name = "textBoxCalle";
            this.textBoxCalle.Size = new System.Drawing.Size(108, 20);
            this.textBoxCalle.TabIndex = 19;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 18);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(33, 13);
            this.label7.TabIndex = 19;
            this.label7.Text = "Calle:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(125, 18);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(47, 13);
            this.label8.TabIndex = 20;
            this.label8.Text = "Numero:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(235, 18);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(56, 13);
            this.label9.TabIndex = 21;
            this.label9.Text = "Localidad:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 71);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(30, 13);
            this.label10.TabIndex = 22;
            this.label10.Text = "Piso:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(66, 71);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(33, 13);
            this.label11.TabIndex = 23;
            this.label11.Text = "Dpto:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(235, 71);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(75, 13);
            this.label13.TabIndex = 25;
            this.label13.Text = "Codigo Postal:";
            this.label13.Click += new System.EventHandler(this.label13_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(125, 70);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(43, 13);
            this.label14.TabIndex = 26;
            this.label14.Text = "Ciudad:";
            this.label14.Click += new System.EventHandler(this.label14_Click);
            // 
            // textBoxNro
            // 
            this.textBoxNro.Location = new System.Drawing.Point(128, 34);
            this.textBoxNro.Name = "textBoxNro";
            this.textBoxNro.Size = new System.Drawing.Size(87, 20);
            this.textBoxNro.TabIndex = 27;
            // 
            // textBoxLocalidad
            // 
            this.textBoxLocalidad.Location = new System.Drawing.Point(238, 34);
            this.textBoxLocalidad.Name = "textBoxLocalidad";
            this.textBoxLocalidad.Size = new System.Drawing.Size(87, 20);
            this.textBoxLocalidad.TabIndex = 28;
            // 
            // textBoxPiso
            // 
            this.textBoxPiso.Location = new System.Drawing.Point(9, 87);
            this.textBoxPiso.Name = "textBoxPiso";
            this.textBoxPiso.Size = new System.Drawing.Size(47, 20);
            this.textBoxPiso.TabIndex = 29;
            // 
            // textBoxDpto
            // 
            this.textBoxDpto.Location = new System.Drawing.Point(67, 87);
            this.textBoxDpto.Name = "textBoxDpto";
            this.textBoxDpto.Size = new System.Drawing.Size(47, 20);
            this.textBoxDpto.TabIndex = 30;
            // 
            // textBoxCp
            // 
            this.textBoxCp.Location = new System.Drawing.Point(238, 87);
            this.textBoxCp.Name = "textBoxCp";
            this.textBoxCp.Size = new System.Drawing.Size(87, 20);
            this.textBoxCp.TabIndex = 32;
            // 
            // textBoxCiudad
            // 
            this.textBoxCiudad.Location = new System.Drawing.Point(128, 87);
            this.textBoxCiudad.Name = "textBoxCiudad";
            this.textBoxCiudad.Size = new System.Drawing.Size(87, 20);
            this.textBoxCiudad.TabIndex = 33;
            // 
            // textBoxNombreContacto
            // 
            this.textBoxNombreContacto.Location = new System.Drawing.Point(117, 29);
            this.textBoxNombreContacto.Name = "textBoxNombreContacto";
            this.textBoxNombreContacto.Size = new System.Drawing.Size(117, 20);
            this.textBoxNombreContacto.TabIndex = 34;
            // 
            // textBoxRazonSocial
            // 
            this.textBoxRazonSocial.Location = new System.Drawing.Point(117, 60);
            this.textBoxRazonSocial.Name = "textBoxRazonSocial";
            this.textBoxRazonSocial.Size = new System.Drawing.Size(117, 20);
            this.textBoxRazonSocial.TabIndex = 35;
            // 
            // textBoxCuit
            // 
            this.textBoxCuit.Location = new System.Drawing.Point(117, 89);
            this.textBoxCuit.Name = "textBoxCuit";
            this.textBoxCuit.Size = new System.Drawing.Size(117, 20);
            this.textBoxCuit.TabIndex = 36;
            // 
            // textBoxRubro
            // 
            this.textBoxRubro.Location = new System.Drawing.Point(117, 115);
            this.textBoxRubro.Name = "textBoxRubro";
            this.textBoxRubro.Size = new System.Drawing.Size(117, 20);
            this.textBoxRubro.TabIndex = 37;
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.Location = new System.Drawing.Point(117, 319);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(117, 20);
            this.textBoxEmail.TabIndex = 38;
            // 
            // textBoxTelefono
            // 
            this.textBoxTelefono.Location = new System.Drawing.Point(117, 360);
            this.textBoxTelefono.Name = "textBoxTelefono";
            this.textBoxTelefono.Size = new System.Drawing.Size(117, 20);
            this.textBoxTelefono.TabIndex = 39;
            // 
            // ViewProveedores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(408, 471);
            this.Controls.Add(this.textBoxTelefono);
            this.Controls.Add(this.textBoxEmail);
            this.Controls.Add(this.textBoxRubro);
            this.Controls.Add(this.textBoxCuit);
            this.Controls.Add(this.textBoxRazonSocial);
            this.Controls.Add(this.textBoxNombreContacto);
            this.Controls.Add(this.groupBoxDireccion);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panComandos);
            this.Name = "ViewProveedores";
            this.Text = "Alta Proveedores";
            this.Load += new System.EventHandler(this.ViewProveedores_Load);
            this.panComandos.ResumeLayout(false);
            this.groupBoxDireccion.ResumeLayout(false);
            this.groupBoxDireccion.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panComandos;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBoxDireccion;
        private System.Windows.Forms.TextBox textBoxCalle;
        private System.Windows.Forms.TextBox textBoxCiudad;
        private System.Windows.Forms.TextBox textBoxCp;
        private System.Windows.Forms.TextBox textBoxDpto;
        private System.Windows.Forms.TextBox textBoxPiso;
        private System.Windows.Forms.TextBox textBoxLocalidad;
        private System.Windows.Forms.TextBox textBoxNro;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxNombreContacto;
        private System.Windows.Forms.TextBox textBoxRazonSocial;
        private System.Windows.Forms.TextBox textBoxCuit;
        private System.Windows.Forms.TextBox textBoxRubro;
        private System.Windows.Forms.TextBox textBoxEmail;
        private System.Windows.Forms.TextBox textBoxTelefono;
    }
}