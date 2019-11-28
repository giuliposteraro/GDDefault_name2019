using FrbaOfertasPresentacion.bases;
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
    }
}
