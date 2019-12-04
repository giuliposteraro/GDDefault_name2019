using Negocio.Base;
using Negocio.Entidades;
using Negocio.Repositorios;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrbaOfertasPresentacion.PublicacionOfertas
{
    public class PresentadorPublicacionDeOfertas
    {
        private readonly IVistaPublicacionDeOfertas _vista;

        public PresentadorPublicacionDeOfertas(IVistaPublicacionDeOfertas vista)
        {
            _vista = vista;

        }

        public void ObtenerPaginado(int cantidadPorPagina, int paginaActual)
        {
            try
            {
                if (proveedorBusqueda == null || !this.proveedorBusqueda.Equals(_vista.ProveedorSeleccionado) || this.fechaDBusqueda != _vista.FechaDesde || this.fechaHBusqueda != _vista.FechaHasta || this.codigoBusqueda != _vista.Codigo || this.fechaVhasta != _vista.FechaVHasta || this.fechaVDesde != _vista.FechaVDesde)
                    cargarDatosParaBusqueda();

                var maper = new MaperDeOfertas();
                var repo = new RepositorioDeOfertas(maper);

                _vista.Ofertas = repo.ObtenerPaginado(this.proveedorBusqueda, this.codigoBusqueda, this.fechaDBusqueda, this.fechaHBusqueda, this.fechaVDesde, this.fechaVhasta, cantidadPorPagina, paginaActual);
            }
            catch (Exception ex)
            {
                _vista.MostrarMensaje(string.Format("Se produjo una excepción al buscar las ofertas: {0}", ex.Message));
            }
        }

        public void BuscarDatos(int cantidadPorPagina)
        {
            try
            {
                var maper = new MaperDeOfertas();
                var repo = new RepositorioDeOfertas(maper);
                int cantidadItems = repo.ContarItems(_vista.ProveedorSeleccionado, _vista.Codigo, _vista.FechaDesde, _vista.FechaHasta, _vista.FechaVDesde, _vista.FechaVHasta);
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

        //limpia los datos de la pantalla
        public void LimpiarDatos()
        {
            _vista.ProveedorSeleccionado = _proveedorOriginal;
            _vista.Codigo = string.Empty;
            if (esSeleccion)
            {
                _vista.FechaHasta = DateTime.Parse(ConfigurationManager.AppSettings["FechaDelDia"]).AddDays(1).AddMilliseconds(-1);
                _vista.FechaVDesde = DateTime.Parse(ConfigurationManager.AppSettings["FechaDelDia"]);
            }
            else
            {
                _vista.FechaHasta = DateTime.Now.Date.AddDays(1).AddMilliseconds(-1);
                _vista.FechaVDesde = DateTime.Now.Date;
            }
            _vista.FechaDesde = DateTime.Now.Date.AddMonths(-1);
            _vista.FechaVHasta = DateTime.Now.Date.AddDays(1).AddMilliseconds(-1);
        }

        private void cargarDatosParaBusqueda()
        {
            this.proveedorBusqueda = _vista.ProveedorSeleccionado;
            this.codigoBusqueda = _vista.Codigo;
            this.fechaDBusqueda = _vista.FechaDesde;
            this.fechaHBusqueda = _vista.FechaHasta;
            this.fechaVDesde = _vista.FechaVDesde;
            this.fechaVhasta = _vista.FechaVHasta;
        }

        private Negocio.Entidades.Proveedor _proveedorOriginal { get; set; }

        private Negocio.Entidades.Proveedor proveedorBusqueda { get; set; }

        private string codigoBusqueda { get; set; }

        private DateTime fechaDBusqueda { get; set; }

        private DateTime fechaHBusqueda { get; set; }
        
        private DateTime fechaVhasta { get; set; }

        private DateTime fechaVDesde { get; set; }

        public void Posicionar()
        {
            this.esSeleccion = false;
            try 
            {
                //Global.SessionUsuario

                var maper = new MaperDeProveedores();
                var repo = new RepositorioDeProveedores(maper);
                //busco todos los proveedores para completar el combo
                List<Proveedor> proveedores = repo.Buscar();
                _vista.proveedores = proveedores.OrderBy(x => x.ToString()).ToList();
            
                //busco si hay un proveedor asociado al usuario que esta usando el sistema
                Usuario Usuario = Global.SessionUsuario;
                Proveedor _proveedor = repo.ObtenerDelUsuario(Usuario.Id_Usuario);
            
                //si no hay un proveedor asociado al cliente emito una alerta
                _vista.MostrarAlerta(_proveedor == null);

                //si hay un proveedor lo seteo como el seleccionado y como el original, sino tomo el primero de la lista como original y seleccionado
                if (_proveedor != null)
                {
                    _vista.ProveedorSeleccionado = _proveedor;
                    this._proveedorOriginal = _proveedor;
                }
                else
                {
                    _vista.ProveedorSeleccionado = proveedores.FirstOrDefault();
                    this._proveedorOriginal = proveedores.FirstOrDefault();
                }

                _vista.HabilitarCombo(_proveedor == null);
                //cargo la fecha desde hace un mes
                _vista.FechaDesde = DateTime.Now.Date.AddMonths(-1);
                _vista.FechaVDesde = DateTime.Now.Date.AddMonths(-1);
                _vista.FechaHasta = DateTime.Now.Date.AddDays(1).AddMilliseconds(-1);
                _vista.FechaVHasta = DateTime.Now.Date.AddDays(1).AddMilliseconds(-1);
            }
            catch (Exception ex)
            {
                _vista.MostrarMensaje(string.Format("Se produjo una excepción al posicionar la ventana: {0}", ex.Message));
            }

        }


        /// <summary>
        /// metodo propio para usar la ventana como seleccion de ofertas
        /// </summary>
        public void PosicionarParaSeleccion()
        {            
            this.Posicionar();
            _vista.HabilitarCombo(true);
            _vista.MostrarAlerta(false);
            _vista.MostrarBotonesSeleccion();

            //solo traera las ofertas que esten vigentes, es decir las que fueron publicadas hasta el dia de la fecha pero vencen luego de la fecha actual
            _vista.FechaHasta = DateTime.Parse(ConfigurationManager.AppSettings["FechaDelDia"]).AddDays(1).AddMilliseconds(-1);
            _vista.FechaDesde = _vista.FechaHasta.AddMonths(-1);
            _vista.FechaVDesde = DateTime.Parse(ConfigurationManager.AppSettings["FechaDelDia"]);
            _vista.FechaVHasta = _vista.FechaVDesde.AddMonths(1).AddDays(1).AddMilliseconds(-1);
            this.esSeleccion = true;
        }

        private bool esSeleccion { get; set; }

        
    }
}
