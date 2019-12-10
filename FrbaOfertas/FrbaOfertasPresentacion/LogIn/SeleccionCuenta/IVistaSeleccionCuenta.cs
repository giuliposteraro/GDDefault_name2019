using FrbaOfertasPresentacion.bases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrbaOfertasPresentacion.LogIn.SeleccionCuenta
{
    public interface IVistaSeleccionCuenta : IVistaBase
    {
        string Usuario_Nombre { get; set; }

        bool Activo { get; set; }

        List<Negocio.Entidades.Usuario> Usuarios { get; set; }
    }
}
