using FrbaOfertasPresentacion.bases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrbaOfertasPresentacion.LogIn.AltaCuenta
{
    public interface IVistaAltaCuenta: IVistaBase
    {

        void TextoPantalla(string p);

        void PantallaAdministrativo();

        List<Negocio.Entidades.Rol> Roles { get; set; }

        string Nombre { get; set; }

        string Contrasenia { get; set; }

        string Contrasenia2 { get; set; }

        List<Negocio.Entidades.Rol> RolesSeleccionados { get; set; }

        List<string> Tipos { get; set; }

        string TipoSeleccionado { get; set; }

        void MostrarPantallaAdicionalClienteOProveedor(bool p);

        string NombreCliente { get; set; }

        string ApellidoCliente { get; set; }

        int DNICliente { get; set; }

        string MailCliente { get; set; }

        string TelCliente { get; set; }

        DateTime FechaCliente { get; set; }

        int Numero_Dir { get; set; }

        string Piso_Dir { get; set; }

        string Depto_Dir { get; set; }

        string Localidad_Dir { get; set; }

        string Ciudad_Dir { get; set; }

        string Calle_Dir { get; set; }

        string Codigo_Postal_Dir { get; set; }

        string RazonSocial { get; set; }

        string Mail_Proveedor { get; set; }

        string Telefono_Prov { get; set; }

        string Cuit_Prov { get; set; }

        string Rubro_Prov { get; set; }

        string Nom_Contacto_Prov { get; set; }
    }
}
