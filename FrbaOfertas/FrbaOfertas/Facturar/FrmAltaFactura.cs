using FrbaOfertasPresentacion.Facturacion;
using Negocio.Entidades;
using System;
using System.Collections;
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
    public partial class FrmAltaFactura : Form, IVistaAltaFactura
    {

        private readonly PresentadorAltaFactura _presenter;

        public PresentadorAltaFactura Presentador { get { return _presenter; } }

        public FrmAltaFactura()
        {
            InitializeComponent();
            _presenter = new PresentadorAltaFactura(this);
        }

        public void MostrarMensaje(string message)
        {
            MessageBox.Show(message);
        }

        public bool MensajePregunta(string mensage)
        {
            return (MessageBox.Show(mensage, "Confirmar", System.Windows.Forms.MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes);
        }


        #region grilla

        private void dgvDisponibles_SelectionChanged(object sender, System.EventArgs e)
        {
            if (DesignMode) return;
            //Presenter.CambioItemSeleccionado()
        }

        private void dgvDisponibles_CambioChequeadosMultiplesItems(object sender, System.EventArgs e)
        {
            if (DesignMode) return;
        }

        private void dgvDisponibles_CambioChequeadosUnItem(object sender, System.Windows.Forms.DataGridViewCellEventArgs e)
        {
            if (DesignMode) return;
        }

        private void dgvDisponibles_CargarMenuContextual(object sender, EventArgs e)
        {

        }

        private void FrmAltaFactura_Load(object sender, EventArgs e)
        {
            dgvDisponibles.Refresh();

        }

        private void FrmAltaFactura_Shown(object sender, EventArgs e)
        {
            dgvDisponibles._parentForm_Shown(sender, e);

        }
        #endregion

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            Presentador.BuscarDatos();
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

        public DateTime FechaFactura
        {
            get
            {
                return dtpFechaFactura.Value;
            }
            set
            {
                dtpFechaFactura.Value = value;
            }
        }


        public Proveedor ProveedorSeleccionado
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

        public List<Compra> Disponibles
        {
            get
            {
                return (List<Negocio.Entidades.Compra>)dgvDisponibles.Items;
            }
            set
            {
                dgvDisponibles.Items = value;
            }
        }

        public decimal Total
        {
            get
            {
                return decimal.Parse(txtMontoTotal.Text);
            }
            set
            {
                txtMontoTotal.Text = value.ToString();
            }
        }

        private void cboProveedor_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (DesignMode) return;
            Presentador.CambioFiltros();
        }

        private void dtpFechaDesde_ValueChanged(object sender, EventArgs e)
        {
            if (DesignMode) return;
            Presentador.CambioFiltros();
        }

        private void dtpFechaHasta_ValueChanged(object sender, EventArgs e)
        {
            if (DesignMode) return;
            Presentador.CambioFiltros();
        }

        private void btnComponer_Click(object sender, EventArgs e)
        {
            if (!(Presentador.ValidarGuardar()))
                return;

            if (this.Presentador.Guardar())
            {
                this.DialogResult = DialogResult.OK;
                this.Close();
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
    }
}
