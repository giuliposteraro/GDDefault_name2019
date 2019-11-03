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
        private ModoAltaCuenta _modoPosicionar { get; set; }

        public PresentadorAltaCuenta(IVistaAltaCuenta vista)
        {
            _vista = vista;

        }

        public void Posicionar(ModoAltaCuenta modo)
        {
            _modoPosicionar = modo;
        }



        public void IniciarVista()
        {
            
        }
    }
}
