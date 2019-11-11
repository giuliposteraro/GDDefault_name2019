using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrbaOfertas.ComprarOferta
{
    public partial class FrmCompraDeOfertas : Form
    {
        private Credito Credito;
        private Oferta oferta;
        private float precio;
        private int id_compra;
        private int cant_ofertas;

        public FrmCompraDeOfertas(Credito credito, float precio, Oferta oferta)
        {
            if(credito < precio) throw new Exception("El usuario no posee credito suficiente");
            this.oferta = oferta;
            this.Credito - precio;
            InitializeComponent();
        }

        public bool MensajePregunta(string mensage)
        {
            return (MessageBox.Show(mensage, "Confirmar", System.Windows.Forms.MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes);
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
