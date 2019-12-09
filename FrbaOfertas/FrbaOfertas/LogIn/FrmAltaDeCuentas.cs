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
            lblDatosExtra.Visible = false;
            lblTipo.Visible = false;
            cboTipo.Visible = false;
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


        public List<string> Tipos
        {
            get
            {
                throw new NotImplementedException();
            }
            set
            {
                cboTipo.DataSource = value;
            }
        }


        public string TipoSeleccionado
        {
            get
            {
                return cboTipo.SelectedItem.ToString();
            }
            set
            {
                cboTipo.SelectedItem = value;
            }
        }

        private void cboTipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (DesignMode) return;
            this.Presentador.CambioTipo();
        }


        public void MostrarPantallaAdicionalClienteOProveedor(bool altaCliente)
        {
            chkRoles.Enabled = false;
            if (altaCliente)
            {
                this.ucCliente1.Visible = true;
                this.ucProveedor1.Visible = false;
                for (int count = 0; count < chkRoles.Items.Count; count++)
                {
                    Negocio.Entidades.Rol c = (Negocio.Entidades.Rol)chkRoles.Items[count];
                    if (c.Nombre_rol == "Cliente")
                        chkRoles.SetItemChecked(count, true);
                    else
                        chkRoles.SetItemChecked(count, false);
                }
            }
            else
            {
                this.ucCliente1.Visible = false;
                this.ucProveedor1.Visible = true;
                for (int count = 0; count < chkRoles.Items.Count; count++)
                {
                    Negocio.Entidades.Rol c = (Negocio.Entidades.Rol)chkRoles.Items[count];
                    if (c.Nombre_rol == "Proveedor")
                        chkRoles.SetItemChecked(count, true);
                    else
                        chkRoles.SetItemChecked(count, false);
                }
            }
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
                if (this.ucCliente1.Visible)
                    return ucCliente1.Numero_Dir.ToString();
                else
                    return ucProveedor1.Numero_Dir.ToString();
            }
            set
            {
                if (this.ucCliente1.Visible)
                    ucCliente1.Numero_Dir = value;
                else
                    ucProveedor1.Numero_Dir = value;
            }
        }

        public string Piso_Dir
        {
            get
            {
                if (this.ucCliente1.Visible)
                    return ucCliente1.Piso_Dir;
                else
                    return ucProveedor1.Piso_Dir;
            }
            set
            {
                if (this.ucCliente1.Visible)
                    ucCliente1.Piso_Dir = value;
                else
                    ucProveedor1.Piso_Dir = value;
            }
        }

        public string Depto_Dir
        {
            get
            {
                if (this.ucCliente1.Visible)
                    return ucCliente1.Depto_Dir;
                else
                    return ucProveedor1.Depto_Dir;
            }
            set
            {
                if (this.ucCliente1.Visible)
                    ucCliente1.Depto_Dir = value;
                else
                    ucProveedor1.Depto_Dir = value;
            }
        }

        public string Localidad_Dir
        {
            get
            {
                if (this.ucCliente1.Visible)
                    return ucCliente1.Localidad_Dir;
                else
                    return ucProveedor1.Localidad_Dir;
            }
            set
            {
                if (this.ucCliente1.Visible)
                    ucCliente1.Localidad_Dir = value;
                else
                    ucProveedor1.Localidad_Dir = value;
            }
        }

        public string Ciudad_Dir
        {
            get
            {
                if (this.ucCliente1.Visible)
                    return ucCliente1.Ciudad_Dir;
                else
                    return ucProveedor1.Ciudad_Dir;
            }
            set
            {
                if (this.ucCliente1.Visible)
                    ucCliente1.Ciudad_Dir = value;
                else
                    ucProveedor1.Ciudad_Dir = value;
            }
        }

        public string Calle_Dir
        {
            get
            {
                if (this.ucCliente1.Visible)
                    return ucCliente1.Calle_Dir;
                else
                    return ucProveedor1.Calle_Dir;
            }
            set
            {
                if (this.ucCliente1.Visible)
                    ucCliente1.Calle_Dir = value;
                else
                    ucProveedor1.Calle_Dir = value;
            }
        }

        public string Codigo_Postal_Dir
        {
            get
            {
                if (this.ucCliente1.Visible)
                    return ucCliente1.Codigo_Postal_Dir;
                else
                    return ucProveedor1.Codigo_Postal_Dir;
            }
            set
            {
                if (this.ucCliente1.Visible)
                    ucCliente1.Codigo_Postal_Dir = value;
                else
                    ucProveedor1.Codigo_Postal_Dir = value;
            }
        }

        public string RazonSocial
        {
            get
            {
                return ucProveedor1.RazonSocial;
            }
            set
            {
                ucProveedor1.RazonSocial = value;
            }
        }

        public string Mail_Proveedor
        {
            get
            {
                return ucProveedor1.Mail_Proveedor;
            }
            set
            {
                ucProveedor1.Mail_Proveedor = value;
            }
        }

        public string Telefono_Prov
        {
            get
            {
                return ucProveedor1.Telefono_Prov;
            }
            set
            {
                ucProveedor1.Telefono_Prov = value;
            }
        }

        public string Cuit_Prov
        {
            get
            {
                return ucProveedor1.Cuit_Prov;
            }
            set
            {
                ucProveedor1.Cuit_Prov = value;
            }
        }

        public string Rubro_Prov
        {
            get
            {
                return ucProveedor1.Rubro_Prov;
            }
            set
            {
                ucProveedor1.Rubro_Prov = value;
            }
        }

        public string Nom_Contacto_Prov
        {
            get
            {
                return ucProveedor1.Nom_Contacto_Prov;
            }
            set
            {
                ucProveedor1.Nom_Contacto_Prov = value;
            }
        }
    }
}
