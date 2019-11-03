using Negocio.Entidades;
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


        public void ActualizarGrilla(Negocio.Entidades.Usuario usuario)
        {
            /*List<Usuario> users = _vista.Usuarios;
            users[users.FindIndex(ind=>ind.Equals(usuario))] =  usuario;
            _vista.Usuarios = users;
            _vista.ReloadView();*/
            this.BuscarConFiltros();
        }

        public void Activar(Usuario usuario, bool activar)
        {
            try
            {
                EstadosUsuario estadoAAplicar;
                if (activar)
                    estadoAAplicar = EstadosUsuario.activo;
                else
                    estadoAAplicar = EstadosUsuario.desactivo;
                
                if( usuario.Estado_Cuenta == estadoAAplicar)
                {
                    _vista.MostrarMensaje(string.Format("El ususario seleccionado ya encuentra {0}",estadoAAplicar));
                    return;
                }

                //guardo la actualizacion en la base de datos.
                var maper = new MaperDeUsuarios();
                var repo = new RepositorioDeUsuarios(maper);
                usuario.Estado_Cuenta = estadoAAplicar;
                List<string> propertiesAActualizar = new List<string> {("Estado_Cuenta")};

                repo.ActualizarEntidad(usuario, propertiesAActualizar,"Id_Usuario");

                //actualizo la grilla
                ActualizarGrilla(usuario);

                _vista.MostrarMensaje(string.Format("El ususario se {0} con éxito",estadoAAplicar));
            }
            catch (Exception ex)
            {
                _vista.MostrarMensaje(ex.Message);
            }
        }

        public void LimpiarFiltros()
        {
            _vista.Usuario_Nombre = "";
            _vista.Activo = false;
        }
    }
}
