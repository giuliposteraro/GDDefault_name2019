using FrbaOfertas.CrearOferta;
using FrbaOfertasPresentacion.CompraOfertas;
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
using Negocio.Base;

namespace FrbaOfertas.ComprarOferta
{
    public partial class FrmCompraDeOfertas : Form, IVistaCompraOferta
    {
        /*private Credito Credito;
        private Oferta oferta;
        private float precio;
        private int id_compra;
        private int cant_ofertas;

        public FrmCompraDeOfertas(Credito credito, float precio, Oferta oferta)
        {
            if(credito < precio) throw new Exception("El usuario no posee credito suficiente");
            this.oferta = oferta;
            this.Credito - precio;
            InitializeComponent();
        }*/
        private readonly PresentadorCompraOferta _presenter;
        public PresentadorCompraOferta Presentador { get { return _presenter; } }

        public FrmCompraDeOfertas()
        {
            InitializeComponent();
            _presenter = new PresentadorCompraOferta(this);
        }

        #region implementacion de la vista
        public Cliente Cliente { get; set; }

        public string NombreCliente
        {
            get { return txtNombreCliente.Text; }
            set { txtNombreCliente.Text = value; }
        }
        #endregion


        public void MostrarMensaje(string message)
        {
            MessageBox.Show(message);
        }

        public bool MensajePregunta(string mensage)
        {
            return (MessageBox.Show(mensage, "Confirmar", System.Windows.Forms.MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnComprar_Click(object sender, EventArgs e)
        {
            if (!(Presentador.ValidarGuardar()))
                return;

            if (this.Presentador.Guardar())
            {
                this.Presentador.Limpiar();
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (DesignMode) return;

            var frm = new FrmListadoDeOfertas();
            frm.Presentador.PosicionarParaSeleccion();
            if (frm.ShowDialog(this.MdiParent) == System.Windows.Forms.DialogResult.OK)
            {
                _presenter.ActualizarVista(frm.OfertaSeleccionada);
            }
        }

        public void MostrarAlerta(bool mostrarAlerta){
            lblAlertaUsuario.Visible = mostrarAlerta;
        }

        private Oferta _oferta;
        public Oferta Oferta 
        {
            get
            {
                return _oferta;
            }
            set
            {
                _oferta = value;
                if (value != null)
                    txtOferta.Text = _oferta.ToString();
                else
                    txtOferta.Text = "";
            }
        }


        public decimal Credito
        {
            get
            {
                if ((txtCredito.Text).EsNuloOVacio()) return 0;
                return decimal.Parse(txtCredito.Text);
            }
            set
            {
                txtCredito.Text = value.ToString();
            }
        }

        public DateTime fecha
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

        public string Descripcion
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

        public string Codigo
        {
            get
            {
                return txtNumero.Text;
            }
            set
            {
                txtNumero.Text = value;
            }
        }

        public int Stock
        {
            get
            {
                return int.Parse(txtStock.Text);
            }
            set
            {
                txtStock.Text = value.ToString();
            }
        }

        public int Maximo
        {
            get
            {
                return int.Parse(txtMaximo.Text);
            }
            set
            {
                txtMaximo.Text = value.ToString();
            }
        }

        public decimal Plista
        {
            get
            {
                return decimal.Parse(txtLista.Text);
            }
            set
            {
                txtLista.Text = value.ToString();
            }
        }

        public decimal POferta
        {
            get
            {
                return decimal.Parse(txtPoferta.Text);
            }
            set
            {
                txtPoferta.Text = value.ToString();
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }


        public int Cantidad
        {
            get
            {
                return (int)nmCantidad.Value;
            }
            set
            {
                nmCantidad.Value = value;
            }
        }
    }
}
