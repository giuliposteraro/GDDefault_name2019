using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrbaOfertas.Componentes
{
    public partial class paginador : UserControl
    {
        public paginador()
        {
            InitializeComponent();
        }

        private void toolStripLabel1_Click(object sender, EventArgs e)
        {

        }

        private void toolStripLabel3_Click(object sender, EventArgs e)
        {

        }

        public event EventHandler SolicitarBusqueda;
        public event EventHandler SeSeleccionaPaginaSiguiente;
        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            if (int.Parse(this.lblTotal.Text) == 0) return;

            //tengo que ver si estoy ya en la ultima pagina             
            int UltimaPagina = int.Parse(this.lblTotal.Text) / int.Parse(this.txtitems.Text);
            int Resto = (int.Parse(this.lblTotal.Text) - (UltimaPagina * int.Parse(this.txtitems.Text)));
            if (Resto > 0)
                UltimaPagina = UltimaPagina + 1;

            //si estoy en la ultima
            if (this.txtPagina.Text == UltimaPagina.ToString())
                return;
            int pagnum = int.Parse(this.txtPagina.Text) + 1;
            this.txtPagina.Text = pagnum.ToString();
            SeSeleccionaPaginaSiguiente(this, EventArgs.Empty);
        }
        public event EventHandler SeSeleccionaUltimaPagina;
        private void btnUltimaPagina_Click(object sender, EventArgs e)
        {
            if (int.Parse(this.lblTotal.Text) == 0) return;

            //tengo que ver si estoy ya en la ultima pagina 
            int UltimaPagina = int.Parse(this.lblTotal.Text) / int.Parse(this.txtitems.Text);
            int Resto = (int.Parse(this.lblTotal.Text) - (UltimaPagina * int.Parse(this.txtitems.Text)));
            if (Resto > 0)
                UltimaPagina = UltimaPagina + 1;

            //si estoy en la ultima
            if (this.txtPagina.Text == UltimaPagina.ToString())
                return;
            this.txtPagina.Text = UltimaPagina.ToString();
            SeSeleccionaUltimaPagina(this, EventArgs.Empty);
        }

        public event EventHandler SeSeleccionaPaginaAnterior;
        private void btnPrevia_Click(object sender, EventArgs e)
        {
            if (int.Parse(this.lblTotal.Text) == 0) return;

            //si estoy en la primera no hago nada
            if (this.txtPagina.Text == "1")
                return;
            int pagnum = int.Parse(this.txtPagina.Text) - 1;
            this.txtPagina.Text = pagnum.ToString();
            SeSeleccionaPaginaAnterior(this, EventArgs.Empty);
        }
        public event EventHandler SeSeleccionaPrimeraPagina;
        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            if (int.Parse(this.lblTotal.Text) == 0) return;

            //si estoy en la primera no hago nada
            if (this.txtPagina.Text == "1")
                return;
            this.txtPagina.Text = "1";
            SeSeleccionaPrimeraPagina(this, EventArgs.Empty);
        }

        public string ObtenerItemsPorPagina()
        {
            return this.txtitems.Text;
        }

        public string ObtenerPaginaActual()
        {
            return this.txtPagina.Text;    
        }

        private void txtitems_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
            if (e.KeyChar == '\r')
            {
                //verifico que no haya quedado un 0 en la cantidad de items
                if (int.Parse(this.txtitems.Text) == 0)
                    this.txtitems.Text = "1";
                //si cambio la cantidad de items vuelvo a la pagina 1
                this.SetearNumeroPagina(1);
                if (int.Parse(this.lblTotal.Text) != 0)
                    SolicitarBusqueda(this, EventArgs.Empty);
            }
        }

        private void txtPagina_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
            if (e.KeyChar == '\r')
            {
                if (int.Parse(this.txtPagina.Text) == 0)
                    this.txtPagina.Text = "1";
                if (int.Parse(this.lblTotal.Text) != 0)
                    SolicitarBusqueda(this, EventArgs.Empty);
            }
        }

        internal void SetearCantidadDeItems(int cantidadItems)
        {
            this.lblTotal.Text = cantidadItems.ToString();
        }

        internal void SetearNumeroPagina(int p)
        {
            this.txtPagina.Text = p.ToString();
        }

       
    }
}
