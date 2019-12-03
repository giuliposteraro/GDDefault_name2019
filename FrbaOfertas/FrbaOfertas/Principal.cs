using FrbaOfertas.AbmCliente;
using FrbaOfertas.AbmRol;
using FrbaOfertas.ComprarOferta;
using FrbaOfertas.CragaCredito;
using FrbaOfertas.CrearOferta;
using FrbaOfertas.Facturar;
using FrbaOfertas.ListadoEstadistico;
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

        private void mnuRoles_Click(object sender, EventArgs e)
        {
            if (DesignMode) return;

            var frm = new FrmListadoDeRoles();
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

        public void OcultarMenu()
        {
            //voy a verificar si el usuario tiene 
            GestorDeValidacionDePermisos gestor = new GestorDeValidacionDePermisos();
            mnuRoles.Visible = gestor.TienePermisoPara(Funcionalidad.ABMdeRol);
            clientesToolStripMenuItem.Visible = gestor.TienePermisoPara(Funcionalidad.ABMdeCliente);
            cuentasToolStripMenuItem.Visible = gestor.TienePermisoPara(Funcionalidad.RegistroDeUsuarios);

	        proveedoresToolStripMenuItem.Visible = gestor.TienePermisoPara(Funcionalidad.ABMdeProveedor);
	        creditoToolStripMenuItem.Visible = gestor.TienePermisoPara(Funcionalidad.CargarCrédito);
            facturaciónToolStripMenuItem.Visible = gestor.TienePermisoPara(Funcionalidad.FacturacionaProveedor);
            estadisticasToolStripMenuItem.Visible = gestor.TienePermisoPara(Funcionalidad.ListadoEstadistico);
            toolStripMenuCompraOferta.Visible = gestor.TienePermisoPara(Funcionalidad.ComprarOferta);
            ofertasToolStripMenuItem.Visible = gestor.TienePermisoPara(Funcionalidad.Confeccionypublicaciondeofertas);
            entregaDeOfertasToolStripMenuItem.Visible = gestor.TienePermisoPara(Funcionalidad.EntregaDeOfertas);
            
            
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (DesignMode) return;

            var frm = new FrmCliente();
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

        private void creditoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (DesignMode) return;

            var frm = new FrmAltaCredito();
            frm.Presentador.Posicionar();
            frm.MdiParent = this;
            frm.Show();
        }

        private void proveedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void facturaciónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (DesignMode) return;

            var frm = new FrmListadoDeFacturas();
            //frm.Presentador.Posicionar(Global.SessionUsuario);
            frm.MdiParent = this;
            frm.Show();
        }

        private void estadisticasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (DesignMode) return;

            var frm = new FrmEstadisticas();
            //frm.Presentador.Posicionar(Global.SessionUsuario);
            frm.MdiParent = this;
            frm.Show();
        }

        private void ofertasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (DesignMode) return;

            var frm = new FrmListadoDeOfertas();
            frm.Presentador.Posicionar();
            frm.MdiParent = this;
            frm.Show();
        }

        private void toolStripMenuCompraOferta_Click(object sender, EventArgs e)
        {
            if (DesignMode) return;

            var frm = new FrmCompraDeOfertas();
            frm.Presentador.Posicionar();
            frm.MdiParent = this;
            frm.Show();
        }

        private void entregaDeOfertasToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
