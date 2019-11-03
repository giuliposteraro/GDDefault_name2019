using Negocio.Entidades;
using Negocio.Repositorios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrbaOfertasPresentacion.ABMRol
{
    public class PresentadorListaDeRoles
    {
        private readonly IVistaListaDeRoles _vista;

        public PresentadorListaDeRoles(IVistaListaDeRoles vista)
        {
            _vista = vista;

        }

        public void LimpiarFiltros()
        {
            _vista.Nombre = "";
        }

        public void BuscarConFiltros()
        {
            try
            {
                var maper = new MaperDeRoles();
                var repo = new RepositorioDeRoles(maper);

                _vista.Roles = repo.BuscarConFiltros(_vista.Nombre);
            }
            catch (Exception ex)
            {
                _vista.MostrarMensaje(ex.Message);
            }
        }

        public void IniciarVista()
        {

        }

        public void ActualizarGrilla(Negocio.Entidades.Rol rol)
        {
            /*List<Rol> roles = _vista.Roles;
            if (!roles.Contains(rol))
                roles.Add(rol);
            else
                roles[roles.FindIndex(ind => ind.Equals(rol))] = rol;
            
            _vista.Roles = roles;*/
            this.BuscarConFiltros();
        }

        public void ReHabilitarRol(Negocio.Entidades.Rol RolEnEdicion)
        {
            try
            {
                if (RolEnEdicion.Estado_rol)
                {
                    _vista.MostrarMensaje("El rol seleccionado ya encuentra habilitado");
                    return;
                }
              
                var maper = new MaperDeRoles();
                var repo = new RepositorioDeRoles(maper);
                RolEnEdicion.Estado_rol = true;
                List<string> propertiesAActualizar = new List<string> { ("Estado_rol") };

                repo.ActualizarEntidad(RolEnEdicion, propertiesAActualizar, "Id_Rol");

                _vista.MostrarMensaje("El rol se habilito con éxito");
            }
            catch (Exception ex)
            {
                _vista.MostrarMensaje(ex.Message);
            }
        }
    }
}

