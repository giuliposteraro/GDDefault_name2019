namespace FrbaOfertas.LogIn
{
    partial class FrmAltaDeCuentas
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
            this.Label4 = new System.Windows.Forms.Label();
            this.panComandos = new System.Windows.Forms.Panel();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.chkRoles = new System.Windows.Forms.CheckedListBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.txtPass2 = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblDatosExtra = new System.Windows.Forms.Label();
            this.lblTipo = new System.Windows.Forms.Label();
            this.cboTipo = new System.Windows.Forms.ComboBox();
            this.ucCliente1 = new FrbaOfertas.AbmCliente.ucCliente();
            this.ucProveedor1 = new FrbaOfertas.AbmProveedor.ucProveedor();
            this.panComandos.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // Label4
            // 
            this.Label4.BackColor = System.Drawing.Color.CadetBlue;
            this.Label4.Dock = System.Windows.Forms.DockStyle.Top;
            this.Label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label4.ForeColor = System.Drawing.Color.White;
            this.Label4.Location = new System.Drawing.Point(0, 0);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(501, 19);
            this.Label4.TabIndex = 15;
            this.Label4.Text = "Datos Usuario";
            this.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panComandos
            // 
            this.panComandos.BackColor = System.Drawing.Color.LightSteelBlue;
            this.panComandos.Controls.Add(this.btnAgregar);
            this.panComandos.Controls.Add(this.btnCancelar);
            this.panComandos.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panComandos.Location = new System.Drawing.Point(0, 381);
            this.panComandos.Name = "panComandos";
            this.panComandos.Size = new System.Drawing.Size(501, 32);
            this.panComandos.TabIndex = 16;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAgregar.BackColor = System.Drawing.SystemColors.Control;
            this.btnAgregar.Location = new System.Drawing.Point(340, 4);
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
            this.btnCancelar.Location = new System.Drawing.Point(421, 4);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 25);
            this.btnCancelar.TabIndex = 1;
            this.btnCancelar.Text = "Cerrar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cboTipo);
            this.panel1.Controls.Add(this.lblTipo);
            this.panel1.Controls.Add(this.txtPass2);
            this.panel1.Controls.Add(this.txtPass);
            this.panel1.Controls.Add(this.txtNombre);
            this.panel1.Controls.Add(this.chkRoles);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 19);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(501, 112);
            this.panel1.TabIndex = 17;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "repetir password:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(43, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "password:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre Usuario:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(246, 10);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "roles:";
            // 
            // chkRoles
            // 
            this.chkRoles.FormattingEnabled = true;
            this.chkRoles.Location = new System.Drawing.Point(285, 10);
            this.chkRoles.Name = "chkRoles";
            this.chkRoles.Size = new System.Drawing.Size(191, 64);
            this.chkRoles.TabIndex = 4;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(104, 7);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(135, 20);
            this.txtNombre.TabIndex = 5;
            // 
            // txtPass
            // 
            this.txtPass.Location = new System.Drawing.Point(104, 30);
            this.txtPass.Name = "txtPass";
            this.txtPass.PasswordChar = '*';
            this.txtPass.Size = new System.Drawing.Size(135, 20);
            this.txtPass.TabIndex = 6;
            // 
            // txtPass2
            // 
            this.txtPass2.Location = new System.Drawing.Point(104, 52);
            this.txtPass2.Name = "txtPass2";
            this.txtPass2.PasswordChar = '*';
            this.txtPass2.Size = new System.Drawing.Size(135, 20);
            this.txtPass2.TabIndex = 7;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.ucProveedor1);
            this.panel2.Controls.Add(this.ucCliente1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 131);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(501, 250);
            this.panel2.TabIndex = 18;
            // 
            // lblDatosExtra
            // 
            this.lblDatosExtra.BackColor = System.Drawing.Color.CadetBlue;
            this.lblDatosExtra.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblDatosExtra.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDatosExtra.ForeColor = System.Drawing.Color.White;
            this.lblDatosExtra.Location = new System.Drawing.Point(0, 131);
            this.lblDatosExtra.Name = "lblDatosExtra";
            this.lblDatosExtra.Size = new System.Drawing.Size(501, 19);
            this.lblDatosExtra.TabIndex = 19;
            this.lblDatosExtra.Text = "Datos del Cliente";
            this.lblDatosExtra.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblTipo
            // 
            this.lblTipo.AutoSize = true;
            this.lblTipo.Location = new System.Drawing.Point(20, 85);
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Size = new System.Drawing.Size(78, 13);
            this.lblTipo.TabIndex = 8;
            this.lblTipo.Text = "TipoDeUsuario";
            // 
            // cboTipo
            // 
            this.cboTipo.FormattingEnabled = true;
            this.cboTipo.Location = new System.Drawing.Point(104, 82);
            this.cboTipo.Name = "cboTipo";
            this.cboTipo.Size = new System.Drawing.Size(163, 21);
            this.cboTipo.TabIndex = 9;
            this.cboTipo.SelectedIndexChanged += new System.EventHandler(this.cboTipo_SelectedIndexChanged);
            // 
            // ucCliente1
            // 
            this.ucCliente1.Location = new System.Drawing.Point(0, 21);
            this.ucCliente1.MaximumSize = new System.Drawing.Size(501, 225);
            this.ucCliente1.MinimumSize = new System.Drawing.Size(501, 225);
            this.ucCliente1.Name = "ucCliente1";
            this.ucCliente1.Size = new System.Drawing.Size(501, 225);
            this.ucCliente1.TabIndex = 0;
            // 
            // ucProveedor1
            // 
            this.ucProveedor1.Location = new System.Drawing.Point(0, 21);
            this.ucProveedor1.MaximumSize = new System.Drawing.Size(501, 225);
            this.ucProveedor1.MinimumSize = new System.Drawing.Size(501, 225);
            this.ucProveedor1.Name = "ucProveedor1";
            this.ucProveedor1.Size = new System.Drawing.Size(501, 225);
            this.ucProveedor1.TabIndex = 1;
            // 
            // FrmAltaDeCuentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancelar;
            this.ClientSize = new System.Drawing.Size(501, 413);
            this.Controls.Add(this.lblDatosExtra);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panComandos);
            this.Controls.Add(this.Label4);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(517, 452);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(517, 452);
            this.Name = "FrmAltaDeCuentas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Alta De Cuentas";
            this.Load += new System.EventHandler(this.FrmAltaDeCuentas_Load);
            this.panComandos.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label Label4;
        private System.Windows.Forms.Panel panComandos;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPass2;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.CheckedListBox chkRoles;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel2;
        private AbmCliente.ucCliente ucCliente1;
        private System.Windows.Forms.Label lblDatosExtra;
        private System.Windows.Forms.ComboBox cboTipo;
        private System.Windows.Forms.Label lblTipo;
        private AbmProveedor.ucProveedor ucProveedor1;
    }
}