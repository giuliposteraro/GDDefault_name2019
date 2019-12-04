using FrbaOfertasPresentacion.bases;
using Negocio.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrbaOfertasPresentacion.CompraOfertas
{
    public interface IVistaCompraOferta: IVistaBase
    {

        void MostrarAlerta(bool p);

        Negocio.Entidades.Cliente Cliente { get; set; }

        string NombreCliente { get; set; }

        Oferta Oferta { get; set; }

        decimal Credito { get; set; }

        DateTime fecha { get; set; }

        string Descripcion { get; set; }

        string Codigo { get; set; }

        int Stock { get; set; }

        int Maximo { get; set; }

        decimal Plista { get; set; }

        decimal POferta { get; set; }

        int Cantidad { get; set; }
    }
}
