using Negocio.Entidades;
using Negocio.Repositorios;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrbaOfertasPresentacion.Facturacion
{
    public class PresentadorAltaFactura
    {
        private readonly IVistaAltaFactura _vista;

        public PresentadorAltaFactura(IVistaAltaFactura vista)
        {
            _vista = vista;

        }

        public void Posicionar(Negocio.Entidades.Proveedor proveedor)
        {
            try
            {
                //Global.SessionUsuario

                var maper = new MaperDeProveedores();
                var repo = new RepositorioDeProveedores(maper);
                //busco todos los proveedores para completar el combo
                List<Proveedor> proveedores = repo.Buscar();
                _vista.proveedores = proveedores.OrderBy(x => x.ToString()).ToList();

                //cargo la fecha desde hace un mes
                _vista.FechaDesde = DateTime.Now.Date.AddMonths(-1);
                _vista.FechaHasta = DateTime.Now.Date.AddDays(1).AddMilliseconds(-1);
                _vista.FechaFactura = DateTime.Parse(ConfigurationManager.AppSettings["FechaDelDia"]);
            }
            catch (Exception ex)
            {
                _vista.MostrarMensaje(string.Format("Se produjo una excepción al posicionar la ventana: {0}", ex.Message));
            }
        }

        public void ObtenerPaginado(int cantidadPorPagina, int paginaActual)
        {
            try
            {
                if (proveedorBusqueda == null || !this.proveedorBusqueda.Equals(_vista.ProveedorSeleccionado) || this.fechaDBusqueda != _vista.FechaDesde || this.fechaHBusqueda != _vista.FechaHasta )
                    cargarDatosParaBusqueda();

                var maper = new MaperDeCompras();
                var repo = new RepositorioDeCompras(maper);

                _vista.Disponibles = repo.ObtenerPaginado(this.proveedorBusqueda, this.fechaDBusqueda, this.fechaHBusqueda, cantidadPorPagina, paginaActual);
            }
            catch (Exception ex)
            {
                _vista.MostrarMensaje(string.Format("Se produjo una excepción al buscar las compras: {0}", ex.Message));
            }
        }

        public void BuscarDatos(int cantidadPorPagina)
        {
            try
            {
                var maper = new MaperDeCompras();
                var repo = new RepositorioDeCompras(maper);
                int cantidadItems = repo.ContarItems(_vista.ProveedorSeleccionado,  _vista.FechaDesde, _vista.FechaHasta);
                _vista.SetarTotalItemsEnGrill(cantidadItems);

                cargarDatosParaBusqueda();

                //busco los items paginados
                this.ObtenerPaginado(cantidadPorPagina, 1);

                //busco el siguiente numero de factura disponible


            }
            catch (Exception ex)
            {
                _vista.MostrarMensaje(string.Format("Se produjo una excepción al buscar las compras: {0}", ex.Message));
            }
        }

        private void cargarDatosParaBusqueda()
        {
            this.proveedorBusqueda = _vista.ProveedorSeleccionado;
            this.fechaDBusqueda = _vista.FechaDesde;
            this.fechaHBusqueda = _vista.FechaHasta;
        }

        private Proveedor proveedorBusqueda { get; set; }

        private DateTime fechaDBusqueda { get; set; }

        private DateTime fechaHBusqueda { get; set; }

        public void AgegarItems()
        {
            if (_vista.ItemsSeleccionados == null || !_vista.ItemsSeleccionados.Any())
            {
                _vista.MostrarMensaje("debe seleccionar uno o más items para agregar");
                return;
            }
            if( _vista.ComprasElegidas == null)
                _vista.ComprasElegidas = new List<Compra>();

            
            _vista.ComprasElegidas = _vista.ItemsSeleccionados.Union(_vista.ComprasElegidas).ToList();
            calcularTotales();
        }

        private void calcularTotales()
        {
            if (_vista.ComprasElegidas == null || !_vista.ComprasElegidas.Any())
                _vista.Total = 0;
            else
                _vista.Total = _vista.ComprasElegidas.Sum(x => x.Monto * x.Cantidad);
        }

        public void QuitarItems()
        {
            if (_vista.ItemsElegidosSeleccionados == null || !_vista.ItemsElegidosSeleccionados.Any())
            {
                _vista.MostrarMensaje("debe seleccionar uno o más items para quitar");
                return;
            }

            List<Compra> elegidas = _vista.ComprasElegidas;
            _vista.ComprasElegidas = elegidas.Where(x => !_vista.ItemsElegidosSeleccionados.Contains(x)).ToList();
            calcularTotales();
        }

        public void CambioFiltros()
        {
            _vista.ComprasElegidas = new List<Compra>();
            _vista.Disponibles = new List<Compra>();
        }
    }
}
