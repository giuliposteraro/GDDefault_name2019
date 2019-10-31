namespace FrbaOfertas.AbmProveedor
{
    partial class AltaProveedorFrm
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
            this.textBoxRazonSocial = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.textBoxMail = new System.Windows.Forms.TextBox();
            this.textBoxTelefono = new System.Windows.Forms.TextBox();
            this.textBoxCuit = new System.Windows.Forms.TextBox();
            this.textBoxNombreContacto = new System.Windows.Forms.TextBox();
            this.textBoxCiudad = new System.Windows.Forms.TextBox();
            this.textBoxPiso = new System.Windows.Forms.TextBox();
            this.textBoxLocalidad = new System.Windows.Forms.TextBox();
            this.textBoxNroCalle = new System.Windows.Forms.TextBox();
            this.textBoxNombreCalle = new System.Windows.Forms.TextBox();
            this.textBoxDpto = new System.Windows.Forms.TextBox();
            this.textBoxCp = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBoxRazonSocial
            // 
            this.textBoxRazonSocial.Location = new System.Drawing.Point(122, 49);
            this.textBoxRazonSocial.Name = "textBoxRazonSocial";
            this.textBoxRazonSocial.Size = new System.Drawing.Size(100, 20);
            this.textBoxRazonSocial.TabIndex = 0;
            this.textBoxRazonSocial.TextChanged += new System.EventHandler(this.textBoxRazonSocial_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Razon Social:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nombre Calle:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(172, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Nro Calle:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(303, 33);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Localidad:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 72);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(30, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Piso:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 127);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "CUIT:";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 89);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(93, 13);
            this.label7.TabIndex = 7;
            this.label7.Text = "Nombre Contacto:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBoxCp);
            this.groupBox1.Controls.Add(this.textBoxCiudad);
            this.groupBox1.Controls.Add(this.textBoxDpto);
            this.groupBox1.Controls.Add(this.textBoxPiso);
            this.groupBox1.Controls.Add(this.textBoxLocalidad);
            this.groupBox1.Controls.Add(this.textBoxNroCalle);
            this.groupBox1.Controls.Add(this.textBoxNombreCalle);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Location = new System.Drawing.Point(15, 176);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(483, 139);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBoxDireccion";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(172, 72);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(75, 13);
            this.label8.TabIndex = 6;
            this.label8.Text = "Codigo Postal:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(77, 72);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(33, 13);
            this.label9.TabIndex = 7;
            this.label9.Text = "Dpto:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(303, 72);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(43, 13);
            this.label10.TabIndex = 8;
            this.label10.Text = "Ciudad:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(12, 403);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(29, 13);
            this.label11.TabIndex = 9;
            this.label11.Text = "Mail:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(12, 363);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(52, 13);
            this.label12.TabIndex = 10;
            this.label12.Text = "Telefono:";
            // 
            // textBoxMail
            // 
            this.textBoxMail.Location = new System.Drawing.Point(122, 400);
            this.textBoxMail.Name = "textBoxMail";
            this.textBoxMail.Size = new System.Drawing.Size(100, 20);
            this.textBoxMail.TabIndex = 11;
            this.textBoxMail.TextChanged += new System.EventHandler(this.textBoxMail_TextChanged);
            // 
            // textBoxTelefono
            // 
            this.textBoxTelefono.Location = new System.Drawing.Point(122, 360);
            this.textBoxTelefono.Name = "textBoxTelefono";
            this.textBoxTelefono.Size = new System.Drawing.Size(100, 20);
            this.textBoxTelefono.TabIndex = 12;
            this.textBoxTelefono.TextChanged += new System.EventHandler(this.textBoxTelefono_TextChanged);
            // 
            // textBoxCuit
            // 
            this.textBoxCuit.Location = new System.Drawing.Point(122, 124);
            this.textBoxCuit.Name = "textBoxCuit";
            this.textBoxCuit.Size = new System.Drawing.Size(100, 20);
            this.textBoxCuit.TabIndex = 13;
            this.textBoxCuit.TextChanged += new System.EventHandler(this.textBoxCuit_TextChanged);
            // 
            // textBoxNombreContacto
            // 
            this.textBoxNombreContacto.Location = new System.Drawing.Point(122, 86);
            this.textBoxNombreContacto.Name = "textBoxNombreContacto";
            this.textBoxNombreContacto.Size = new System.Drawing.Size(100, 20);
            this.textBoxNombreContacto.TabIndex = 14;
            this.textBoxNombreContacto.TextChanged += new System.EventHandler(this.textBoxNombreContacto_TextChanged);
            // 
            // textBoxCiudad
            // 
            this.textBoxCiudad.Location = new System.Drawing.Point(365, 69);
            this.textBoxCiudad.Name = "textBoxCiudad";
            this.textBoxCiudad.Size = new System.Drawing.Size(100, 20);
            this.textBoxCiudad.TabIndex = 17;
            this.textBoxCiudad.TextChanged += new System.EventHandler(this.textBoxCiudad_TextChanged);
            // 
            // textBoxPiso
            // 
            this.textBoxPiso.Location = new System.Drawing.Point(34, 69);
            this.textBoxPiso.Name = "textBoxPiso";
            this.textBoxPiso.Size = new System.Drawing.Size(37, 20);
            this.textBoxPiso.TabIndex = 18;
            this.textBoxPiso.TextChanged += new System.EventHandler(this.textBoxPiso_TextChanged);
            // 
            // textBoxLocalidad
            // 
            this.textBoxLocalidad.Location = new System.Drawing.Point(365, 30);
            this.textBoxLocalidad.Name = "textBoxLocalidad";
            this.textBoxLocalidad.Size = new System.Drawing.Size(100, 20);
            this.textBoxLocalidad.TabIndex = 19;
            this.textBoxLocalidad.TextChanged += new System.EventHandler(this.textBoxLocalidad_TextChanged);
            // 
            // textBoxNroCalle
            // 
            this.textBoxNroCalle.Location = new System.Drawing.Point(222, 30);
            this.textBoxNroCalle.Name = "textBoxNroCalle";
            this.textBoxNroCalle.Size = new System.Drawing.Size(76, 20);
            this.textBoxNroCalle.TabIndex = 20;
            this.textBoxNroCalle.TextChanged += new System.EventHandler(this.textBoxNroCalle_TextChanged);
            // 
            // textBoxNombreCalle
            // 
            this.textBoxNombreCalle.Location = new System.Drawing.Point(85, 30);
            this.textBoxNombreCalle.Name = "textBoxNombreCalle";
            this.textBoxNombreCalle.Size = new System.Drawing.Size(81, 20);
            this.textBoxNombreCalle.TabIndex = 21;
            this.textBoxNombreCalle.TextChanged += new System.EventHandler(this.textBoxNombreCalle_TextChanged);
            // 
            // textBoxDpto
            // 
            this.textBoxDpto.Location = new System.Drawing.Point(116, 69);
            this.textBoxDpto.Name = "textBoxDpto";
            this.textBoxDpto.Size = new System.Drawing.Size(37, 20);
            this.textBoxDpto.TabIndex = 22;
            this.textBoxDpto.TextChanged += new System.EventHandler(this.textBoxDpto_TextChanged);
            // 
            // textBoxCp
            // 
            this.textBoxCp.Location = new System.Drawing.Point(253, 69);
            this.textBoxCp.Name = "textBoxCp";
            this.textBoxCp.Size = new System.Drawing.Size(45, 20);
            this.textBoxCp.TabIndex = 23;
            this.textBoxCp.TextChanged += new System.EventHandler(this.textBoxCp_TextChanged);
            // 
            // AltaProveedorFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(510, 502);
            this.Controls.Add(this.textBoxNombreContacto);
            this.Controls.Add(this.textBoxCuit);
            this.Controls.Add(this.textBoxTelefono);
            this.Controls.Add(this.textBoxMail);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxRazonSocial);
            this.Name = "AltaProveedorFrm";
            this.Text = "Alta Proveedor";
            this.Load += new System.EventHandler(this.AltaProveedorFrm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxRazonSocial;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox textBoxCp;
        private System.Windows.Forms.TextBox textBoxCiudad;
        private System.Windows.Forms.TextBox textBoxDpto;
        private System.Windows.Forms.TextBox textBoxPiso;
        private System.Windows.Forms.TextBox textBoxLocalidad;
        private System.Windows.Forms.TextBox textBoxNroCalle;
        private System.Windows.Forms.TextBox textBoxNombreCalle;
        private System.Windows.Forms.TextBox textBoxMail;
        private System.Windows.Forms.TextBox textBoxTelefono;
        private System.Windows.Forms.TextBox textBoxCuit;
        private System.Windows.Forms.TextBox textBoxNombreContacto;
    }
}