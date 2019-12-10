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

namespace FrbaOfertas.AbmProveedor
{
    public partial class Form1 : Form, IVistaProveedor
    {
        private readonly PresentadorProveedor _presenter;
        public Form1()
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
            this.Close();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (DesignMode) return;

            var frm = new detalleProveedor();
            if (frm.ShowDialog(this.MdiParent) == System.Windows.Forms.DialogResult.OK)
            {
                _presenter.ActualizarVista();
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            this._presenter.ActualizarVista();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {

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
                throw new NotImplementedException();
            }
            set
            {
                throw new NotImplementedException();
            }
        }

        public string Razon_Social
        {
            get
            {
                throw new NotImplementedException();
            }
            set
            {
                throw new NotImplementedException();
            }
        }

        public string Cuit
        {
            get
            {
                throw new NotImplementedException();
            }
            set
            {
                throw new NotImplementedException();
            }
        }

        public string Mail
        {
            get
            {
                throw new NotImplementedException();
            }
            set
            {
                throw new NotImplementedException();
            }
        }

        public List<Negocio.Entidades.Proveedor> Proveedores
        {
            get
            {
                throw new NotImplementedException();
            }
            set
            {
                throw new NotImplementedException();
            }
        }

        public void MostrarMensaje(string message)
        {
            throw new NotImplementedException();
        }

        public bool MensajePregunta(string mensage)
        {
            throw new NotImplementedException();
        }
    }
}
