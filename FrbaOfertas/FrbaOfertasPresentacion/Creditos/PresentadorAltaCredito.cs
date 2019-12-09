using Negocio.Base;
using Negocio.Entidades;
using Negocio.Repositorios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace FrbaOfertasPresentacion.Creditos
{
    public class PresentadorAltaCredito
    {
        private readonly IVistaAltaCredito _vista;

        public PresentadorAltaCredito(IVistaAltaCredito vista)
        {
            _vista = vista;
        }

        public void Posicionar() {
            ActualizarVista();

            _vista.FechaDelDia = DateTime.Parse(ConfigurationManager.AppSettings["FechaDelDia"]);
            _vista.HabilitarCombo = (from r in Global.SessionUsuario.RolDelUsuario where r.Id_Rol == 1 select r).Any();

            //cargo los tipos de pagos
            _vista.TiposDePago = TipoDePago.ObtenerTodos();
        }

        public bool ValidarGuardar()
        {
            if (_vista.Cliente == null && !(from r in Global.SessionUsuario.RolDelUsuario where r.Id_Rol == 1 select r).Any())
            {
                _vista.MostrarMensaje("Su usuario no tiene asociado a un cliente, ni permisos de administrador, por lo que, no puede cargar créditos.");
                return false;
            }

            if (!_vista.Cliente.Habilitado)
            {
                _vista.MostrarMensaje("Su cliente no esta habilitado para cargar créditos.");
                return false;
            }

            StringBuilder sb = new StringBuilder();
            if (_vista.Monto.EsNuloOVacio())
                sb.AppendLine("-El monto debe ser mayor a 0");

            if (_vista.Tarjeta.Length != 16)
                sb.AppendLine("-Cantidad de Digitos de la tarjeta incorrectos");

            if (!sb.ToString().EsNuloOVacio())
            {
                _vista.MostrarMensaje(sb.ToString());
                return false;
            }


            return true;
        }

        public void Guardar()
        {
            if (!ValidarGuardar())
                return;

            var maper = new MaperDeCreditos();
            var repo = new RepositorioDeCreditos(maper);

            try
            {
                //traigo los datos desde la vista          
                var credito = this.ObtenerDesdeVista();
                //guara
                repo.InsertarNuevo(credito);
                _vista.MostrarMensaje("Crédito agregado correctamente");
            }
            catch (Exception ex)
            {
                _vista.MostrarMensaje(string.Format("Se produjo una excepción al agregar el nuevo crédito: {0}", ex.Message));
                return;
            }
            this.ActualizarVista();
            this.LimpiarDatos();
        }

        private void LimpiarDatos()
        {
            _vista.Monto = "0";
            _vista.Tarjeta = "0";
            _vista.Detalle = "";
            _vista.TiposDePagoSeleccionado = TipoDePago.TarjetaDeCredito;
        }

        private void ActualizarVista()
        {
            Usuario Usuario = Global.SessionUsuario;
            var maper = new MaperDeClientes();
            var repo = new RepositorioDeClientes(maper);
            var _cliente = repo.ObtenerDelUsuario(Usuario.Id_Usuario);

            List<Cliente> clientes = repo.Buscar();
            _vista.Clientes = clientes.OrderBy(x => x.ToString()).ToList();
            //en caso de que el usuario actual no tenga cliente 
            //(se puede dar si tiene el rol cliente pero no un cliente creado, muestro una alerta en pantalla)
            _vista.MostrarAlerta(_cliente == null);
            if (_cliente != null)
            {
                _vista.Cliente = _cliente;
                _vista.ClienteSeleccionado = _cliente; 
            }
        }

        private Credito ObtenerDesdeVista()
        {
            var credito = new Credito();
            credito.Cliente = _vista.ClienteSeleccionado;
            credito.Carga_Fecha = _vista.FechaDelDia;
	        credito.Carga_Cred = System.Convert.ToInt32(_vista.Monto);
	        credito.Tarjeta  = _vista.Tarjeta;
	        credito.Detalle  = _vista.Detalle;
            credito.Tipo_Pago = _vista.TiposDePagoSeleccionado.Nombre;

            return credito;
        }

        public bool ValidarVerHistorico()
        {
            if (_vista.Cliente == null && !(from r in Global.SessionUsuario.RolDelUsuario where r.Id_Rol == 1 select r).Any())
            {
                _vista.MostrarMensaje("Su usuario no esta asociado a un cliente y no tiene permisos de administrador, por lo que no puede ver historicos.");
                return false;
            }
           
            return true;
        }

        public void DefinirCreditoActual()
        {
            var cliente = _vista.ClienteSeleccionado;
            if (cliente == null)
                return;

            _vista.TotalCreditoCliente = cliente.Monto_Total_cred_Clie.ToString();
        }
    }
}
