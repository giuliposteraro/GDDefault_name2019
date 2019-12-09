using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrbaOfertas.AbmCliente
{
    public partial class ucCliente : UserControl
    {
        public ucCliente()
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

        public string NombreCliente
        {
            get
            {
                return txtNombre.Text;
            }
            set
            {
                txtNombre.Text = value;
            }
        }

        public string ApellidoCliente 
        { 
            get
            {
                return txtApellido.Text;
            }
            set 
            {
                txtApellido.Text = value;
            }
        }

        public int DNICliente {
            get
            {
                if (txtDni.Text == "") return 0;
                return int.Parse(txtDni.Text); 
            }
            set { txtDni.Text = value.ToString(); }
        }

        public string MailCliente { 
            get { return txtMail.Text; }
            set { txtMail.Text = value; }
        }

        public string TelCliente {
            get { return txtTelefono.Text; }
            set { txtTelefono.Text = value; }
        }

        public DateTime FechaCliente {
            get { return dtpFechaNac.Value; }
            set { dtpFechaNac.Value = value; }
        }

        public string Numero_Dir {
            get {
                return txtNumero.Text; }
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
    }
}
