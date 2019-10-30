using Negocio.Repositorios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrbaOfertasPresentacion.LogIn.ListadoDeCuentas
{
    public class PresentadorListadoCuentas
    {
        private readonly IVistaListadoCuentas _vista;

        public PresentadorListadoCuentas(IVistaListadoCuentas vista)
        {
            _vista = vista;

        }


        public void IniciarVista()
        {
            
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

        public void ActualizarGrilla()
        {
            throw new NotImplementedException();
        }
    }
}
