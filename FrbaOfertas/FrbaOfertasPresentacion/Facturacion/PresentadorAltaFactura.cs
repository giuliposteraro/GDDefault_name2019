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

        
        public void BuscarDatos()
        {
            try
            {
                var maper = new MaperDeCompras();
                var repo = new RepositorioDeCompras(maper);
                _vista.Disponibles = repo.Buscar(_vista.ProveedorSeleccionado, _vista.FechaDesde, _vista.FechaHasta);

                //busco el siguiente numero de factura disponible
                var maperf = new MaperDeFacturas();
                var repof = new RepositorioDeFacturas(maperf);

                _vista.Numero = repof.ObteneSiguienteNroFactura();

                calcularTotales();
            }
            catch (Exception ex)
            {
                _vista.MostrarMensaje(string.Format("Se produjo una excepción al buscar las compras: {0}", ex.Message));
            }
        }

   
        private void calcularTotales()
        {
            if (_vista.Disponibles == null || !_vista.Disponibles.Any())
                _vista.Total = 0;
            else
                _vista.Total = _vista.Disponibles.Sum(x => x.Monto * x.Cantidad);
        }

        
        public void CambioFiltros()
        {
            _vista.Disponibles = new List<Compra>();
            calcularTotales();
        }

        public bool Guardar()
        {
            Factura facturaAGuardar = this.ObtenerDesdeVista();
            if (!this.ValidarGuardar())
                return false;

            try
            {
                //mando a guardar            
                var maper = new MaperDeFacturas();
                var repo = new RepositorioDeFacturas(maper);

                repo.Guardar(facturaAGuardar);

                _vista.MostrarMensaje(string.Format("La factura se genero con éxito, con el número: {0}, por un monto de {1}",facturaAGuardar.Numero_Fact, facturaAGuardar.Total_Fact));
                return true;
            }
            catch (Exception ex)
            {
                _vista.MostrarMensaje(string.Format("Se produjo una excepción al crear la nueva oferta: {0}", ex.Message));
                return false;
            }
        }

        private Factura ObtenerDesdeVista()
        {
            Factura f = new Factura();
            f.Proveedor = _vista.ProveedorSeleccionado;
            f.Numero_Fact = _vista.Numero;
            f.Tipo_Fact = "A";
            f.Total_Fact = _vista.Total;
            f.Fecha_Fact = _vista.FechaFactura;

            foreach (Compra c in _vista.Disponibles)
            {
                DetalleDeFactura d = new DetalleDeFactura();
                d.Id_Compra = c.Id_Compra;
                d.Monto = c.Monto;
                d.Cantidad = c.Cantidad;

                f.AgregarDetalle(d);
            }
            return f;
        }

        public bool ValidarGuardar()
        {

            if (_vista.Disponibles == null || !_vista.Disponibles.Any())
            {
                _vista.MostrarMensaje("Debe seleccionar al menos una compra para componer la factura");
            }

            return true;
        }
    }
}
