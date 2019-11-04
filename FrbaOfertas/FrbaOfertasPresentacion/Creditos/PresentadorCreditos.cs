using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrbaOfertasPresentacion.Creditos
{
    public class PresentadorCreditos
    {
        private readonly IVistaCreditos _vista;

        public PresentadorCreditos(IVistaCreditos vista)
        {
            _vista = vista;

        }
    }
}
