using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Negocio.Base;
using Negocio.Repositorios;
using System.Configuration;
using Negocio.Entidades;

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
                _vista.Credito = _cliente.Monto_Total_cred_Clie;
            }

            //seteo la fecha con la fecha del sistema
            _vista.fecha =  DateTime.Parse(ConfigurationManager.AppSettings["FechaDelDia"]);
        }

        public void ActualizarVista(Negocio.Entidades.Oferta oferta)
        {
            _vista.Oferta = oferta;
            _vista.Descripcion = oferta.Descripcion_Of;
            _vista.Codigo = oferta.Codigo_Of;
            _vista.Stock = oferta.Cant_Disp_Oferta;
            _vista.Maximo = oferta.Maximo_Por_Compra;
            _vista.Plista = oferta.Precio_Lista;
            _vista.POferta = oferta.Precio_Oferta;

        }

        /// <summary>
        /// validaciones a realizar previo al guardado
        /// </summary>
        /// <returns></returns>
        public bool ValidarGuardar()
        {
            StringBuilder sb = new StringBuilder();
            //valido el usuario a utilizar
            if (_vista.Cliente == null)
                sb.AppendLine("Su usuario no tiene un cliente asociado para realizar compras");

            if (_vista.Cliente != null && !_vista.Cliente.Habilitado)
                sb.AppendLine("Su cliente no esta habilitado para realizar compras.");

            if (_vista.Credito < _vista.POferta * _vista.Cantidad)
                sb.AppendLine("No posee de suficiente credito para realizar la compra");

            if (_vista.Cantidad > _vista.Maximo )
                sb.AppendLine("La cantidad a comprar supera el máximo permitido por compra");

            if (_vista.Cantidad > _vista.Stock)
                sb.AppendLine("La cantidad a comprar supera el stock disponible");

            if (sb.Length > 0)
            {
                _vista.MostrarMensaje(sb.ToString());
                return false;
            }

            return true;
        }


        /// <summary>
        /// guarda la compra y actualiza la oferta y el cliente restando los montos correspondientes.
        /// </summary>
        /// <returns></returns>
        public bool Guardar()
        {
            try
            {
                Compra compra = ObtenerDatosDeLaVista();
                //mando a guardar            
                var maper = new MaperDeCompras();
                var repo = new RepositorioDeCompras(maper);

                repo.Guardar(compra);

                _vista.MostrarMensaje(string.Format("La compra se realizo Exitosamente, su numero de cupon es : {0}", compra.Codigo_Cupon));
                return true;
            }
            catch (Exception ex)
            {
                _vista.MostrarMensaje(string.Format("Se produjo una excepción al guardar la compra: {0}", ex.Message));
                return false;
            }
        }

        private Compra ObtenerDatosDeLaVista()
        {
            Compra compra = new Compra();
            compra.Cliente = _vista.Cliente;
            compra.Proveedor = _vista.Oferta.Proveedor;
            compra.Oferta = _vista.Oferta;
            compra.Fecha_Compra = _vista.fecha;
            compra.Codigo_Cupon= GenerarCodigo();
            compra.Estado_Cupon = estadoCupon.creado;
            compra.Cantidad = _vista.Cantidad;
            compra.Monto = _vista.POferta;
            return compra;
        }

        public void Limpiar()
        {
            _vista.Oferta = null;
            _vista.Descripcion = "";
            _vista.Codigo = "";
            _vista.Stock = 0;
            _vista.Maximo = 0;
            _vista.Plista = 0;
            _vista.POferta = 0;
            _vista.Cantidad = 1;

            //recargo el cliente para actualizar el valor del credito
            int idUsuario = Global.SessionUsuario.Id_Usuario;
            var maper = new MaperDeClientes();
            var repo = new RepositorioDeClientes(maper);
            var _cliente = repo.ObtenerDelUsuario(idUsuario);
            if (_cliente != null)
            {
                _vista.Cliente = _cliente;
                _vista.NombreCliente = _cliente.ToString();
                _vista.Credito = _cliente.Monto_Total_cred_Clie;
            }
        }

        private string GenerarCodigo()
        {
            int longitud = 10;
            string caracteres = "ABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890";
            StringBuilder res = new StringBuilder();
            Random rnd = new Random();
            while (0 < longitud--)
            {
                res.Append(caracteres[rnd.Next(caracteres.Length)]);
            }
            return res.ToString();
        }
    }
}
