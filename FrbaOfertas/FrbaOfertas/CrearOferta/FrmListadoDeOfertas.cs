using FrbaOfertasPresentacion.PublicacionOfertas;
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

namespace FrbaOfertas.CrearOferta
{
    public partial class FrmListadoDeOfertas : Form, IVistaPublicacionDeOfertas
    {

        private readonly PresentadorPublicacionDeOfertas _presenter;

        public PresentadorPublicacionDeOfertas Presentador { get { return _presenter; } }

        public FrmListadoDeOfertas()
        {
            InitializeComponent();
            _presenter = new PresentadorPublicacionDeOfertas(this);
        }

        public bool MensajePregunta(string mensage)
        {
            return (MessageBox.Show(mensage, "Confirmar", System.Windows.Forms.MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes);
        }

        #region grilla

        private void dgvOfertas_SelectionChanged(object sender, System.EventArgs e)
        {
            if (DesignMode) return;
            //Presenter.CambioItemSeleccionado()
        }

        private void dgvOfertas_CambioChequeadosMultiplesItems(object sender, System.EventArgs e)
        {
            if (DesignMode) return;
        }

        private void dgvOfertas_CambioChequeadosUnItem(object sender, System.Windows.Forms.DataGridViewCellEventArgs e)
        {
            if (DesignMode) return;
        }

        private void dgvOfertas_CargarMenuContextual(object sender, EventArgs e)
        {

        }

        private void FrmListadoDeOfertas_Load(object sender, EventArgs e)
        {
            dgvOfertas.Refresh();
        }

        private void FrmListadoDeOfertas_Shown(object sender, EventArgs e)
        {
            dgvOfertas._parentForm_Shown(sender, e);
        }
        #endregion



        private void btnVerCompras_Click(object sender, EventArgs e)
        {

        }

        public void MostrarMensaje(string message)
        {
            MessageBox.Show(message);
        }

        #region paginador
        private void paginador_SeSeleccionaPaginaSiguiente(object sender, System.EventArgs e)
        {
            if (DesignMode) return;
            Presentador.ObtenerPaginado(int.Parse(this.paginador.ObtenerItemsPorPagina()), int.Parse(this.paginador.ObtenerPaginaActual()));

        }

        private void paginador_SolicitarBusqueda(object sender, System.EventArgs e)
        {
            if (DesignMode) return;
            Presentador.ObtenerPaginado(int.Parse(this.paginador.ObtenerItemsPorPagina()), int.Parse(this.paginador.ObtenerPaginaActual()));

        }

        private void paginador_SeSeleccionaUltimaPagina(object sender, System.EventArgs e)
        {
            if (DesignMode) return;
            Presentador.ObtenerPaginado(int.Parse(this.paginador.ObtenerItemsPorPagina()), int.Parse(this.paginador.ObtenerPaginaActual()));

        }
        private void paginador_SeSeleccionaPaginaAnterior(object sender, System.EventArgs e)
        {
            if (DesignMode) return;
            Presentador.ObtenerPaginado(int.Parse(this.paginador.ObtenerItemsPorPagina()), int.Parse(this.paginador.ObtenerPaginaActual()));

        }
        private void paginador_SeSeleccionaPrimeraPagina(object sender, System.EventArgs e)
        {
            if (DesignMode) return;
            Presentador.ObtenerPaginado(int.Parse(this.paginador.ObtenerItemsPorPagina()), int.Parse(this.paginador.ObtenerPaginaActual()));

        }

        public void SetarTotalItemsEnGrill(int cantidadItems)
        {
            this.paginador.SetearCantidadDeItems(cantidadItems);
            this.paginador.SetearNumeroPagina(1);
        }

        #endregion

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            Presentador.BuscarDatos(int.Parse(this.paginador.ObtenerItemsPorPagina()));
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Presentador.LimpiarDatos();
        }


        public Negocio.Entidades.Proveedor ProveedorSeleccionado
        {
            get
            {
                return (Proveedor)cboProveedor.SelectedItem;
            }
            set
            {
                cboProveedor.SelectedItem = value;
            }
        }

