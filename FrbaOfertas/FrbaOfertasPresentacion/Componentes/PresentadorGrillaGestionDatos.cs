using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrbaOfertasPresentacion.Componentes
{
    public class PresentadorGrillaGestionDatos
    {
         private readonly IGrillaGestionDatosVista _vista;

         public PresentadorGrillaGestionDatos(IGrillaGestionDatosVista vista)
        {
            _vista = vista;
            
        }
        public void MostrarMensaje(string mensaje)
        {
        }

    }
}
