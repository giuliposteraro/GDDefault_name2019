using FrbaOfertasPresentacion.bases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrbaOfertasPresentacion.Facturacion
{
    public interface IVistaAltaFactura : IVistaBase
    {
        List<Negocio.Entidades.Proveedor> proveedores { get; set; }

        DateTime FechaDesde { get; set; }

        DateTime FechaHasta { get; set; }

        DateTime FechaFactura { get; set; }

        void SetarTotalItemsEnGrill(int cantidadItems);

        Negocio.Entidades.Proveedor ProveedorSeleccionado { get; set; }

        List<Negocio.Entidades.Compra> Disponibles { get; set; }

        List<Negocio.Entidades.Compra> ComprasElegidas { get; set; }

        List<Negocio.Entidades.Compra> ItemsSeleccionados { get; set; }

        List<Negocio.Entidades.Compra> ItemsElegidosSeleccionados { get; set; }

        decimal Total { get; set; }
    }
}
