using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Negocio.Entidades;
using FrbaOfertasPresentacion.bases;

namespace FrbaOfertasPresentacion.AbmProveedor
{
    public interface IVistaProveedor : IVistaBase
    {
        string Nombre { get; set; }

        string Razon_Social { get; set; }

        string Cuit { get; set; }

        string Mail { get; set; }

        List<Proveedor> Proveedores { get; set; }

    }
}
