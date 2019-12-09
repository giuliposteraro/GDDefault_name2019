namespace FrbaOfertas.AbmCliente
{
    partial class FrmClienteEditar
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
            this.ucCliente1 = new FrbaOfertas.AbmCliente.ucCliente();
            this.Label4 = new System.Windows.Forms.Label();
            this.panComandos = new System.Windows.Forms.Panel();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.panComandos.SuspendLayout();
            this.SuspendLayout();
            // 
            // ucCliente1
            // 
            this.ucCliente1.Location = new System.Drawing.Point(2, 34);
            this.ucCliente1.MaximumSize = new System.Drawing.Size(501, 225);
            this.ucCliente1.MinimumSize = new System.Drawing.Size(501, 225);
            this.ucCliente1.Name = "ucCliente1";
            this.ucCliente1.Size = new System.Drawing.Size(501, 225);
            this.ucCliente1.TabIndex = 0;
            // 
            // Label4
            // 
            this.Label4.BackColor = System.Drawing.Color.CadetBlue;
            this.Label4.Dock = System.Windows.Forms.DockStyle.Top;
            this.Label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label4.ForeColor = System.Drawing.Color.White;
            this.Label4.Location = new System.Drawing.Point(0, 0);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(454, 19);
            this.Label4.TabIndex = 10;
            this.Label4.Text = "Filtros";
            this.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panComandos
            // 
            this.panComandos.BackColor = System.Drawing.Color.LightSteelBlue;
            this.panComandos.Controls.Add(this.btnGuardar);
            this.panComandos.Controls.Add(this.btnCancelar);
            this.panComandos.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panComandos.Location = new System.Drawing.Point(0, 264);
            this.panComandos.Name = "panComandos";
            this.panComandos.Size = new System.Drawing.Size(454, 32);
            this.panComandos.TabIndex = 11;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancelar.BackColor = System.Drawing.SystemColors.Control;
            this.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancelar.Location = new System.Drawing.Point(374, 4);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 25);
            this.btnCancelar.TabIndex = 1;
            this.btnCancelar.Text = "Cerrar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGuardar.BackColor = System.Drawing.SystemColors.Control;
            this.btnGuardar.Location = new System.Drawing.Point(293, 4);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 25);
            this.btnGuardar.TabIndex = 2;
            this.btnGuardar.Text = "Aceptar";
            this.btnGuardar.UseVisualStyleBackColor = false;
            // 
            // FrmClienteEditar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(454, 296);
            this.Controls.Add(this.panComandos);
            this.Controls.Add(this.Label4);
            this.Controls.Add(this.ucCliente1);
            this.Name = "FrmClienteEditar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FrmClienteEditar";
            this.panComandos.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private ucCliente ucCliente1;
        private System.Windows.Forms.Label Label4;
        private System.Windows.Forms.Panel panComandos;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnGuardar;
    }
}