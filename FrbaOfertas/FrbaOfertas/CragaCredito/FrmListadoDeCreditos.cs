using FrbaOfertasPresentacion.Creditos;
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

namespace FrbaOfertas.CragaCredito
{
    public partial class FrmListadoDeCreditos : Form, IVistaCreditos
    {
        private readonly PresentadorCreditos _presenter;

        public PresentadorCreditos Presentador { get { return _presenter; } }


        public FrmListadoDeCreditos()
        {
            InitializeComponent();
            _presenter = new PresentadorCreditos(this);
        }

        

        public List<Credito> Creditos 
        {
            get { return (List<Credito>)dgvCreditos.Items; }
            set
            {
                dgvCreditos.Items = value;
            }
        }

       
        public void MostrarMensaje(string message)
        {
            MessageBox.Show(message);
        }

        #region grilla

        private void dgvCreditos_SelectionChanged(object sender, System.EventArgs e)
        {
            if (DesignMode) return;
            //Presenter.CambioItemSeleccionado()
        }

        private void dgvCreditos_CambioChequeadosMultiplesItems(object sender, System.EventArgs e)
        {
            if (DesignMode) return;
        }

        private void dgvCreditos_CambioChequeadosUnItem(object sender, System.Windows.Forms.DataGridViewCellEventArgs e)
        {
            if (DesignMode) return;
        }

        private void dgvCreditos_CargarMenuContextual(object sender, EventArgs e)
        {

        }

        private void FrmRolesDelUsuario_Load(object sender, EventArgs e)
        {
            dgvCreditos.Refresh();
        }

        private void FrmRolesDelUsuario_Shown(object sender, EventArgs e)
        {
            dgvCreditos._parentForm_Shown(sender, e);
        }
        #endregion

        public bool MensajePregunta(string mensage)
        {
            return (MessageBox.Show(mensage, "Confirmar", System.Windows.Forms.MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            this.Close();
        }


        public List<Cliente> clientes
        {
            get
            {

                return (List<Cliente>)cboClientes.DataSource;
            }
            set
            {
                cboClientes.DisplayMember = "nombre";
                cboClientes.ValueMember = "Id_Cliente";
                cboClientes.DataSource = value;
            }
        }

        public Cliente ClienteSeleccionado
        {
            get
            {
                return (Cliente)cboClientes.SelectedItem;
            }
            set
            {
                cboClientes.SelectedItem = value;
            }
        }

        public List<TipoDePago> TiposDePago
        {
            get
            {
                return (List<TipoDePago>)cboClientes.DataSource;
            }
            set
            {
                cboTiposDePago.DisplayMember = "Nombre";
                cboTiposDePago.ValueMember = "Id";
                cboTiposDePago.DataSource = value;
            }
        }

        public TipoDePago TiposDePagoSeleccionado
        {
            get
            {
                return (TipoDePago)cboTiposDePago.SelectedItem;
            }
            set
            {
                cboTiposDePago.SelectedItem = value;
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

        public DateTime fechaHasta
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


        #endregion

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            Presentador.BuscarDatos(int.Parse(this.paginador.ObtenerItemsPorPagina()));
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Presentador.LimpiarDatos();
        }


        public void SetarTotalItemsEnGrill(int cantidadItems)
        {
            this.paginador.SetearCantidadDeItems(cantidadItems);
            this.paginador.SetearNumeroPagina(1);
        }

        private void FrmListadoDeCreditos_Load(object sender, EventArgs e)
        {

        }

        private void FrmListadoDeCreditos_Shown(object sender, EventArgs e)
        {
            dgvCreditos._parentForm_Shown(sender, e);
        }
    }
}
