using FrbaOfertasPresentacion.bases;
using Negocio.Entidades;
using Negocio.Repositorios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Negocio.Base;

namespace FrbaOfertasPresentacion.ABMRol
{
    public class PresentadorABMRol
    {
        private readonly IVistaABMRol _vista;

        public PresentadorABMRol(IVistaABMRol vista)
        {
            _vista = vista;

        }

        public void Posicionar(ModosDeEjecucion modosDeEjecucion)
        {
            modo = modosDeEjecucion;
            this.InicializarVista();
        }

        private void InicializarVista()
        {
            _vista.NombrePagina = string.Format("{0} Rol", modo);

            var maper = new MaperDeFuncionalidades();
            var repo = new RepositorioDeFuncionalidades(maper);
            _vista.FuncionalidadesPosibles = repo.ObtenerTodos();

            switch (modo)
            {
                case ModosDeEjecucion.Alta:
                    _vista.NombreBoton = "Guardar";
                    break;
                case ModosDeEjecucion.Modificacion:
                    _vista.NombreBoton = "Modificar";
                    break;
                case ModosDeEjecucion.Baja:
                    _vista.NombreBoton = "Eliminar";
                    _vista.BloquearParaELiminar();
                    break;
            }
        }

        public void Posicionar(Negocio.Entidades.Rol rol, ModosDeEjecucion modosDeEjecucion)
        {
            modo = modosDeEjecucion;
            this.InicializarVista();
            _vista.Nombre = rol.Nombre_rol;
            _vista.FuncionalidadesSeleccionadas = rol.FuncionalidadesDelRol;
            RolEnEdicion = rol.Clone<Rol>();
            
        }

        public Rol RolEnEdicion { get; set; }
        private bases.ModosDeEjecucion modo;

        public bool Aceptar()
        {
            switch (modo)
            {
                case ModosDeEjecucion.Alta:
                    return this.GuardarNuevo();
                case ModosDeEjecucion.Modificacion:
                    return this.ActualizarItem();
                case ModosDeEjecucion.Baja:
                    return this.EliminarItem();
                default :
                    return false;
            }
        }

        private bool ActualizarItem()
        {
            this.ObtenerDesdeVista();
            if (!this.ValidarParaGuardar())
                return false;

            try
            {
                //mando a guardar            
                var maper = new MaperDeRoles();
                var repo = new RepositorioDeRoles(maper);

                repo.Actualizar(RolEnEdicion);

                _vista.MostrarMensaje("Rol actualizado con exito");
                return true;
            }
            catch (Exception ex)
            {
                _vista.MostrarMensaje(string.Format("Se produjo una excepción al actualizar el nuevo rol: {0}", ex.Message));
                return false;
            }
        }

        private bool ValidarParaGuardar()
        {
            if (_vista.Nombre.EsNuloOVacio())
            {
                _vista.MostrarMensaje("El nombre no puede estar vacio");
                return false;
            }
            var maper = new MaperDeRoles();
            var repo = new RepositorioDeRoles(maper);
            List<Rol> RolesRepetidos = repo.BuscarConFiltros(RolEnEdicion.Nombre_rol);

            if((from r in RolesRepetidos where r.Id_Rol != RolEnEdicion.Id_Rol select r).Any())
            {
                _vista.MostrarMensaje("El nombre ya esta en uso en otro rol");
                return false;
            }

            return true;
        }

        private bool GuardarNuevo()
        {
            RolEnEdicion = new Rol();
            RolEnEdicion.Estado_rol = true;
            this.ObtenerDesdeVista();
            if (!this.ValidarParaGuardar())
                return false;

            try
            {
                //mando a guardar            
                var maper = new MaperDeRoles();
                var repo = new RepositorioDeRoles(maper);

                repo.Guardar(RolEnEdicion);

                
                _vista.MostrarMensaje("Rol creado con exito");
                return true;
            }
            catch (Exception ex)
            {
                _vista.MostrarMensaje(string.Format("Se produjo una excepción al crear el nuevo rol: {0}", ex.Message));
                return false;
            }
        }

        private void ObtenerDesdeVista()
        {
            RolEnEdicion.Nombre_rol = _vista.Nombre;
            RolEnEdicion.LimpiarFuncionalidades();
            foreach (Funcionalidad fun in _vista.FuncionalidadesSeleccionadas)
                RolEnEdicion.AgregarFuncionalidad(fun);
        }


        private bool EliminarItem()
        {
            try
            {
                if (!RolEnEdicion.Estado_rol)
                {
                    _vista.MostrarMensaje("El rol seleccionado ya encuentra deshabilitado");
                    return false;
                }

                if (!_vista.MensajePregunta("El rol se deshabilitará, y se quitará de todos los usuarios que lo tengan asignado."))
                    return false;

                var maper = new MaperDeRoles();
                var repo = new RepositorioDeRoles(maper);
                RolEnEdicion.Estado_rol = false;
                List<string> propertiesAActualizar = new List<string> { ("Estado_rol") };

                repo.ActualizarEntidad(RolEnEdicion, propertiesAActualizar, "Id_Rol");

                _vista.MostrarMensaje("El rol se deshabilito con éxito");
                return true;
            }
            catch (Exception ex)
            {
                _vista.MostrarMensaje(ex.Message);
                return false;
            }
        }
    }
}
