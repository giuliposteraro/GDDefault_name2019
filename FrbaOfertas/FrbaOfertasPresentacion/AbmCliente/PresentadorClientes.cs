using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrbaOfertasPresentacion.AbmCliente
{
    public class PresentadorClientes
    {
        private readonly IVistaClientes _vista;

        public PresentadorClientes(IVistaClientes vista)
        {
            _vista = vista;
            
        }
        public void IniciarVista()
        {
            _vista.Nombre = "nuevo";

        }
        public void ActualizarVista()
        {

        }

        public void Buscar()
        {
            throw new NotImplementedException();
        }


    }

        
}
