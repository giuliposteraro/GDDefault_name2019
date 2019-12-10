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
            _vista.Nombre = Global.SessionUsuario.Usuario_Cuenta;
        }
        public void ActualizarVista()
        {
            var cli = _vista.Proveedores;
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

    }

        
}
