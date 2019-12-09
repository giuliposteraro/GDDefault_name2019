using FrbaOfertasPresentacion.AbmCliente;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Negocio.Base;

namespace FrbaOfertas.AbmCliente
{
    public partial class FrmClienteEditar : Form, IVistaABMCliente
    {

        private readonly PresentadorABMCliente _presenter;

        public PresentadorABMCliente Presentador { get { return _presenter; } }

        public FrmClienteEditar()
        {
            InitializeComponent();
            _presenter = new PresentadorABMCliente(this);
        }

        public bool MensajePregunta(string mensage)
        {
            return (MessageBox.Show(mensage, "Confirmar", System.Windows.Forms.MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
                this.Close();
        }

        public void MostrarMensaje(string message)
        {
            MessageBox.Show(message);
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

        public void BloquearPantalla()
        {
            this.ucCliente1.Enabled = false;
        }

        public string NombreCliente
        {
            get
            {
                return ucCliente1.NombreCliente;
            }
            set
            {
                ucCliente1.NombreCliente = value;
            }
        }

        public string ApellidoCliente
        {
            get
            {
                return ucCliente1.ApellidoCliente;
            }
            set
            {
                ucCliente1.ApellidoCliente = value;
            }
        }

        public int DNICliente
        {
            get
            {
                return ucCliente1.DNICliente;
            }
            set
            {
                ucCliente1.DNICliente = value;
            }
        }

        public string MailCliente
        {
            get
            {
                return ucCliente1.MailCliente;
            }
            set
            {
                ucCliente1.MailCliente = value;
            }
        }

        public string TelCliente
        {
            get
            {
                return ucCliente1.TelCliente;
            }
            set
            {
                ucCliente1.TelCliente = value;
            }
        }

        public DateTime FechaCliente
        {
            get
            {
                return ucCliente1.FechaCliente;
            }
            set
            {
                ucCliente1.FechaCliente = value;
            }
        }

        public string Numero_Dir
        {
            get
            {
                return ucCliente1.Numero_Dir.ToString() ;
            }
            set
            {

               ucCliente1.Numero_Dir = value;
            }
        }

        public string Piso_Dir
        {
            get
            {
                    return ucCliente1.Piso_Dir;
            }
            set
            {
                    ucCliente1.Piso_Dir = value;
            }
        }

        public string Depto_Dir
        {
            get
            {
                    return ucCliente1.Depto_Dir;

            }
            set
            {
                    ucCliente1.Depto_Dir = value;
            }
        }

        public string Localidad_Dir
        {
            get
            {
                    return ucCliente1.Localidad_Dir;
            }
            set
            {
                    ucCliente1.Localidad_Dir = value;
            }
        }

        public string Ciudad_Dir
        {
            get
            {
                    return ucCliente1.Ciudad_Dir;
            }
            set
            {
                    ucCliente1.Ciudad_Dir = value;
            }
        }

        public string Calle_Dir
        {
            get
            {
                    return ucCliente1.Calle_Dir;
            }
            set
            {
                    ucCliente1.Calle_Dir = value;
            }
        }

        public string Codigo_Postal_Dir
        {
            get
            {
                return ucCliente1.Codigo_Postal_Dir;
            }
            set
            {
                    ucCliente1.Codigo_Postal_Dir = value;
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (!(Presentador.ValidarGuardar()))
                return;

            if (this.Presentador.Guardar())
            {
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }
    }
}
