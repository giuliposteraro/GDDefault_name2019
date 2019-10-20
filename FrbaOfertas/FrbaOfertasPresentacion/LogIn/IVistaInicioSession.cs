using FrbaOfertasPresentacion.bases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrbaOfertasPresentacion.LogIn
{
    public interface IVistaInicioSession : IVistaBase
    {
        string Usuario { get; set; }
        string Password { get; set; }
    }
}
