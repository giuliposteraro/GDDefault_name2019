using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Negocio.Base;
using Negocio.Repositorios;

namespace FrbaOfertasPresentacion.LogIn.CambiarContraseña
{
    public class PresentadorCambioContraseña
    {
        private readonly IVistaCambioContraseña _vista;

        public PresentadorCambioContraseña(IVistaCambioContraseña vista)
        {
            _vista = vista;
        }


        public void Posicionar(Negocio.Entidades.Usuario usuario)
        {
            this.UsuarioEnEdicion = usuario;
            this._vista.Usuario = usuario.Usuario_Cuenta;
        }

        public Negocio.Entidades.Usuario UsuarioEnEdicion { get; set; }

        public bool GuardarContraseña()
        {
            try
            {
                if(!ValidarContraseña()) return false;

                //mando a guardar            
                var maper = new MaperDeUsuarios();
                var repo = new RepositorioDeUsuarios(maper);
                var nuevaPass = Encriptador.ComputeSha256Hash(_vista.PasswordNuevo);

                repo.GuardarContraseña(UsuarioEnEdicion.Id_Usuario, nuevaPass);

                //si paso la validacion y se guardo  correctamente, actualizo el usuario en edición
                UsuarioEnEdicion.Contra_Cuenta = nuevaPass;
                _vista.MostrarMensaje("Contraseña actualizada con exito");
                return true;
            }
            catch(Exception ex)
            {
                 _vista.MostrarMensaje(string.Format("Se produjo una excepción al actualizar la contraseña: {0}", ex.Message));
                return false;
            }
        }

        private bool ValidarContraseña()
        {

            //la contraseña y la contraseña repetida deben ser iguales
            if (_vista.PasswordNuevo != _vista.RepetirPassword)
            {
                _vista.MostrarMensaje("Las contraseñas ingresadas no son iguales.");
                return false;
            }
            //la contraseña no puede ser nula
            if (_vista.PasswordNuevo.EsNuloOVacio())
            {
                _vista.MostrarMensaje("La contraseña no puede estar vacia.");
                return false;
            }
            //la contraseña no puede ser la misma que la anterior
            if (Encriptador.ComputeSha256Hash(_vista.PasswordNuevo) == UsuarioEnEdicion.Contra_Cuenta)
            {
                _vista.MostrarMensaje("La contraseña no puede ser igual a la anterior.");
                return false;
            }

            return true;
        }
    }
}
