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
                _presenter.ActualizarGrilla(frm.Presentador.UsuarioEnEdicion);
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            _presenter.LimpiarFiltros();
        }

        private void btnDesactivar_Click(object sender, EventArgs e)
        {
            if (DesignMode) return;
            if (dgvCuentas.ItemSeleccionado == null)
            {
                this.MostrarMensaje("debe seleccionar un usuario para desactivar");
                return;
            }
            _presenter.Activar((Usuario)this.dgvCuentas.ItemSeleccionado, false);
        }

        private void btnActivar_Click(object sender, EventArgs e)
        {
            if (DesignMode) return;
            if (dgvCuentas.ItemSeleccionado == null)
            {
                this.MostrarMensaje("debe seleccionar un usuario para activar");
                return;
            }
            _presenter.Activar((Usuario)this.dgvCuentas.ItemSeleccionado, true);
        }

        public void ReloadView()
        {
            this.dgvCuentas.Refresh();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            var frm = new FrmAltaDeCuentas();
            //frm.MdiParent = this;
            if (frm.ShowDialog() == DialogResult.OK)
            {
                _presenter.BuscarConFiltros();
            }
        }

        private void agregarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnAgregar.PerformClick();
        }

        private void desactivarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnDesactivar.PerformClick();
        }

        private void activarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnActivar.PerformClick();
        }

        private void cambiarContraseñaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnCambiarContraseña.PerformClick();
        }

        public bool MensajePregunta(string mensage)
        {
            return (MessageBox.Show(mensage, "Confirmar", System.Windows.Forms.MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes);
        }
    }
}
