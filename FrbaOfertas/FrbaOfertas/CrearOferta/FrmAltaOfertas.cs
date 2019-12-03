using FrbaOfertasPresentacion.CompraOfertas;
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
    public partial class FrmAltaOfertas : Form, IVistaAltaOferta
    {
        private readonly PresentadorAltaOferta _presenter;

        public PresentadorAltaOferta Presentador { get { return _presenter; } }

        public FrmAltaOfertas()
        {
            InitializeComponent();
            _presenter = new PresentadorAltaOferta(this);
        }

        public void MostrarMensaje(string message)
        {
            MessageBox.Show(message);
        }

        public bool MensajePregunta(string mensage)
        {
            return (MessageBox.Show(mensage, "Confirmar", System.Windows.Forms.MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes);
        }

        public string Titulo
        {
            get
            {
                return this.Text;
            }
            set
            {
                this.Text = value;
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (!(Presentador.ValidarGuardar()))
                return;

            if (this.Presentador.Guardar())
            {
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            this.Close();
        }


        public List<Negocio.Entidades.Proveedor> proveedores
        {
            get
            {

                return (List<Negocio.Entidades.Proveedor>)cboProveedor.DataSource;
            }
            set
            {
                cboProveedor.DisplayMember = "Razon_Social_Prov";
                cboProveedor.ValueMember = "Id_Proveedor";
                cboProveedor.DataSource = value;
            }
        }

        public void BloquearDatos()
        {
            this.cboProveedor.Enabled = false;
            this.txtCodigo.Enabled = false;
            this.dtpFechaPublicacion.Enabled = false;
            this.gtpFechaVencimiento.Enabled = false;
            this.txtDescripcion.Enabled = false;
            this.nmDisponible.Enabled = false;
            this.nmPrecioOferta.Enabled = false;
            this.mnMaximo.Enabled = false;
            this.mnPrecioLista.Enabled = false;
        }

        public void HabilitarCombo(bool p)
        {
            this.cboProveedor.Enabled = p;
        }

        public Negocio.Entidades.Proveedor proveedorSeleccionado
        {
            get
            {
                return (Negocio.Entidades.Proveedor)cboProveedor.SelectedItem;
            }
            set
            {
                cboProveedor.SelectedItem = value;
            }
        }

        public string codigo
        {
            get
            {
                return this.txtCodigo.Text;
            }
            set
            {
                this.txtCodigo.Text = value;
            }
        }

        public DateTime fechaPublicacion
        {
            get
            {
                return this.dtpFechaPublicacion.Value;
            }
            set
            {
                this.dtpFechaPublicacion.Value = value;
            }
        }

        public DateTime fechaVencimiento
        {
            get
            {
                return this.gtpFechaVencimiento.Value;
            }
            set
            {
                this.gtpFechaVencimiento.Value = value;
            }
        }

        public string descripcion
        {
            get
            {
                return this.txtDescripcion.Text;
            }
            set
            {
                this.txtDescripcion.Text = value;
            }
        }

        public decimal precioOferta
        {
            get
            {
                return  this.nmPrecioOferta.Value;
            }
            set
            {
                this.nmPrecioOferta.Value = value;
            }
        }

        public decimal precioLista
        {
            get
            {
                return mnPrecioLista.Value;
            }
            set
            {
                mnPrecioLista.Value = value;
            }
        }

        public int cantidadDisponible
        {
            get
            {
                return (int)nmDisponible.Value;
            }
            set
            {
                nmDisponible.Value = value;
            }
        }

        public int cantidadMaxima
        {
            get
            {
                return (int)mnMaximo.Value;
            }
            set
            {
                mnMaximo.Value = value;
            }
        }
    }
}
