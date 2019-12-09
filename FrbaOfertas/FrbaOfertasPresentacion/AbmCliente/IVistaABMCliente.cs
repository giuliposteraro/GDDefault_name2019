using FrbaOfertasPresentacion.bases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrbaOfertasPresentacion.AbmCliente
{
    public interface IVistaABMCliente : IVistaBase
    {
        string Texto { get; set; }

        void BloquearPantalla();

        string NombreCliente { get; set; }

        string ApellidoCliente { get; set; }

        int DNICliente { get; set; }

        string MailCliente { get; set; }

        string TelCliente { get; set; }

        DateTime FechaCliente { get; set; }

        string Numero_Dir { get; set; }

        string Piso_Dir { get; set; }

        string Depto_Dir { get; set; }

        string Localidad_Dir { get; set; }

        string Ciudad_Dir { get; set; }

        string Calle_Dir { get; set; }

        string Codigo_Postal_Dir { get; set; }
    }
}
