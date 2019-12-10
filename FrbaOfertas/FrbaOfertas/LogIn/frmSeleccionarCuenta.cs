using FrbaOfertasPresentacion.LogIn.SeleccionCuenta;
using Negocio.Entidades;
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
    public partial class frmSeleccionarCuenta : Form, IVistaSeleccionCuenta
    {

        private readonly PresentadorSeleccionCuenta _presenter;

        public PresentadorSeleccionCuenta Presentador { get { return _presenter; } }

        public frmSeleccionarCuenta()
        {
            InitializeComponent();
            _presenter = new PresentadorSeleccionCuenta(this);
        }

        public Usuario UsuarioSeleccionado
        {
            get { return (Usuario)dgvCuentas.ItemSeleccionado; }
            set
            {
                dgvCuentas.ItemSeleccionado = value;
            }
        }

        public void MostrarMensaje(string message)
        {
            MessageBox.Show(message);
        }

        public bool MensajePregunta(string mensage)
        {
            return (MessageBox.Show(mensage, "Confirmar", System.Windows.Forms.MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }


        private void frmSeleccionarCuenta_Load(object sender, EventArgs e)
        {

        }

        private void frmSeleccionarCuenta_Shown(object sender, EventArgs e)
        {
            dgvCuentas._parentForm_Shown(sender, e);
        }

        #region grilla

        private void dgvCuentas_SelectionChanged(object sender, System.EventArgs e)
        {
            if (DesignMode) return;
            //Presenter.CambioItemSeleccionado()
        }

        private void dgvCuentas_CambioChequeadosMultiplesItems(object sender, System.EventArgs e)
        {
            if (DesignMode) return;
        }

        private void dgvCuentas_CambioChequeadosUnItem(object sender, System.Windows.Forms.DataGridViewCellEventArgs e)
        {
            if (DesignMode) return;
        }

        private void dgvCuentas_CargarMenuContextual(object sender, EventArgs e)
        {

        }

        #endregion

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            Presentador.BuscarConFiltros();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (this.UsuarioSeleccionado == null)
            {
                this.MostrarMensaje("Debe seleccionar una Cuenta");
                return;
            }
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        #region Implementation of IVistaListadoCuentas

        public string Usuario_Nombre
        {
            get { return txtUsuario_Cuenta.Text; }
            set { txtUsuario_Cuenta.Text = value.ToString(); }
        }

        public bool Activo
        {
            get { return chkActivo.Checked; }
            set { chkActivo.Checked = value; }
        }

        public List<Usuario> Usuarios
        {
            get { return (List<Usuario>)dgvCuentas.Items; }
            set
            {
                dgvCuentas.Items = value;
            }
        }


        #endregion
    }
}
