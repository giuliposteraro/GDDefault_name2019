using FrbaOfertasPresentacion.AbmCliente;
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
            get { return btnAceptar.Text; }
            set { btnAceptar.Text = value.ToString(); }
        }

        #endregion

        private void FrmCliente_Load(object sender, EventArgs e)
        {
            _presenter.IniciarVista();
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

 
    }
}
