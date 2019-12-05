using FrbaOfertasPresentacion.Facturacion;
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

namespace FrbaOfertas.Facturar
{
    public partial class FrmListadoDeFacturas : Form, IVistaListaFacturas
    {

        private readonly PresentadorListaFacturas _presenter;

        public PresentadorListaFacturas Presentador { get { return _presenter; } }

        public FrmListadoDeFacturas()
        {
            InitializeComponent();
            _presenter = new PresentadorListaFacturas(this);
        }


        public bool MensajePregunta(string mensage)
        {
            return (MessageBox.Show(mensage, "Confirmar", System.Windows.Forms.MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes);
        }

        public void MostrarMensaje(string message)
        {
            MessageBox.Show(message);
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            Presentador.BuscarDatos(int.Parse(this.paginador.ObtenerItemsPorPagina()));
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Presentador.LimpiarDatos();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void btnComponer_Click(object sender, EventArgs e)
        {
            if (DesignMode) return;

            var frm = new FrmAltaFactura();
            frm.Presentador.Posicionar(this.ProveedorSeleccionado);
            if (frm.ShowDialog(this.MdiParent) == System.Windows.Forms.DialogResult.OK)
            {
                _presenter.BuscarDatos(int.Parse(this.paginador.ObtenerItemsPorPagina()));
            }
        }

        #region grilla

        private void dgvFacturas_SelectionChanged(object sender, System.EventArgs e)
        {
            if (DesignMode) return;
            //Presenter.CambioItemSeleccionado()
        }

        private void dgvFacturas_CambioChequeadosMultiplesItems(object sender, System.EventArgs e)
        {
            if (DesignMode) return;
        }

        private void dgvFacturas_CambioChequeadosUnItem(object sender, System.Windows.Forms.DataGridViewCellEventArgs e)
        {
            if (DesignMode) return;
        }

        private void dgvFacturas_CargarMenuContextual(object sender, EventArgs e)
        {

        }

        private void FrmListadoDeFacturas_Load(object sender, EventArgs e)
        {
            dgvFacturas.Refresh();
        }

        private void FrmListadoDeFacturas_Shown(object sender, EventArgs e)
        {
            dgvFacturas._parentForm_Shown(sender, e);
        }
        #endregion

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

        public string Numero
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

        public List<Negocio.Entidades.Factura> Facturas
        {
            get
            {
                return (List<Negocio.Entidades.Factura>)dgvFacturas.Items;
            }
            set
            {
                dgvFacturas.Items = value;
            }
        }


        public List<Negocio.Entidades.Proveedor> proveedores
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
    }
}
