namespace FrbaOfertas.LogIn
{
    partial class FrmInicioDeSession
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmInicioDeSession));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panPrincipal = new System.Windows.Forms.Panel();
            this.txtContraseña = new System.Windows.Forms.TextBox();
            this.txtNombreInicioSesion = new System.Windows.Forms.TextBox();
            this.lblInstruccion = new System.Windows.Forms.Label();
            this.lblSaludo = new System.Windows.Forms.Label();
            this.Label2 = new System.Windows.Forms.Label();
            this.Label1 = new System.Windows.Forms.Label();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panPrincipal.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::FrbaOfertas.Properties.Resources.login;
            this.pictureBox1.Location = new System.Drawing.Point(-1, -1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(189, 262);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panPrincipal
            // 
            this.panPrincipal.BackColor = System.Drawing.Color.Transparent;
            this.panPrincipal.Controls.Add(this.linkLabel2);
            this.panPrincipal.Controls.Add(this.linkLabel1);
            this.panPrincipal.Controls.Add(this.btnSalir);
            this.panPrincipal.Controls.Add(this.btnAceptar);
            this.panPrincipal.Controls.Add(this.txtContraseña);
            this.panPrincipal.Controls.Add(this.txtNombreInicioSesion);
            this.panPrincipal.Controls.Add(this.lblInstruccion);
            this.panPrincipal.Controls.Add(this.lblSaludo);
            this.panPrincipal.Controls.Add(this.Label2);
            this.panPrincipal.Controls.Add(this.Label1);
            this.panPrincipal.Dock = System.Windows.Forms.DockStyle.Right;
            this.panPrincipal.Location = new System.Drawing.Point(184, 0);
            this.panPrincipal.Name = "panPrincipal";
            this.panPrincipal.Size = new System.Drawing.Size(259, 261);
            this.panPrincipal.TabIndex = 8;
            // 
            // txtContraseña
            // 
            this.txtContraseña.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtContraseña.Location = new System.Drawing.Point(87, 91);
            this.txtContraseña.Name = "txtContraseña";
            this.txtContraseña.Size = new System.Drawing.Size(148, 20);
            this.txtContraseña.TabIndex = 12;
            this.txtContraseña.UseSystemPasswordChar = true;
            // 
            // txtNombreInicioSesion
            // 
            this.txtNombreInicioSesion.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNombreInicioSesion.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtNombreInicioSesion.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtNombreInicioSesion.Location = new System.Drawing.Point(87, 63);
            this.txtNombreInicioSesion.Name = "txtNombreInicioSesion";
            this.txtNombreInicioSesion.Size = new System.Drawing.Size(148, 20);
            this.txtNombreInicioSesion.TabIndex = 10;
            // 
            // lblInstruccion
            // 
            this.lblInstruccion.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblInstruccion.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblInstruccion.Location = new System.Drawing.Point(0, 26);
            this.lblInstruccion.Name = "lblInstruccion";
            this.lblInstruccion.Size = new System.Drawing.Size(259, 13);
            this.lblInstruccion.TabIndex = 7;
            this.lblInstruccion.Text = "Ingrese su nombre de inicio de sesión y contraseña";
            this.lblInstruccion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblSaludo
            // 
            this.lblSaludo.BackColor = System.Drawing.Color.AliceBlue;
            this.lblSaludo.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblSaludo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.lblSaludo.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblSaludo.Location = new System.Drawing.Point(0, 0);
            this.lblSaludo.Name = "lblSaludo";
            this.lblSaludo.Size = new System.Drawing.Size(259, 26);
            this.lblSaludo.TabIndex = 6;
            this.lblSaludo.Text = "Bienvenido!";
            this.lblSaludo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Label2.Location = new System.Drawing.Point(23, 97);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(61, 13);
            this.Label2.TabIndex = 11;
            this.Label2.Text = "Contraseña";
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Label1.Location = new System.Drawing.Point(41, 66);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(43, 13);
            this.Label1.TabIndex = 9;
            this.Label1.Text = "Usuario";
            // 
            // btnSalir
            // 
            this.btnSalir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSalir.BackColor = System.Drawing.SystemColors.Control;
            this.btnSalir.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnSalir.Image = ((System.Drawing.Image)(resources.GetObject("btnSalir.Image")));
            this.btnSalir.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnSalir.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnSalir.Location = new System.Drawing.Point(153, 128);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(59, 44);
            this.btnSalir.TabIndex = 15;
            this.btnSalir.Text = "Salir";
            this.btnSalir.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnAceptar
            // 
            this.btnAceptar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAceptar.BackColor = System.Drawing.SystemColors.Control;
            this.btnAceptar.Image = ((System.Drawing.Image)(resources.GetObject("btnAceptar.Image")));
            this.btnAceptar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnAceptar.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnAceptar.Location = new System.Drawing.Point(88, 128);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(59, 44);
            this.btnAceptar.TabIndex = 13;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAceptar.UseVisualStyleBackColor = false;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(87, 192);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(108, 13);
            this.linkLabel1.TabIndex = 16;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Recordar Contraseña";
            // 
            // linkLabel2
            // 
            this.linkLabel2.AutoSize = true;
            this.linkLabel2.Location = new System.Drawing.Point(87, 218);
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.Size = new System.Drawing.Size(60, 13);
            this.linkLabel2.TabIndex = 17;
            this.linkLabel2.TabStop = true;
            this.linkLabel2.Text = "Registrarse";
            // 
            // FrmInicioDeSession
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnSalir;
            this.ClientSize = new System.Drawing.Size(443, 261);
            this.Controls.Add(this.panPrincipal);
            this.Controls.Add(this.pictureBox1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(459, 300);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(459, 300);
            this.Name = "FrmInicioDeSession";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Inicio de sesión";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panPrincipal.ResumeLayout(false);
            this.panPrincipal.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panPrincipal;
        private System.Windows.Forms.LinkLabel linkLabel2;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.TextBox txtContraseña;
        private System.Windows.Forms.TextBox txtNombreInicioSesion;
        private System.Windows.Forms.Label lblInstruccion;
        private System.Windows.Forms.Label lblSaludo;
        private System.Windows.Forms.Label Label2;
        private System.Windows.Forms.Label Label1;
    }
}