using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrbaOfertas.AbmProveedor
{
    public partial class ucProveedor : UserControl
    {
        public ucProveedor()
        {
            InitializeComponent();
        }


        private void control_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        public int Numero_Dir
        {
            get
            {
                if (txtNumero.Text == "") return 0; 
                return int.Parse(txtNumero.Text); }
            set { txtNumero.Text = value.ToString(); }
        }

        public string Piso_Dir
        {
            get { return txtPiso.Text; }
            set { txtPiso.Text = value; }
        }

        public string Depto_Dir
        {
            get { return txtDepto.Text; }
            set { txtDepto.Text = value; }
        }

        public string Localidad_Dir
        {
            get { return txtLocalidad.Text; }
            set { txtLocalidad.Text = value; }
        }

        public string Ciudad_Dir
        {
            get { return txtCiudad.Text; }
            set { txtCiudad.Text = value; }
        }

        public string Calle_Dir
        {
            get { return txtCalle.Text; }
            set { txtCalle.Text = value; }
        }

        public string Codigo_Postal_Dir
        {
            get { return txtCodigoPostal.Text; }
            set { txtCodigoPostal.Text = value; }
        }

        public string RazonSocial
        {
            get { return txtRazonSocial.Text; }
            set { txtRazonSocial.Text = value; }
        }

        public string Mail_Proveedor
        {
            get { return txtMail.Text; }
            set { txtMail.Text = value; }
        }

        public string Telefono_Prov
        {
            get { return txtTelefono.Text; }
            set { txtTelefono.Text = value; }
        }

        public string Cuit_Prov
        {
            get { return txtCuit.Text; }
            set { txtCuit.Text = value; }
        }

        public string Rubro_Prov
        {
            get { return txtRubro.Text; }
            set { txtRubro.Text = value; }
        }

        public string Nom_Contacto_Prov
        {
            get { return txtContacto.Text; }
            set { txtContacto.Text = value; }
        }
    }
}
