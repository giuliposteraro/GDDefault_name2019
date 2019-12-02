using FrbaOfertasPresentacion.bases;
using Negocio.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrbaOfertasPresentacion.PublicacionOfertas
{
    public interface IVistaPublicacionDeOfertas : IVistaBase
    {
        void SetarTotalItemsEnGrill(int cantidadItems);

        Proveedor ProveedorSeleccionado { get; set; }

        string Codigo { get; set; }

        DateTime FechaDesde { get; set; }

        DateTime FechaHasta { get; set; }

        List<Oferta> Ofertas { get; set; }

        List<Proveedor> proveedores { get; set; }

        void MostrarAlerta(bool p);

        void HabilitarCombo(bool p);
    }
}
