using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Negocio.Entidades;

namespace FrbaOfertasPresentacion.AbmCliente
{
    public interface IVistaClientes
    {
        string Nombre { get; set; }

        string Apellido { get; set; }

        List<Cliente> Clientes { get; set; }
    }
}
