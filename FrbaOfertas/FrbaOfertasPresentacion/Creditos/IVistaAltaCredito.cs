using FrbaOfertasPresentacion.bases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrbaOfertasPresentacion.Creditos
{
    public interface IVistaAltaCredito : IVistaBase
    {
        void MostrarAlerta(bool p);

        List<Negocio.Entidades.Cliente> Clientes { get; set; }

        Negocio.Entidades.Cliente ClienteSeleccionado { get; set; }

        DateTime FechaDelDia { get; set; }

        Negocio.Entidades.Cliente Cliente { get; set; }

        bool HabilitarCombo { set; }

        string Monto { get; set; }

        string Tarjeta { get; set; }

        List<Negocio.Entidades.TipoDePago> TiposDePago { get; set; }

        string TotalCreditoCliente { get; set; }

        string Detalle { get; set; }

        Negocio.Entidades.TipoDePago TiposDePagoSeleccionado { get; set; }
    }
}
