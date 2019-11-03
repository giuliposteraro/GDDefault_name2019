using FrbaOfertasPresentacion.ABMRol;
using Negocio.Entidades;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrbaOfertas.AbmRol
{
    public partial class ABMRoles : Form, IVistaABMRol
    {
        private readonly PresentadorABMRol _presenter;

        public PresentadorABMRol Presentador { get { return _presenter; } }


        public ABMRoles()
        {
            InitializeComponent();
            _presenter = new PresentadorABMRol(this);
        }

        public string NombrePagina
        {
            get { return this.Text; }
            set { this.Text = value;}
        }

        public string NombreBoton 
        {
            get { return btnAceptar.Text; }
            set { btnAceptar.Text = value; } 
        }

        public List<Negocio.Entidades.Funcionalidad> FuncionalidadesPosibles 
        {
            get { return (List<Funcionalidad>)dgvFuncionalidades.Items; }
            set
            {
                dgvFuncionalidades.Items = value;
            }
        }

        public string Nombre 
        { 
            get { return txtNombre.Text; }
            set {txtNombre.Text = value; } 
        }

        public List<Negocio.Entidades.Funcionalidad> FuncionalidadesSeleccionadas
        {
            get 
            {
                List<Negocio.Entidades.Funcionalidad> lista = new List<Negocio.Entidades.Funcionalidad>();
                IEnumerable chequeados = dgvFuncionalidades.ItemsChequeados;
                foreach(object c in chequeados)
                    lista.Add((Funcionalidad)c);
                return lista; 
            }
            set
            {
                dgvFuncionalidades.ItemsChequeados = value;
            }
        }

        public void BloquearParaELiminar()
        {
            dgvFuncionalidades.Enabled = false;
            txtNombre.Enabled = false;
        }

        public void MostrarMensaje(string message)
        {
            MessageBox.Show(message);
        }

        #region grilla

        private void dgvFuncionalidades_SelectionChanged(object sender, System.EventArgs e)
        {
            if (DesignMode) return;
            //Presenter.CambioItemSeleccionado()
        }

        private void dgvFuncionalidades_CambioChequeadosMultiplesItems(object sender, System.EventArgs e)
        {
            if (DesignMode) return;
        }

        private void dgvFuncionalidades_CambioChequeadosUnItem(object sender, System.Windows.Forms.DataGridViewCellEventArgs e)
        {
            if (DesignMode) return;
        }

        private void dgvFuncionalidades_CargarMenuContextual(object sender, EventArgs e)
        {

        }

        private void ABMRoles_Load(object sender, EventArgs e)
        {
            dgvFuncionalidades.Refresh();
        }

        private void ABMRoles_Shown(object sender, EventArgs e)
        {
            dgvFuncionalidades._parentForm_Shown(sender, e);
        }
        #endregion

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (Presentador.Aceptar())
            {
                DialogResult = DialogResult.OK;
                this.Close();
            }
            
        }

        public bool MensajePregunta(string mensage)
        {
            return (MessageBox.Show(mensage, "Confirmar", System.Windows.Forms.MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes);
        }
    }
}
