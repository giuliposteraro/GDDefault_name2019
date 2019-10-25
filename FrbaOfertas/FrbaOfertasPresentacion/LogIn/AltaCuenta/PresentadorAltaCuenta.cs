using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrbaOfertasPresentacion.LogIn.AltaCuenta
{
    public class PresentadorAltaCuenta 
    {
        private readonly IVistaAltaCuenta _vista;

        public PresentadorAltaCuenta(IVistaAltaCuenta vista)
        {
            _vista = vista;

        }
        
    }
}
