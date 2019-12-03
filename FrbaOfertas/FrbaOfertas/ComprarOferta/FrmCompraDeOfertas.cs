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

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (DesignMode) return;

            var frm = new FrmListadoDeOfertas();
            frm.Presentador.PosicionarParaSeleccion();
            if (frm.ShowDialog(this.MdiParent) == System.Windows.Forms.DialogResult.OK)
            {
                this.Oferta = frm.OfertaSeleccionada;
                //_presenter.ActualizarVista();
            }
        }

        public void MostrarAlerta(bool mostrarAlerta){
            lblAlertaUsuario.Visible = mostrarAlerta;
        }

        public Oferta Oferta { get; set; }
    }
}
