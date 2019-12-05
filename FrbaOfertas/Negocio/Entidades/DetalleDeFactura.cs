using Negocio.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio.Entidades
{
    [Serializable]
    public class DetalleDeFactura : EntidadBase
    {
        public int Id_Detalle { get; set; }
        public int Id_Compra {get; set;}
        public int Id_Factura { get; set; }
        public int Cantidad {get; set;}
        public decimal Monto {get; set;}
       
    }
}
