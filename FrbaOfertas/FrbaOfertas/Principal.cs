using FrbaOfertas.AbmCliente;
using FrbaOfertas.LogIn;
using Negocio.Base;
using Negocio.Entidades;
using Negocio.Gestores;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrbaOfertas
{
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
        }

        private void mnuClientes_Click(object sender, EventArgs e)
        {
            if (DesignMode) return;

            var frm = new FrmCliente();
            frm.MdiParent = this;
            frm.Show();
 
        }


        private void Principal_Load(object sender, EventArgs e)
        {
            var frm = new FrmInicioDeSession();
            //frm.MdiParent = this;
            if (frm.ShowDialog() == DialogResult.Cancel)
            {
                this.Close();
            }
            else
            {
                this.OcultarMenu();
            }
        }

        private void OcultarMenu()
        {
            //voy a verificar si el usuario tiene 
            GestorDeValidacionDePermisos gestor = new GestorDeValidacionDePermisos();
            clientes2ToolStripMenuItem.Visible = gestor.TienePermisoPara(Funcionalidad.ABMdeCliente);
            cuentasToolStripMenuItem.Visible = gestor.TienePermisoPara(Funcionalidad.RegistroDeUsuarios);
        }

        private void clientes2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (DesignMode) return;

            var frm = new FrmCliente2();
            frm.MdiParent = this;
            frm.Show();
        }

        private void cuentasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (DesignMode) return;

            var frm = new FrmListadoDeCuentas();
            frm.MdiParent = this;
            frm.Show();
        }

        private void aCercaDeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Gestión de datos 2C 2019 - DEFAULT_NAME");
        }

        private void cambiarContraseñaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (DesignMode) return;

            var frm = new FrmCambiarContraseña();
            frm.Presentador.Posicionar(Global.SessionUsuario);
            frm.MdiParent = this;
            frm.Show();
        }
    }
}
