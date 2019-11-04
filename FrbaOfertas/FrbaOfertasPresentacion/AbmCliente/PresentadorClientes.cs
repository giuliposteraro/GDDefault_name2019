using Negocio.Repositorios;
using Negocio.Base;
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
            _vista.Nombre = Global.SessionUsuario.Usuario_Cuenta;
        }
        public void ActualizarVista()
        {
            var cli = _vista.Clientes;
        }

        public void Buscar()
        {
            try
            {
                var maper = new MaperDeClientes();
                var repo = new RepositorioDeClientes(maper);

                _vista.Clientes = repo.BuscarConFiltros(_vista.Nombre, _vista.Apellido);
            }            
            catch (Exception ex)
            {
                _vista.MostrarMensaje(ex.Message);
            }
        }

    }

        
}
