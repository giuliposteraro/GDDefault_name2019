using FrbaOfertasPresentacion.LogIn;
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
    public partial class FrmInicioDeSession : Form, IVistaInicioSession
    {
        private readonly InicioDeSessionPresenter _presenter;

        public FrmInicioDeSession()
        {
            InitializeComponent();
            _presenter = new InicioDeSessionPresenter(this);
        }

        public string Password
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
            if (_presenter.logguearUsuario())
                DialogResult = DialogResult.OK;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}


