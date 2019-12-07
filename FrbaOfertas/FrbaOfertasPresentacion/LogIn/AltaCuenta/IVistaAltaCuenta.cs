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
    }
}
