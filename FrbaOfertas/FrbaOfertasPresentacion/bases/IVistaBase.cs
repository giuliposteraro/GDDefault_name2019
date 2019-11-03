using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrbaOfertasPresentacion.bases
{
    public interface IVistaBase
    {
        void MostrarMensaje(string message);

        bool MensajePregunta(string mensage);
    }
}
