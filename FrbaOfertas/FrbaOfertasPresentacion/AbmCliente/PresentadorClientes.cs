using Negocio.Repositorios;
using Negocio.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Negocio.Entidades;

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
            //_vista.Nombre = Global.SessionUsuario.Usuario_Cuenta;
        }
        public void ActualizarVista()
        {
            this.Buscar();
        }

        public void Buscar()
        {
            try
            {
                var maper = new MaperDeClientes();
                var repo = new RepositorioDeClientes(maper);

                _vista.Clientes = repo.BuscarConFiltros(_vista.Nombre, _vista.Apellido, _vista.DNI, _vista.email);
            }            
            catch (Exception ex)
            {
                _vista.MostrarMensaje(ex.Message);
            }
        }


        public void Limpiar()
        {
            _vista.Nombre = "";
            _vista.Apellido = "";
            _vista.DNI = 0;
            _vista.email = "";
        }

        public bool Activar()
        {
            try
            {
                //mando a guardar            
                var maper = new MaperDeClientes();
                var repo = new RepositorioDeClientes(maper);

                if (_vista.ClienteSeleccionado == null)
                {
                    _vista.MostrarMensaje("debe seleccionar un cliente a activar.");
                    return false;
                }

                if (_vista.ClienteSeleccionado.Habilitado)
                {
                    _vista.MostrarMensaje("El cliente ya se encuentra habilitado.");
                    return false;
                }

                    _vista.ClienteSeleccionado.Habilitado = true;
                    List<string> propertiesAActualizar = new List<string> { ("Habilitado") };
                    repo.ActualizarEntidad(_vista.ClienteSeleccionado, propertiesAActualizar, "Id_Cliente");
               
                _vista.MostrarMensaje("activación realizada con éxito.");
                return true;
            }
            catch (Exception ex)
            {
                _vista.MostrarMensaje(string.Format("Se produjo una excepción al realizar la activación sobre el cliente: {0}", ex.Message));
                return false;
            }
        }

        public void AsociarUsuario(Usuario user, Cliente clie)
        {
            try
            {
                //valido que el cliente no tenga una cuenta
                if (clie.Id_Cuenta != 0)
                {
                    _vista.MostrarMensaje("el cliente ya tiene una cuenta asociada");
                    return;
                }
                
                //mando a guardar            
                var maper = new MaperDeClientes();
                var repo = new RepositorioDeClientes(maper);
                //verifico que la cuenta no est asociada a otro cliente
                Cliente clientePosible = repo.ObtenerDelUsuario(user.Id_Usuario);
                if (clientePosible != null)
                {
                    _vista.MostrarMensaje("La cuenta seleccionada ya esta asociada a otro cliente");
                    return;
                }

                
                clie.Id_Cuenta = user.Id_Usuario;
                List<string> propertiesAActualizar = new List<string> { ("Id_Cuenta") };
                repo.ActualizarEntidad(clie, propertiesAActualizar, "Id_Cliente");
               

                _vista.MostrarMensaje("cuenta asignada con éxito.");

            }
            catch (Exception ex)
            {
                _vista.MostrarMensaje(string.Format("Se produjo una excepción al asignar la cuenta: {0}", ex.Message));

            }
        }
    }

        
}
