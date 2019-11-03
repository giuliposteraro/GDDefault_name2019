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
    public partial class FrmAltaDeCuentas : Form, IVistaAltaCuenta
    {

        private readonly PresentadorAltaCuenta _presenter;
        public FrmAltaDeCuentas()
        {
            InitializeComponent();
            _presenter = new PresentadorAltaCuenta(this);
        }

        public void MostrarMensaje(string message)
        {
            MessageBox.Show(message);
        }

        private void FrmAltaDeCuentas_Load(object sender, EventArgs e)
        {
            _presenter.IniciarVista();
        }

        public bool MensajePregunta(string mensage)
        {
            return (MessageBox.Show(mensage, "Confirmar", System.Windows.Forms.MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes);
        }
    }
}
