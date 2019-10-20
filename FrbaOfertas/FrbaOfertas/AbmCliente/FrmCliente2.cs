using FrbaOfertasPresentacion.AbmCliente;
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
    public partial class FrmCliente2 : Form, IVistaClientes
    {
        private readonly PresentadorClientes _presenter;
        public FrmCliente2()
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
            _presenter.BuscarConFiltros();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void mniAgregar_Click(object sender, EventArgs e)
        {
            if (DesignMode) return;

            var frm = new FrmClienteEditar();
            if (frm.ShowDialog(this.MdiParent) == System.Windows.Forms.DialogResult.OK)
            {
                _presenter.ActualizarVista();
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            mniAgregar_Click(sender, e);
        }

        private void btnBuscarTodos_Click(object sender, EventArgs e)
        {
            _presenter.Buscar();
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
            this._presenter.ActualizarVista();
        }

        private void dgvClientes_CargarMenuContextual(object sender, EventArgs e)
        {

        }

        public void MostrarMensaje(string message)
        {
            MessageBox.Show(message);
        }
    }
}
