﻿using FrbaOfertas.AbmCliente;
using FrbaOfertas.LogIn;
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

        private void mnuCRUDCLIE_Click(object sender, EventArgs e)
        {
            if (DesignMode) return;

            var frm = new FrmCRUDCliente();
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
        }
    }
}
