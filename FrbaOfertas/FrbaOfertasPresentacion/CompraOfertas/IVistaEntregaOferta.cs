using FrbaOfertasPresentacion.bases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrbaOfertasPresentacion.CompraOfertas
{
    public interface IVistaEntregaOferta : IVistaBase
    {
        List<Negocio.Entidades.Cliente> Clientes { get; set; }

        void MostrarAlerta(bool p);

        Negocio.Entidades.Cliente ClienteSeleccionado { get; set; }

        DateTime Fecha { get; set; }

        string Codigo { get; set; }
    }
}
