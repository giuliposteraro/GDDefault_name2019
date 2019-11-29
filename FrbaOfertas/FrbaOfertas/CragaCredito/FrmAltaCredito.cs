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
    public partial class FrmAltaCredito : Form, IVistaAltaCredito
    {

        private readonly PresentadorAltaCredito _presenter;
        public PresentadorAltaCredito Presentador { get { return _presenter; } }

        public FrmAltaCredito()
        {
            InitializeComponent();
            _presenter = new PresentadorAltaCredito(this);
        }

        private void btnHistorico_Click(object sender, EventArgs e)
        {
            if (DesignMode) return;
            if (!_presenter.ValidarVerHistorico())
                return;

            var frm = new FrmListadoDeCreditos();
            frm.Presentador.Posicionar(ClienteSeleccionado);
            frm.Show();
        }

        public int ClienteSeleccionado { get; set; }

        public void MostrarAlerta(bool mostrarAlerta)
        {
            lblAlertaUsuario.Visible = mostrarAlerta;
        }

        public List<Cliente> Clientes
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

        Cliente IVistaAltaCredito.ClienteSeleccionado
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

        public void MostrarMensaje(string message)
        {
            MessageBox.Show(message);
        }

        public bool MensajePregunta(string mensage)
        {
            return (MessageBox.Show(mensage, "Confirmar", System.Windows.Forms.MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes);
        }


        public DateTime FechaDelDia
        {
            get
            {
                return dtpFecha.Value;
            }
            set
            {
                dtpFecha.Value = value;
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if(!this.Presentador.ValidarGuardar())
                return;
            this.Presentador.Guardar();
        }

        private void txtMonto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtTarjeta_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private Cliente _cliente;
        public Cliente Cliente
        {
            get
            {
                return _cliente;
            }
            set
            {
                _cliente = value;
            }
        }


        public bool HabilitarCombo
        {
            set
            {
                cboClientes.Enabled = value;
            }
        }

        public string Monto
        {
            get
            {
                return txtMonto.Text;
            }
            set
            {
                txtMonto.Text = value;
            }
        }

        public string Tarjeta
        {
            get
            {
                return txtTarjeta.Text;
            }
            set
            {
                txtTarjeta.Text = value;
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

        private void cboClientes_SelectedIndexChanged(object sender, EventArgs e)
        {
            Presentador.DefinirCreditoActual();
        }


        public string TotalCreditoCliente
        {
            get
            {
                return txtMontoCreditoTotal.Text;
            }
            set
            {
                txtMontoCreditoTotal.Text = value;
            }
        }


        public string Detalle
        {
            get
            {
                return txtDescripcion.Text;
            }
            set
            {
                txtDescripcion.Text = value;
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
    }
}
