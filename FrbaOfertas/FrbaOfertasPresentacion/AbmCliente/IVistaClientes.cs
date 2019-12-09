using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Negocio.Entidades;
using FrbaOfertasPresentacion.bases;

namespace FrbaOfertasPresentacion.AbmCliente
{
    public interface IVistaClientes : IVistaBase
    {
        string Nombre { get; set; }

        string Apellido { get; set; }

        List<Cliente> Clientes { get; set; }


        int DNI { get; set; }

        string email { get; set; }
    }
}
