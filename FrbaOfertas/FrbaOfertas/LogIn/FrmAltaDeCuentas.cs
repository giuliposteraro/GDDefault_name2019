using FrbaOfertasPresentacion.LogIn.AltaCuenta;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrbaOfertas.LogIn
{
    public partial class FrmAltaDeCuentas : Form, IVistaAltaCuenta
    {

        private readonly PresentadorAltaCuenta _presenter;

        public PresentadorAltaCuenta Presentador
        {
            get { return _presenter; }
        }
        public FrmAltaDeCuentas()
        {
            InitializeComponent();
            _presenter = new PresentadorAltaCuenta(this);
        }

        public void MostrarMensaje(string message)
        {
            MessageBox.Show(message);
        }

        private void FrmAltaDeCuentas_Load(object sender, EventArgs e)
        {
            _presenter.IniciarVista();
        }

        public bool MensajePregunta(string mensage)
        {
            return (MessageBox.Show(mensage, "Confirmar", System.Windows.Forms.MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        public void TextoPantalla(string p)
        {
            this.Text = p;
        }



        public void PantallaAdministrativo()
        {
            this.MinimumSize = new Size(517, 204);
            this.MaximumSize = new Size(517, 204);
        }


        public List<Negocio.Entidades.Rol> Roles
        {
            get
            {
                throw new NotImplementedException();
            }
            set
            {
                chkRoles.DataSource = value;
                chkRoles.DisplayMember = "Nombre_rol";
                chkRoles.ValueMember = "Id_Rol";
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (!(Presentador.ValidarGuardar()))
                return;

            if (this.Presentador.Guardar())
            {
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }


        public string Nombre
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

        public string Contrasenia
        {
            get
            {
                return txtPass.Text;
            }
            set
            {
                txtPass.Text = value;
            }
        }

        public string Contrasenia2
        {
            get
            {
                return txtPass2.Text;
            }
            set
            {
                txtPass2.Text = value;
            }
        }


        public List<Negocio.Entidades.Rol> RolesSeleccionados
        {
            get
            {
                List<Negocio.Entidades.Rol> lista = new List<Negocio.Entidades.Rol>();
               
                foreach (object c in chkRoles.CheckedItems)
                    lista.Add((Negocio.Entidades.Rol)c);
                return lista; 
            }
            set
            {

                for (int count = 0; count < chkRoles.Items.Count; count++)
                {
                    if (value.Contains((Negocio.Entidades.Rol)chkRoles.Items[count]))
                    {
                        chkRoles.SetItemChecked(count, true);
                    }
                }
            }
        }
    }
}
