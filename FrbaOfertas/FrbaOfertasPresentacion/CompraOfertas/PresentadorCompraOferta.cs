using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Negocio.Base;
using Negocio.Repositorios;

namespace FrbaOfertasPresentacion.CompraOfertas
{
    public class PresentadorCompraOferta
    {
        private readonly IVistaCompraOferta _vista;

        public PresentadorCompraOferta(IVistaCompraOferta vista)
        {
            _vista = vista;

        }

        public void Posicionar()
        {
            //voy a buscar el cliente asociado al usuario actual y mostrarlo en la ventana de compras
            int idUsuario = Global.SessionUsuario.Id_Usuario;
            var maper = new MaperDeClientes();
            var repo = new RepositorioDeClientes(maper);
            var _cliente = repo.ObtenerDelUsuario(idUsuario);

            //en caso de que el usuario actual no tenga cliente 
            //(se puede dar si tiene el rol cliente pero no un cliente creado, muestro una alerta en pantalla)
            _vista.MostrarAlerta(_cliente == null);
            if (_cliente != null)
            {
                _vista.Cliente = _cliente;
                _vista.NombreCliente = _cliente.ToString();

            }
        }
    }
}
