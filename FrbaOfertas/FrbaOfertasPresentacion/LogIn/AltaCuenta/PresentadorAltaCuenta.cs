using Negocio.Entidades;
using Negocio.Repositorios;
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

            var maper = new MaperDeRoles();
            var repo = new RepositorioDeRoles(maper);

            _vista.Roles = repo.BuscarConFiltros("",true);

            _modoPosicionar = modo;

            if (_modoPosicionar == ModoAltaCuenta.DesdeListado)
            {
                _vista.TextoPantalla("Alta de usuarios administrativos");
                _vista.PantallaAdministrativo();
            }
        }



        public void IniciarVista()
        {
            
        }


        /// <summary>
        /// validaciones para guardar
        /// </summary>
        /// <returns></returns>
        public bool ValidarGuardar()
        {
            try
            {
                StringBuilder sb = new StringBuilder();
                if (_vista.Contrasenia != _vista.Contrasenia2)
                    sb.AppendLine("las contraseñas deben ser iguales");

                if (_vista.Contrasenia == null || _vista.Contrasenia2 == null)
                    sb.AppendLine("la contraseña y su repetición no deben ser nulas");

                //valido usuario existente
                var maper = new MaperDeUsuarios();
                var repo = new RepositorioDeUsuarios(maper);
                 Usuario usuario = repo.ObtenerPorNombre(_vista.Nombre);
                 if (usuario != null)
                     sb.AppendLine("El nombre de usuario ya fue utilizado anteriormente");

                //validaciones propias de cliente y proveedor
                if (this._modoPosicionar == ModoAltaCuenta.DesdeLogIn)
                {
                }


                if (sb.Length > 0)
                {
                    _vista.MostrarMensaje(sb.ToString());
                    return false;
                }
                return true;
            }
            catch (Exception ex)
            {
                _vista.MostrarMensaje(string.Format("Se produjo una excepción al validar el nuevo usuario: {0}", ex.Message));
                return false;
            }
        }

        /// <summary>
        /// guardado
        /// </summary>
        /// <returns></returns>
        public bool Guardar()
        {
            if (!this.ValidarGuardar())
                return false;

            try
            {
                ObtenerUsuarioDesdeVista();
                //mando a guardar            
                var maper = new MaperDeUsuarios();
                var repo = new RepositorioDeUsuarios(maper);

                repo.Guardar(usuarioAGuardar);

                _vista.MostrarMensaje("Cuenta creada con éxito.");
                return true;
            }
            catch (Exception ex)
            {
                _vista.MostrarMensaje(string.Format("Se produjo una excepción al crear el nuevo usuario: {0}", ex.Message));
                return false;
            }
        }

        private Usuario usuarioAGuardar;

        private void ObtenerUsuarioDesdeVista()
        {
            usuarioAGuardar = new Usuario();
            usuarioAGuardar.Usuario_Cuenta = _vista.Nombre;
            usuarioAGuardar.Contra_Cuenta = _vista.Contrasenia;
            usuarioAGuardar.Estado_Cuenta = EstadosUsuario.activo;
            usuarioAGuardar.Cant_Ingresos_Cuenta = 0;
            foreach (Rol r in _vista.RolesSeleccionados)
                usuarioAGuardar.AgregarRol(r);
        }
    }
}
