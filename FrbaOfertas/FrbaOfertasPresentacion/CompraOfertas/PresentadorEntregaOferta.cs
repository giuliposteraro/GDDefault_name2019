using Negocio.Base;
using Negocio.Entidades;
using Negocio.Repositorios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrbaOfertasPresentacion.CompraOfertas
{
    public class PresentadorEntregaOferta
    {
        private readonly IVistaEntregaOferta _vista;

        public PresentadorEntregaOferta(IVistaEntregaOferta vista)
        {
            _vista = vista;

        }

        public void Posicionar()
        {
            try
            {
                var maper = new MaperDeProveedores();
                var repo = new RepositorioDeProveedores(maper);
                Usuario Usuario = Global.SessionUsuario;
                Proveedor _proveedor = repo.ObtenerDelUsuario(Usuario.Id_Usuario);

                var maperClie = new MaperDeClientes();
                var repoClie = new RepositorioDeClientes(maperClie);
                List<Cliente> clientes = repoClie.Buscar();
                _vista.Clientes = clientes.OrderBy(x => x.ToString()).ToList();

                //en caso de que el usuario actual no tenga proveedor muestro una alerta            
                _vista.MostrarAlerta(_proveedor == null);
                if (_proveedor != null)
                    this.provee = _proveedor;
            }
            catch (Exception ex)
            {
                _vista.MostrarMensaje(string.Format("Se produjo una excepción al levantar la pantalla: {0}", ex.Message));
            }
        }

        private Proveedor provee { get; set; }

        /// <summary>
        /// validaciones antes de realizar el canje
        /// </summary>
        /// <returns></returns>
        public bool ValidarGuardar()
        {
            try
            {
                StringBuilder sb = new StringBuilder();

                if (this.provee == null)
                    sb.AppendLine("Su usuario no tiene un proveedor asociado y no puede hacer entrega de las ofertas");

                //busco la compra para validar el canje
                var maper = new MaperDeCompras();
                var repo = new RepositorioDeCompras(maper);
                Compra c = repo.ObtenerCompraPorCupon(_vista.Codigo);

                if (c == null)
                    sb.AppendLine("El número de cupón ingresado no se corresponde con ninguna compra");
                else
                {
                    //validaciones sobre la compra en si
                    if (c.Estado_Cupon == estadoCupon.entregado)
                        sb.AppendLine("El cupon ya fue entregado");

                    if (c.Id_Cliente != _vista.ClienteSeleccionado.Id_Cliente)
                        sb.AppendLine("El cliente para el cual intenta canjear el cupón no es el mismo que realizo la compra");

                    if (c.Oferta == null)
                    {
                        _vista.MostrarMensaje("Se produjo un problema al intentar obtener la oferta asociada a la compra, consulte con el administrador");
                        return false;
                    }

                    if (c.Oferta.Fecha_Venc_Of < _vista.Fecha)
                        sb.AppendLine("La vigencia de la oferta ya expiro");

                }

                if (sb.Length > 0)
                {
                    _vista.MostrarMensaje(sb.ToString());
                    return false;
                }
                this.Compra = c;
                return true;
            }
            catch (Exception ex)
            {
                _vista.MostrarMensaje(string.Format("Se produjo una excepción al ejecutar las validaciones: {0}", ex.Message));
                return false;
            }
        }

        /// <summary>
        /// aplicar canje en base de datos.
        /// </summary>
        /// <returns></returns>
        public bool Guardar()
        {
            try
            {
                this.TomarDatosDeLaVista();
                var maper = new MaperDeCompras();
                var repo = new RepositorioDeCompras(maper);
                List<string> propertiesAActualizar = new List<string> { ("Fecha_Entrega"), ("Estado_Cupon") };
                repo.ActualizarEntidad(Compra, propertiesAActualizar, "Id_Compra");

                _vista.MostrarMensaje("Cupón canjeado exitosamente");
                return true;
            }
            catch (Exception ex)
            {
                _vista.MostrarMensaje(string.Format("Se produjo una excepción al ejecutar el canje: {0}", ex.Message));
                return false;
            }
        }

        private void TomarDatosDeLaVista()
        {
            this.Compra.Fecha_Entrega = _vista.Fecha;
            this.Compra.Estado_Cupon = estadoCupon.entregado;
        }

        public void Limpiar()
        {
            //pongo el primer cliente del combo como el seleccionado
            var clientesUno = _vista.Clientes.FirstOrDefault();
            _vista.ClienteSeleccionado = clientesUno;
            _vista.Fecha = DateTime.Now;
            _vista.Codigo = "";
        }

        private Compra Compra { get; set; }
    }
}
