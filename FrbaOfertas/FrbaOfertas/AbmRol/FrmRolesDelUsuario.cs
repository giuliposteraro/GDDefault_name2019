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
    public partial class FrmRolesDelUsuario : Form, IVistaRolesCta
    {
        private readonly PresentadorRolesCta _presenter;

        public PresentadorRolesCta Presentador { get { return _presenter; } }


        public FrmRolesDelUsuario()
        {
            InitializeComponent();
            _presenter = new PresentadorRolesCta(this);
        }

        

        public List<Negocio.Entidades.Rol> RolesPosibles 
        {
            get { return (List<Rol>)dgvRoles.Items; }
            set
            {
                dgvRoles.Items = value;
            }
        }

        public string Nombre 
        { 
            get { return txtNombre.Text; }
            set {txtNombre.Text = value; } 
        }

        public List<Negocio.Entidades.Rol> RolesSelccionados
        {
            get 
            {
                List<Negocio.Entidades.Rol> lista = new List<Negocio.Entidades.Rol>();
                IEnumerable chequeados = dgvRoles.ItemsChequeados;
                foreach(object c in chequeados)
                    lista.Add((Rol)c);
                return lista; 
            }
            set
            {
                dgvRoles.ItemsChequeados = value;
            }
        }

        public void MostrarMensaje(string message)
        {
            MessageBox.Show(message);
        }

        #region grilla

        private void dgvRoles_SelectionChanged(object sender, System.EventArgs e)
        {
            if (DesignMode) return;
            //Presenter.CambioItemSeleccionado()
        }

        private void dgvRoles_CambioChequeadosMultiplesItems(object sender, System.EventArgs e)
        {
            if (DesignMode) return;
        }

        private void dgvRoles_CambioChequeadosUnItem(object sender, System.Windows.Forms.DataGridViewCellEventArgs e)
        {
            if (DesignMode) return;
        }

        private void dgvRoles_CargarMenuContextual(object sender, EventArgs e)
        {

        }

        private void FrmRolesDelUsuario_Load(object sender, EventArgs e)
        {
            dgvRoles.Refresh();
        }

        private void FrmRolesDelUsuario_Shown(object sender, EventArgs e)
        {
            dgvRoles._parentForm_Shown(sender, e);
        }
        #endregion

        public bool MensajePregunta(string mensage)
        {
            return (MessageBox.Show(mensage, "Confirmar", System.Windows.Forms.MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes);
        }

        private void btnAceptar_Click_1(object sender, EventArgs e)
        {
            if (Presentador.Aceptar())
            {
                DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
