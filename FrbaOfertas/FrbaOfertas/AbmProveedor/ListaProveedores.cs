using System;
using FrbaOfertasPresentacion.AbmProveedor;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FrbaOfertasPresentacion.bases;
using Negocio.Entidades;
using FrbaOfertas.LogIn;

namespace FrbaOfertas.AbmProveedor
{
    public partial class ListaProveedores : Form, IVistaProveedor
    {
        private readonly PresentadorProveedor _presenter;
        public ListaProveedores()
        {
            InitializeComponent();
            _presenter = new PresentadorProveedor(this);
        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textCuit_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void dgvRoles_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            _presenter.IniciarVista();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            _presenter.Buscar();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            _presenter.LimpiarDatos();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (DesignMode) return;

            var frm = new detalleProveedor();
            frm.Presentador.Posicionar(ModosDeEjecucion.Alta, null);
            if (frm.ShowDialog(this.MdiParent) == System.Windows.Forms.DialogResult.OK)
            {
                _presenter.Buscar();
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (DesignMode) return;

            var frm = new detalleProveedor();
            frm.Presentador.Posicionar(ModosDeEjecucion.Modificacion, this.ProveedorSeleccionado);
            if (frm.ShowDialog(this.MdiParent) == System.Windows.Forms.DialogResult.OK)
            {
                _presenter.Buscar();
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (DesignMode) return;

            var frm = new detalleProveedor();
            frm.Presentador.Posicionar(ModosDeEjecucion.Baja, this.ProveedorSeleccionado);
            if (frm.ShowDialog(this.MdiParent) == System.Windows.Forms.DialogResult.OK)
            {
                _presenter.Buscar();
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Label4_Click(object sender, EventArgs e)
        {

        }

        public string Nombre
        {
            get
            {
                return textNombreContacto.Text;
            }
            set
            {
                textNombreContacto.Text = value;
            }
        }

        public string Razon_Social
        {
            get
            {
                return txtRazonSocial.Text;
            }
            set
            {
                txtRazonSocial.Text = value;
            }
        }

        public string Cuit
        {
            get
            {
                return textCuit.Text;
            }
            set
            {
                textCuit.Text = value;
            }
        }

        public string Mail
        {
            get
            {
                return textMail.Text;
            }
            set
            {
                textMail.Text = value;
            }
        }

        public List<Negocio.Entidades.Proveedor> Proveedores
        {
            get { return (List<Negocio.Entidades.Proveedor>)dgvProveedores.Items; }
            set
            {
                dgvProveedores.Items = value;
            }
        }

        private void dgvProveedores_SelectionChanged(object sender, System.EventArgs e)
        {
            if (DesignMode) return;
            //Presenter.CambioItemSeleccionado()
        }

        private void dgvProveedores_CambioChequeadosMultiplesItems(object sender, System.EventArgs e)
        {
            if (DesignMode) return;
        }

        private void dgvProveedores_CambioChequeadosUnItem(object sender, System.Windows.Forms.DataGridViewCellEventArgs e)
        {
            if (DesignMode) return;
        }

        private void dgvProveedores_CargarMenuContextual(object sender, EventArgs e)
        {

        }

        private void ListaProveedores_Load(object sender, EventArgs e)
        {
            _presenter.IniciarVista();
        }

        private void ListaProveedores_Shown(object sender, EventArgs e)
        {
            dgvProveedores._parentForm_Shown(sender, e);
        }

        public void MostrarMensaje(string message)
        {
            MessageBox.Show(message);
        }

        public bool MensajePregunta(string mensage)
        {
            return (MessageBox.Show(mensage, "Confirmar", System.Windows.Forms.MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes);
        }

        public Proveedor ProveedorSeleccionado 
        {
            get
            {
                return (Proveedor)dgvProveedores.ItemSeleccionado;
            }
            set
            {
                dgvProveedores.ItemSeleccionado = value;
            }
        }

        private void btnActivar_Click(object sender, EventArgs e)
        {
            if (_presenter.Activar())
                _presenter.Buscar();
        }

        private void btnAsociarCta_Click(object sender, EventArgs e)
        {
            if (DesignMode) return;

            if (ProveedorSeleccionado == null)
            {
                this.MostrarMensaje("debe seleccionar un proveedor para asociarle una cuenta");
                return;
            }

            var frm = new frmSeleccionarCuenta();
            if (frm.ShowDialog(this.MdiParent) == System.Windows.Forms.DialogResult.OK)
            {
                _presenter.AsociarUsuario(frm.UsuarioSeleccionado, this.ProveedorSeleccionado);
            }
        }


        
    }
}
