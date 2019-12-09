using FrbaOfertasPresentacion.AbmCliente;
using FrbaOfertasPresentacion.bases;
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

namespace FrbaOfertas.AbmCliente
{
    public partial class FrmCliente : Form, IVistaClientes
    {
        private readonly PresentadorClientes _presenter;
        public FrmCliente()
        {
            InitializeComponent();
            _presenter = new PresentadorClientes(this);
        }

        #region Implementation of IVistaClientes

        public String Nombre
        {
            get { return txtNombre.Text; }
            set { txtNombre.Text = value.ToString(); }
        }

        public String Apellido
        {
            get { return txtApellido.Text; }
            set { txtApellido.Text = value.ToString(); }
        }

        public List<Cliente> Clientes
        {
            get { return (List<Cliente>)dgvClientes.Items; }
            set { 
                dgvClientes.Items = value;
            }
        }


        #endregion

        private void FrmCliente_Load(object sender, EventArgs e)
        {
            _presenter.IniciarVista();
        }

        private void FrmCliente_Shown(object sender, EventArgs e)
        {
            dgvClientes._parentForm_Shown(sender, e);
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            _presenter.Buscar();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void mniAgregar_Click(object sender, EventArgs e)
        {
            
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            mniAgregar_Click(sender, e);
        }

        private void  dgvClientes_SelectionChanged(object sender , System.EventArgs e)
        {   
           if (DesignMode) return;
                //Presenter.CambioItemSeleccionado()
        }

        private void  dgvClientes_CambioChequeadosMultiplesItems(object sender , System.EventArgs e)
        {
            if (DesignMode) return;
        }

        private void  dgvClientes_CambioChequeadosUnItem( object sender , System.Windows.Forms.DataGridViewCellEventArgs e)
        {
            if (DesignMode) return;
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (DesignMode) return;

            var frm = new FrmClienteEditar();
            frm.Presentador.Posicionar(ModosDeEjecucion.Modificacion, this.ClienteSeleccionado);
            if (frm.ShowDialog(this.MdiParent) == System.Windows.Forms.DialogResult.OK)
            {
                _presenter.ActualizarVista();
            }
        }

        private void dgvClientes_CargarMenuContextual(object sender, EventArgs e)
        {

        }

        public void MostrarMensaje(string message)
        {
            MessageBox.Show(message);
        }

        public bool MensajePregunta(string mensage)
        {
            return (MessageBox.Show(mensage, "Confirmar", System.Windows.Forms.MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes);
        }


        public int DNI
        {
            get
            {
                if (txtDNI.Text == "") return 0;
                return int.Parse(txtDNI.Text); 
            }
            set
            {
                txtDNI.Text = value.ToString();
            }
        }

        public string email
        {
            get
            {
                return txtMail.Text;
            }
            set
            {
                txtMail.Text= value;
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            _presenter.Limpiar();
        }

        private void mniModificar_Click(object sender, EventArgs e)
        {
            btnModificar.PerformClick();
        }

        private void mniEliminar_Click(object sender, EventArgs e)
        {
            btnEliminar.PerformClick();
        }

        public Cliente ClienteSeleccionado 
        { 
            get
            {
                return (Cliente)dgvClientes.ItemSeleccionado;
            } 
            set
            {
                dgvClientes.ItemSeleccionado = value;
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (DesignMode) return;

            var frm = new FrmClienteEditar();
            frm.Presentador.Posicionar(ModosDeEjecucion.Baja, this.ClienteSeleccionado);
            if (frm.ShowDialog(this.MdiParent) == System.Windows.Forms.DialogResult.OK)
            {
                _presenter.ActualizarVista();
            }
        }
    }
}
