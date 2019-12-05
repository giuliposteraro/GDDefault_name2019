using FrbaOfertasPresentacion.bases;
using Negocio.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrbaOfertasPresentacion.Facturacion
{
    public interface IVistaListaFacturas : IVistaBase
    {
        void SetarTotalItemsEnGrill(int cantidadItems);

        Proveedor ProveedorSeleccionado { get; set; }

        string Numero { get; set; }

        DateTime FechaDesde { get; set; }

        DateTime FechaHasta { get; set; }

        List<Factura> Facturas { get; set; }

        List<Proveedor> proveedores { get; set; }
    }
}
