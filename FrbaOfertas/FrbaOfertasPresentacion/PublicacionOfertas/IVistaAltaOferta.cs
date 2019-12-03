using FrbaOfertasPresentacion.bases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrbaOfertasPresentacion.CompraOfertas
{
    public interface IVistaAltaOferta : IVistaBase
    {
        string Titulo { get; set; }

        List<Negocio.Entidades.Proveedor> proveedores { get; set; }

        void BloquearDatos();

        void HabilitarCombo(bool p);

        Negocio.Entidades.Proveedor proveedorSeleccionado { get; set; }

        string codigo { get; set; }

        DateTime fechaPublicacion { get; set; }

        DateTime fechaVencimiento { get; set; }

        string descripcion { get; set; }

        decimal precioOferta { get; set; }

        decimal precioLista { get; set; }

        int cantidadDisponible { get; set; }

        int cantidadMaxima { get; set; }
    }
}
