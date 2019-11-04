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
    public partial class FrmListadoDeCreditos : Form, IVistaCreditos
    {
        private readonly PresentadorCreditos _presenter;

        public PresentadorCreditos Presentador { get { return _presenter; } }


        public FrmListadoDeCreditos()
        {
            InitializeComponent();
            _presenter = new PresentadorCreditos(this);
        }

        

        public List<Credito> Creditos 
        {
            get { return (List<Credito>)dgvCreditos.Items; }
            set
            {
                dgvCreditos.Items = value;
            }
        }

        public string Nombre 
        { 
            get { return txtNombre.Text; }
            set {txtNombre.Text = value; } 
        }

        public void MostrarMensaje(string message)
        {
            MessageBox.Show(message);
        }

        #region grilla

        private void dgvCreditos_SelectionChanged(object sender, System.EventArgs e)
        {
            if (DesignMode) return;
            //Presenter.CambioItemSeleccionado()
        }

        private void dgvCreditos_CambioChequeadosMultiplesItems(object sender, System.EventArgs e)
        {
            if (DesignMode) return;
        }

        private void dgvCreditos_CambioChequeadosUnItem(object sender, System.Windows.Forms.DataGridViewCellEventArgs e)
        {
            if (DesignMode) return;
        }

        private void dgvCreditos_CargarMenuContextual(object sender, EventArgs e)
        {

        }

        private void FrmRolesDelUsuario_Load(object sender, EventArgs e)
        {
            dgvCreditos.Refresh();
        }

        private void FrmRolesDelUsuario_Shown(object sender, EventArgs e)
        {
            dgvCreditos._parentForm_Shown(sender, e);
        }
        #endregion

        public bool MensajePregunta(string mensage)
        {
            return (MessageBox.Show(mensage, "Confirmar", System.Windows.Forms.MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes);
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
