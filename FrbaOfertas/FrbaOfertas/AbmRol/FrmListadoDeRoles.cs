using FrbaOfertasPresentacion.ABMRol;
using FrbaOfertasPresentacion.bases;
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

namespace FrbaOfertas.AbmRol
{
    public partial class FrmListadoDeRoles : Form, IVistaListaDeRoles
    {
        private readonly PresentadorListaDeRoles _presenter;

        public PresentadorListaDeRoles Presentador { get { return _presenter; } }

        public FrmListadoDeRoles()
        {
            InitializeComponent();
            _presenter = new PresentadorListaDeRoles(this);
        }

        #region Implementation of IVistaListadoCuentas

        public string Nombre
        {
            get { return txtNombre.Text; }
            set { txtNombre.Text = value.ToString(); }
        }


        public List<Rol> Roles
        {
            get { return (List<Rol>)dgvRoles.Items; }
            set
            {
                dgvRoles.Items = value;
            }
        }


        #endregion


        #region grilla

        private void dgvRoles_SelectionChanged(object sender, System.EventArgs e)
        {
            if (DesignMode) return;
            //Presenter.CambioItemSeleccionado()
        }

        private void dgvRoles_CambioChequeadosMultiplesItems(object sender, System.EventArgs e)
        {
            if (DesignMode) return;
        }

        private void dgvRoles_CambioChequeadosUnItem(object sender, System.Windows.Forms.DataGridViewCellEventArgs e)
        {
            if (DesignMode) return;
        }

        private void dgvRoles_CargarMenuContextual(object sender, EventArgs e)
        {

        }

        private void FrmListadoDeRoles_Load(object sender, EventArgs e)
        {
            _presenter.IniciarVista();
        }

        private void FrmListadoDeRoles_Shown(object sender, EventArgs e)
        {
            dgvRoles._parentForm_Shown(sender, e);
        }
        #endregion

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            _presenter.LimpiarFiltros();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            _presenter.BuscarConFiltros();
        }

        public void MostrarMensaje(string message)
        {
            MessageBox.Show(message);
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (DesignMode) return;

            var frm = new ABMRoles();
            frm.Presentador.Posicionar(ModosDeEjecucion.Alta);
            if (frm.ShowDialog(this.MdiParent) == System.Windows.Forms.DialogResult.OK)
            {
                _presenter.ActualizarGrilla(frm.Presentador.RolEnEdicion);
            }
        }

        private void agregarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnAgregar.PerformClick();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (DesignMode) return;
            if (dgvRoles.ItemSeleccionado == null)
            {
                this.MostrarMensaje("debe seleccionar un rol a modificar");
                return;
            }

            var frm = new ABMRoles();
            frm.Presentador.Posicionar((Rol)dgvRoles.ItemSeleccionado, ModosDeEjecucion.Modificacion);
            if (frm.ShowDialog(this.MdiParent) == System.Windows.Forms.DialogResult.OK)
            {
                _presenter.ActualizarGrilla(frm.Presentador.RolEnEdicion);
                ((Principal)this.MdiParent).OcultarMenu();
            }
        }

        private void modificarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnModificar.PerformClick();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (DesignMode) return;
            if (dgvRoles.ItemSeleccionado == null)
            {
                this.MostrarMensaje("debe seleccionar un rol a eliminar");
                return;
            }

            var frm = new ABMRoles();
            frm.Presentador.Posicionar((Rol)dgvRoles.ItemSeleccionado, ModosDeEjecucion.Baja);
            if (frm.ShowDialog(this.MdiParent) == System.Windows.Forms.DialogResult.OK)
            {
                _presenter.ActualizarGrilla(frm.Presentador.RolEnEdicion);
                ((Principal)this.MdiParent).OcultarMenu();
            }
        }

        private void eliminarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnEliminar.PerformClick();
        }

        public bool MensajePregunta(string mensage)
        {
            return (MessageBox.Show(mensage, "Confirmar", System.Windows.Forms.MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes);
        }

        private void reHabilitarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnRehabilitar.PerformClick();
        }

        private void btnRehabilitar_Click(object sender, EventArgs e)
        {
            if (DesignMode) return;
            if (dgvRoles.ItemSeleccionado == null)
            {
                this.MostrarMensaje("debe seleccionar un rol a re habilitar");
                return;
            }
            Presentador.ReHabilitarRol((Rol)dgvRoles.ItemSeleccionado);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            this.Close();
        }

    }
}