        public string Codigo
        {
            get
            {
                return txtCodigo.Text;
            }
            set
            {
                txtCodigo.Text = value;
            }
        }

        public DateTime FechaDesde
        {
            get
            {
                return dtpFechaDesde.Value;
            }
            set
            {
                dtpFechaDesde.Value = value;
            }
        }

        public DateTime FechaHasta
        {
            get
            {
                return dtpFechaHasta.Value;
            }
            set
            {
                dtpFechaHasta.Value = value;
            }
        }

        public List<Negocio.Entidades.Oferta> Ofertas
        {
            get { return (List<Oferta>)dgvOfertas.Items; }
            set
            {
                dgvOfertas.Items = value;
            }
        }


        public List<Proveedor> proveedores
        {
            get
            {

                return (List<Proveedor>)cboProveedor.DataSource;
            }
            set
            {
                cboProveedor.DisplayMember = "Razon_Social_Prov";
                cboProveedor.ValueMember = "Id_Proveedor";
                cboProveedor.DataSource = value;
            }
        }


        public void MostrarAlerta(bool p)
        {
            this.lblAlertaUsuario.Visible = p;
        }


        public void HabilitarCombo(bool p)
        {
            this.cboProveedor.Enabled = p;
        }


        public Oferta OfertaSeleccionada
        {
            get
            {
                return (Oferta)dgvOfertas.ItemSeleccionado;
            }
            set
            {
                dgvOfertas.ItemSeleccionado = value;
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (DesignMode) return;

            var frm = new FrmAltaOfertas();
            frm.Presentador.PosicionarAlta(this.ProveedorSeleccionado);
            if (frm.ShowDialog(this.MdiParent) == System.Windows.Forms.DialogResult.OK)
            {
                _presenter.BuscarDatos(int.Parse(this.paginador.ObtenerItemsPorPagina()));
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (this.OfertaSeleccionada == null)
            {
                MessageBox.Show("Debe seleccionar una oferta a modificar");
                return;
            }

            var frm = new FrmAltaOfertas();
            frm.Presentador.PosicionarModificar(this.OfertaSeleccionada);
            if (frm.ShowDialog(this.MdiParent) == System.Windows.Forms.DialogResult.OK)
            {
                _presenter.BuscarDatos(int.Parse(this.paginador.ObtenerItemsPorPagina()));
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (this.OfertaSeleccionada == null)
            {
                MessageBox.Show("Debe seleccionar una oferta a eliminar");
                return;
            }
            var frm = new FrmAltaOfertas();
            frm.Presentador.PosicionarBaja(this.OfertaSeleccionada);
            if (frm.ShowDialog(this.MdiParent) == System.Windows.Forms.DialogResult.OK)
            {
                _presenter.BuscarDatos(int.Parse(this.paginador.ObtenerItemsPorPagina()));
            }
        }

        private void publicarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.btnAgregar.PerformClick();
        }

        private void modificarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.btnModificar.PerformClick();
        }

        private void eliminarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.btnEliminar.PerformClick();
        }

        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
            if (this.OfertaSeleccionada == null)
            {
                MessageBox.Show("Debe seleccionar una oferta");
                return;
            }
            this.DialogResult = DialogResult.OK;
            this.Close();
        }


        public void MostrarBotonesSeleccion()
        {
            btnAgregar.Visible = false;
            btnModificar.Visible = false;
            btnEliminar.Visible = false;
            modificarToolStripMenuItem.Visible = false;
            eliminarToolStripMenuItem.Visible = false;
            publicarToolStripMenuItem.Visible = false;
            btnSeleccionar.Visible = true;
            dtpFechaHasta.Enabled = false;
            dtpVDesde.Enabled = false;
        }


        public DateTime FechaVDesde
        {
            get
            {
                return dtpVDesde.Value;
            }
            set
            {
                dtpVDesde.Value = value;
            }
        }

        public DateTime FechaVHasta
        {
            get
            {
                return dtpVHasta.Value;
            }
            set
            {
                dtpVHasta.Value = value;
            }
        }
    }
}
