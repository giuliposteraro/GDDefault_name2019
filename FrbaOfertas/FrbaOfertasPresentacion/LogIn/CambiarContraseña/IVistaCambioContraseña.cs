using FrbaOfertasPresentacion.bases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrbaOfertasPresentacion.LogIn.CambiarContraseña
{
    public interface IVistaCambioContraseña : IVistaBase
    {
        string Usuario { get; set; }
        string PasswordNuevo { get; set; }
        string RepetirPassword { get; set; }
    }
}
