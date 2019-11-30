using Negocio.Entidades;
using Negocio.Repositorios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrbaOfertasPresentacion.Creditos
{
    public class PresentadorCreditos
    {
        private readonly IVistaCreditos _vista;
        private Cliente _clienteOriginal;
        private Cliente clienteBusqueda { get; set; }
        private TipoDePago tipoPagoBusqueda { get; set; }
        private DateTime fechaDBusqueda { get; set; }
        private DateTime fechaHBusqueda { get; set; }

        public PresentadorCreditos(IVistaCreditos vista)
        {
            _vista = vista;

        }

        public void Posicionar(Cliente cliente) {
            var maper = new MaperDeClientes();
            var repo = new RepositorioDeClientes(maper);
            //busco todos los clientes para completar el combo
            List<Cliente> clientes = repo.Buscar();
            _vista.clientes = clientes.OrderBy(x=> x.ToString()).ToList();
            //el cliente que se paso por parametro como el seleccionado
            _vista.ClienteSeleccionado = cliente;
            _clienteOriginal = cliente;

            //cargo la fecha desde hace un mes
            _vista.FechaDesde = DateTime.Now.AddMonths(-1);

            //busco los tipos de pagos
            List<TipoDePago> pagos = TipoDePago.ObtenerTodos();
            pagos.Insert(0, new TipoDePago { Id = 0, Nombre = "Todos" });
            _vista.TiposDePago = pagos;

        }

        public void BuscarDatos(int cantidadPorPagina)
        {
            var maper = new MaperDeCreditos();
            var repo = new RepositorioDeCreditos(maper);
            int cantidadItems = repo.ContarItems(_vista.ClienteSeleccionado, _vista.TiposDePagoSeleccionado, _vista.FechaDesde, _vista.fechaHasta );
            _vista.SetarTotalItemsEnGrill(cantidadItems);

            cargarDatosParaBusqueda();

            //busco los items paginados
            this.ObtenerPaginado(cantidadPorPagina, 1);
        }

        private void cargarDatosParaBusqueda()
        {
            this.clienteBusqueda = _vista.ClienteSeleccionado;
            this.tipoPagoBusqueda = _vista.TiposDePagoSeleccionado;
            this.fechaDBusqueda =_vista.FechaDesde;
            this.fechaHBusqueda = _vista.fechaHasta;

        }

        public void ObtenerPaginado(int cantidadPorPagina, int paginaActual)
        {
            if (clienteBusqueda == null)
                cargarDatosParaBusqueda();

            var maper = new MaperDeCreditos();
            var repo = new RepositorioDeCreditos(maper);

            _vista.Creditos = repo.ObtenerPaginado(this.clienteBusqueda, this.tipoPagoBusqueda, this.fechaDBusqueda, this.fechaHBusqueda, cantidadPorPagina, paginaActual);
        }

        public void LimpiarDatos()
        {
            _vista.ClienteSeleccionado = _clienteOriginal;
            _vista.TiposDePagoSeleccionado = new TipoDePago { Id = 0, Nombre = "Todos" };
            _vista.FechaDesde = DateTime.Now.AddMonths(-1);
            _vista.fechaHasta = DateTime.Now;
        }


    }
}
