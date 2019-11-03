using Negocio.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Negocio.Base;
using Negocio.Repositorios;

namespace FrbaOfertasPresentacion.ABMRol
{
    public class PresentadorRolesCta
    {
        private readonly IVistaRolesCta _vista;
        public Usuario UsuarioEnEdicion;

        public PresentadorRolesCta(IVistaRolesCta vista)
        {
            _vista = vista;

        }

        public void Posicionar(Usuario user)
        {
            UsuarioEnEdicion = user.Clone<Usuario>(); ;
            _vista.Nombre = UsuarioEnEdicion.Usuario_Cuenta;

            var maper = new MaperDeRoles();
            var repo = new RepositorioDeRoles(maper);

            //cargo los roles posibles
            _vista.RolesPosibles = repo.BuscarConFiltros("", true);

            //cargo los roles del usuario
            _vista.RolesSelccionados = UsuarioEnEdicion.RolDelUsuario;

        }


        public bool Aceptar()
        {
            this.ObtenerDesdeVista();
            if (!this.ValidarParaGuardar())
                return false;

            try
            {
                //mando a guardar            
                var maper = new MaperDeUsuarios();
                var repo = new RepositorioDeUsuarios(maper);

                repo.ActualizarRoles(UsuarioEnEdicion);

                _vista.MostrarMensaje("Roles del usuarios actualizado con exito");
                return true;
            }
            catch (Exception ex)
            {
                _vista.MostrarMensaje(string.Format("Se produjo una excepción al actualizar los roles: {0}", ex.Message));
                return false;
            }
        }

        private bool ValidarParaGuardar()
        {
            return true;
        }

        private void ObtenerDesdeVista()
        {
            UsuarioEnEdicion.LimpiarRoles();
            foreach (Rol r in _vista.RolesSelccionados)
                UsuarioEnEdicion.AgregarRol(r);
        }
    }
}
