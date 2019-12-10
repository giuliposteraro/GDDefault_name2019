using Negocio.Repositorios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrbaOfertasPresentacion.LogIn.SeleccionCuenta
{
    public class PresentadorSeleccionCuenta
    {
        private readonly IVistaSeleccionCuenta _vista;

        public PresentadorSeleccionCuenta(IVistaSeleccionCuenta vista)
        {
            _vista = vista;

        }

        public void BuscarConFiltros()
        {
            try
            {
                var maper = new MaperDeUsuarios();
                var repo = new RepositorioDeUsuarios(maper);

                _vista.Usuarios = repo.BuscarConFiltros(_vista.Usuario_Nombre, _vista.Activo);
            }
            catch (Exception ex)
            {
                _vista.MostrarMensaje(ex.Message);
            }
        }
    }
}
