using FrbaOfertasPresentacion.LogIn.CambiarContraseña;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrbaOfertas.LogIn
{
    public partial class FrmCambiarContraseña : Form, IVistaCambioContraseña
    {
         private readonly PresentadorCambioContraseña _presenter;

         public FrmCambiarContraseña()
        {
            InitializeComponent();
            _presenter = new PresentadorCambioContraseña(this);
        }

         public PresentadorCambioContraseña Presentador { get { return _presenter; } }

         public string PasswordNuevo
         {
             get
             {
                 return txtContraseña.Text;
             }

             set
             {
                 txtContraseña.Text = value;
             }
         }

         public string RepetirPassword
         {
             get
             {
                 return txtContraseñaRepetir.Text;
             }

             set
             {
                 txtContraseñaRepetir.Text = value;
             }
         }
         public string Usuario
         {
             get
             {
                 return txtNombreInicioSesion.Text;
             }

             set
             {
                 txtNombreInicioSesion.Text = value;
             }
         }

         public void MostrarMensaje(string message)
         {
             MessageBox.Show(message);
         }

         private void btnAceptar_Click(object sender, EventArgs e)
         {
             if (_presenter.GuardarContraseña())
             {
                 DialogResult = DialogResult.OK;
                 this.Close();
             }
         }

         private void btnCancelar_Click(object sender, EventArgs e)
         {
             DialogResult = DialogResult.Cancel;
             this.Close();
         }

         private void txtContraseñaRepetir_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                btnAceptar.PerformClick();
            }
        }

        private void txtContraseña_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                btnAceptar.PerformClick();
            }
        }

        
    }
}
