using FrbaOfertasPresentacion.LogIn;
using FrbaOfertasPresentacion.LogIn.AltaCuenta;
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

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var frm = new FrmAltaDeCuentas();
            //frm.MdiParent = this;
            frm.Presentador.Posicionar(ModoAltaCuenta.DesdeLogIn);
            if (frm.ShowDialog() == DialogResult.OK)
            {
                
            }
        }


        private void txtContraseña_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                btnAceptar.PerformClick();
            }
        }

        public bool MensajePregunta(string mensage)
        {
            return (MessageBox.Show(mensage, "Confirmar", System.Windows.Forms.MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes);
        }
    }
}


