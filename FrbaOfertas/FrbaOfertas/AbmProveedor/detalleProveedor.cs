using FrbaOfertasPresentacion.AbmProveedor;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrbaOfertas.AbmProveedor
{
    public partial class detalleProveedor : Form, IVistaABMProveedor
    {

        private readonly PresentadorABMProveedor _presenter;
        public PresentadorABMProveedor Presentador
        {
            get { return _presenter; }
            
        }

        public detalleProveedor()
        {
            InitializeComponent();
            _presenter = new PresentadorABMProveedor(this);
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBoxRazonSocial_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxNombreContacto_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxCuit_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxRubro_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxCalle_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxNroCalle_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void textBoxDpto_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxPiso_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxLocalidad_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxCiudad_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxCp_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxTelefono_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxMail_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonAceptar_Click(object sender, EventArgs e)
        {
            if (!(Presentador.ValidarGuardar()))
                return;

            if (this.Presentador.Guardar())
            {
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        private void buttonCerrar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void detalleProveedor_Load(object sender, EventArgs e)
        {

        }


        public void MostrarMensaje(string message)
        {
            MessageBox.Show(message);
        }

        public bool MensajePregunta(string mensage)
        {
            return (MessageBox.Show(mensage, "Confirmar", System.Windows.Forms.MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes);
        }

        public void BloquearPantalla()
        {
            this.textBoxRazonSocial.Enabled = false;
            textBoxNombreContacto.Enabled = false;
            textBoxCuit.Enabled = false;
            textBoxRubro.Enabled = false;
            textBoxTelefono.Enabled = false;
            textBoxMail.Enabled = false;
            textBoxCalle.Enabled = false;
            textBoxNroCalle.Enabled = false;
            textBoxDpto.Enabled = false;
            textBoxPiso.Enabled = false;
            textBoxLocalidad.Enabled = false;
            textBoxCiudad.Enabled = false;
            textBoxCp.Enabled = false;
        }

        public string Texto
        {
            get
            {
                return this.Text;
            }
            set
            {
                this.Text = value;
            }
        }

        public string RazonSocial
        {
            get
            {
                return textBoxRazonSocial.Text;
            }
            set
            {
                textBoxRazonSocial.Text=value;
            }
        }

        public string Mail_Proveedor
        {
            get
            {
                return textBoxMail.Text;
            }
            set
            {
                textBoxMail.Text = value;
            }
        }

        public string Telefono_Prov
        {
            get
            {
                return textBoxTelefono.Text;
            }
            set
            {
                textBoxTelefono.Text = value;
            }
        }

        public string Cuit_Prov
        {
            get
            {
                return textBoxCuit.Text;
            }
            set
            {
                textBoxCuit.Text = value;
            }
        }

        public string Rubro_Prov
        {
            get
            {
                return textBoxRubro.Text;
            }
            set
            {
                textBoxRubro.Text = value;
            }
        }

        public string Nom_Contacto_Prov
        {
            get
            {
                return textBoxNombreContacto.Text;
            }
            set
            {
                textBoxNombreContacto.Text = value;
            }
        }

        public string Numero_Dir
        {
            get
            {
                return textBoxNroCalle.Text;
            }
            set
            {
                textBoxNroCalle.Text = value;
            }
        }

        public string Piso_Dir
        {
            get
            {
                return textBoxPiso.Text;
            }
            set
            {
                textBoxPiso.Text = value;
            }
        }

        public string Depto_Dir
        {
            get
            {
                return textBoxDpto.Text;
            }
            set
            {
                textBoxDpto.Text = value;
            }
        }

        public string Localidad_Dir
        {
            get
            {
                return textBoxLocalidad.Text;
            }
            set
            {
                textBoxLocalidad.Text = value;
            }
        }

        public string Ciudad_Dir
        {
            get
            {
                return textBoxCiudad.Text;
            }
            set
            {
                textBoxCiudad.Text = value;
            }
        }

        public string Calle_Dir
        {
            get
            {
                return textBoxCalle.Text;
            }
            set
            {
                textBoxCalle.Text = value;
            }
        }

        public string Codigo_Postal_Dir
        {
            get
            {
                return textBoxCp.Text;
            }
            set
            {
                textBoxCp.Text = value;
            }
        }


        public string BotonNombre
        {
            get
            {
                return buttonAlta.Text;
            }
            set
            {
                buttonAlta.Text = value;
            }
        }
    }
}
