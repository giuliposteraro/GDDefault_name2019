using Negocio.Repositorios;
using Negocio.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrbaOfertasPresentacion.AbmProveedor
{
    public class PresentadorProveedor
    {
        private readonly IVistaProveedor _vista;

        public PresentadorProveedor(IVistaProveedor vista)
        {
            _vista = vista;
            
        }
        public void IniciarVista()
        {
            //_vista.Nombre = Global.SessionUsuario.Usuario_Cuenta;
        }

        public void Buscar()
        {
            try
            {
                var maper = new MaperDeProveedores();
                var repo = new RepositorioDeProveedores(maper);

                _vista.Proveedores = repo.BuscarConFiltros(_vista.Nombre, _vista.Razon_Social, _vista.Cuit, _vista.Mail);
            }            
            catch (Exception ex)
            {
                _vista.MostrarMensaje(ex.Message);
            }
        }


        public void LimpiarDatos()
        {
            _vista.Nombre = "";
            _vista.Razon_Social = "";
            _vista.Cuit = "";
            _vista.Mail = "";
        }

        public bool Activar()
        {
            try
            {
                //mando a guardar            
                var maper = new MaperDeProveedores();
                var repo = new RepositorioDeProveedores(maper);

                if (_vista.ProveedorSeleccionado == null)
                {
                    _vista.MostrarMensaje("debe seleccionar un proveedor a activar.");
                    return false;
                }

                if (_vista.ProveedorSeleccionado.Habilitado)
                {
                    _vista.MostrarMensaje("El proveedor ya se encuentra habilitado.");
                    return false;
                }

                _vista.ProveedorSeleccionado.Habilitado = true;
                List<string> propertiesAActualizar = new List<string> { ("Habilitado") };
                repo.ActualizarEntidad(_vista.ProveedorSeleccionado, propertiesAActualizar, "Id_Proveedor");

                _vista.MostrarMensaje("activación realizada con éxito.");
                return true;
            }
            catch (Exception ex)
            {
                _vista.MostrarMensaje(string.Format("Se produjo una excepción al realizar la activación sobre el proveedor: {0}", ex.Message));
                return false;
            }
        }
    }

        
}
