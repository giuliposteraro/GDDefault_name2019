using FrbaOfertasPresentacion.bases;
using Negocio.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrbaOfertasPresentacion.Creditos
{
    public interface IVistaCreditos : IVistaBase
    {

        List<Credito> Creditos { get; set; }
        List<Cliente> clientes { get; set; }
        Cliente ClienteSeleccionado { get; set; }
        List<Negocio.Entidades.TipoDePago> TiposDePago { get; set; }
        Negocio.Entidades.TipoDePago TiposDePagoSeleccionado { get; set; }
        DateTime FechaDesde { get; set; }
        DateTime fechaHasta { get; set; }

        void SetarTotalItemsEnGrill(int cantidadItems);
    }
}
