using Negocio.Entidades;
using Negocio.Repositorios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrbaOfertasPresentacion.Facturacion
{
    public class PresentadorListaFacturas
    {
        private readonly IVistaListaFacturas _vista;

        public PresentadorListaFacturas(IVistaListaFacturas vista)
        {
            _vista = vista;

        }


        public void ObtenerPaginado(int cantidadPorPagina, int paginaActual)
        {
            try
            {
                if (proveedorBusqueda == null || !this.proveedorBusqueda.Equals(_vista.ProveedorSeleccionado) || this.fechaDBusqueda != _vista.FechaDesde || this.fechaHBusqueda != _vista.FechaHasta || this.Numero != _vista.Numero )
                    cargarDatosParaBusqueda();

                var maper = new MaperDeFacturas();
                var repo = new RepositorioDeFacturas(maper);

                _vista.Facturas = repo.ObtenerPaginado(this.proveedorBusqueda, this.Numero, this.fechaDBusqueda, this.fechaHBusqueda, cantidadPorPagina, paginaActual);
            }
            catch (Exception ex)
            {
                _vista.MostrarMensaje(string.Format("Se produjo una excepción al buscar las ofertas: {0}", ex.Message));
            }
        }

        public void Posicionar()
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
            }
            catch (Exception ex)
            {
                _vista.MostrarMensaje(string.Format("Se produjo una excepción al posicionar la ventana: {0}", ex.Message));
            }
        }

        public void BuscarDatos(int cantidadPorPagina)
        {
            try
            {
                var maper = new MaperDeFacturas();
                var repo = new RepositorioDeFacturas(maper);
                int cantidadItems = repo.ContarItems(_vista.ProveedorSeleccionado, _vista.Numero, _vista.FechaDesde, _vista.FechaHasta);
                _vista.SetarTotalItemsEnGrill(cantidadItems);

                cargarDatosParaBusqueda();

                //busco los items paginados
                this.ObtenerPaginado(cantidadPorPagina, 1);
            }
            catch (Exception ex)
            {
                _vista.MostrarMensaje(string.Format("Se produjo una excepción al buscar las ofertas: {0}", ex.Message));
            }
        }

        private void cargarDatosParaBusqueda()
        {
            this.proveedorBusqueda = _vista.ProveedorSeleccionado;
            this.Numero = _vista.Numero;
            this.fechaDBusqueda = _vista.FechaDesde;
            this.fechaHBusqueda = _vista.FechaHasta;
        }

        private Proveedor proveedorBusqueda { get; set; }

        private string Numero { get; set; }

        private DateTime fechaDBusqueda { get; set; }

        private DateTime fechaHBusqueda { get; set; }

        public void LimpiarDatos()
        {
            _vista.ProveedorSeleccionado = _vista.proveedores.FirstOrDefault();
            this.Numero = "";
            _vista.FechaDesde = DateTime.Now.Date.AddMonths(-1);
            _vista.FechaHasta = DateTime.Now.Date.AddDays(1).AddMilliseconds(-1);
        }
    }
}
