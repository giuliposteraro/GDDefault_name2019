using FrbaOfertasPresentacion.bases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrbaOfertasPresentacion.AbmProveedor
{
    public interface IVistaABMProveedor : IVistaBase
    {
        void BloquearPantalla();

        string Texto { get; set; }

        string RazonSocial { get; set; }

        string Mail_Proveedor { get; set; }

        string Telefono_Prov { get; set; }

        string Cuit_Prov { get; set; }

        string Rubro_Prov { get; set; }

        string Nom_Contacto_Prov { get; set; }

        string Numero_Dir { get; set; }

        string Piso_Dir { get; set; }

        string Depto_Dir { get; set; }

        string Localidad_Dir { get; set; }

        string Ciudad_Dir { get; set; }

        string Calle_Dir { get; set; }

        string Codigo_Postal_Dir { get; set; }

        string BotonNombre { get; set; }
    }
}
