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
    public partial class FrmEntregarOferta : Form, IVistaEntregaOferta
    {
        private readonly PresentadorEntregaOferta _presenter;
        public PresentadorEntregaOferta Presentador { get { return _presenter; } }

        public FrmEntregarOferta()
        {
            InitializeComponent();
            _presenter = new PresentadorEntregaOferta(this);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        public void MostrarMensaje(string message)
        {
            MessageBox.Show(message);
        }

        public bool MensajePregunta(string mensage)
        {
            return (MessageBox.Show(mensage, "Confirmar", System.Windows.Forms.MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes);
        }

        public List<Negocio.Entidades.Cliente> Clientes
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

        public void MostrarAlerta(bool p)
        {
            this.lblAlertaUsuario.Visible = p;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (!(Presentador.ValidarGuardar()))
                return;

            if (this.Presentador.Guardar())
            {
                this.Presentador.Limpiar();
            }
        }


        public Negocio.Entidades.Cliente ClienteSeleccionado
        {
            get
            {
                return (Negocio.Entidades.Cliente)cboClientes.SelectedItem;
            }
            set
            {
                cboClientes.SelectedItem = value;
            }
        }

        public DateTime Fecha
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

        public string Codigo
        {
            get
            {
                return txtCupon.Text;
            }
            set
            {
                txtCupon.Text = value;
            }
        }
    }
}
