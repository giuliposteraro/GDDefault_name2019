using FrbaOfertasPresentacion.LogIn.ListadoDeCuentas;
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
    public partial class FrmListadoDeCuentas : Form, IVistaListadoCuentas
    {
        private readonly PresentadorListadoCuentas _presenter;

        public PresentadorListadoCuentas Presentador { get { return _presenter; } }

        public FrmListadoDeCuentas()
        {
            InitializeComponent();
            _presenter = new PresentadorListadoCuentas(this);
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

        public List<Usuario>  Usuarios
        {
            get { return (List<Usuario>)dgvCuentas.Items; }
            set
            {
                dgvCuentas.Items = value;
            }
        }


        #endregion

        private void FrmListadoDeCuentas_Load(object sender, EventArgs e)
        {
            _presenter.IniciarVista();
        }

        private void FrmListadoDeCuentas_Shown(object sender, EventArgs e)
        {
            dgvCuentas._parentForm_Shown(sender, e);
        }

        public void MostrarMensaje(string message)
        {
            MessageBox.Show(message);
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            _presenter.BuscarConFiltros();
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

        private void btnCambiarContraseña_Click(object sender, EventArgs e)
        {
            if (DesignMode) return;
            if (dgvCuentas.ItemSeleccionado == null)
            {
                this.MostrarMensaje("debe seleccionar un usuario para cambiar la contraseña");
                return;
            }

            var frm = new FrmCambiarContraseña();
            frm.Presentador.Posicionar((Usuario)dgvCuentas.ItemSeleccionado);
            if (frm.ShowDialog(this.MdiParent) == System.Windows.Forms.DialogResult.OK)
            {
                _presenter.ActualizarGrilla();
            }
        }
    }
}
