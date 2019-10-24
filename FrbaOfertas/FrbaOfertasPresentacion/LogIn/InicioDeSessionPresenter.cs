using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Negocio.Base;
using Negocio.Repositorios;
using System.Security.Cryptography;
using Negocio.Entidades;

namespace FrbaOfertasPresentacion.LogIn
{
    public class InicioDeSessionPresenter
    {
        private readonly IVistaInicioSession _vista;

        public InicioDeSessionPresenter(IVistaInicioSession vista)
        {
            _vista = vista;

        }
        public void IniciarVista()
        {


        }
        public void ActualizarVista()
        {

        }

        public bool logguearUsuario()
        {
            //valido que se pase un usuario y password
            if (_vista.Usuario.EsNuloOVacio() || _vista.Password.EsNuloOVacio())
            {
                _vista.MostrarMensaje("Debe ingresar un usuario y password");
                return false;
            }

            try
            {
                var maper = new MaperDeUsuarios();
                var repo = new RepositorioDeUsuarios(maper);

                //busco el usuario por nombre
                Usuario usuario = repo.ObtenerPorNombre(_vista.Usuario);
                if( usuario == null)
                {
                    _vista.MostrarMensaje("Usuario o password incorrecto");
                    return false;
                }
                if (usuario.Cant_Ingresos_Cuenta >= 3)
                {
                    _vista.MostrarMensaje("Cantidad de intentos máximos alcanzados, usuario inhabilitado");
                    return false;
                }

                //comparo el password con el que viene de la base de datos
                if (ComputeSha256Hash(_vista.Password) != usuario.Contra_Cuenta)
                {
                    //si el password es incorrecto se considera un error y debe sumar 1 a los intentos incorrectos
                    repo.SumarUnError(usuario.Id_Usuario);

                    StringBuilder sb = new StringBuilder();
                    sb.AppendLine("Usuario o password incorrecto");
                    //si la suma de errores llego a 3 entonces el usuario fue bloqueado.
                    if (usuario.Cant_Ingresos_Cuenta >= 2)
                    {
                        sb.AppendLine("Se supero la cantidad máxima de intentos, su usuario fue inhabilitado");
                    }

                    _vista.MostrarMensaje(sb.ToString());
                    return false;
                }

                //si el login es correcto, limpio la suma de errores, si la cantidad de errores no es 0.
                if (usuario.Cant_Ingresos_Cuenta > 0)
                    repo.LimpiarCantidadDeErrores(usuario.Id_Usuario);

                return true;
            }
            catch (Exception ex)
            {
                _vista.MostrarMensaje(ex.Message);
                return false;
            }
           
        }

        static string ComputeSha256Hash(string rawData)
        {
            SHA256CryptoServiceProvider provider = new SHA256CryptoServiceProvider();

            byte[] inputBytes = Encoding.UTF8.GetBytes(rawData);
            byte[] hashedBytes = provider.ComputeHash(inputBytes);

            StringBuilder output = new StringBuilder();

            for (int i = 0; i < hashedBytes.Length; i++)
                output.Append(hashedBytes[i].ToString("x2").ToLower());

            return output.ToString();
        }
    }
}
