using Negocio.Base;
using Negocio.Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio.Repositorios
{
    public class MaperDeFacturas: MaperBase<Factura>
    {
        public MaperDeFacturas()
        {
            this.tabla = "factura";
            this.schema = "DEFAULT_NAME";
        }

        public override List<Factura> mapearAEntidad(System.Data.DataTable dt)
        {
            var newList = new List<Factura>();
            //
            foreach (DataRow dr in  dt.Rows)
            {
                var c = new Factura();
                c.Id_Factura = dr.IsNull("Id_Factura") ? 0 : dr.Field<int>("Id_Factura");
                c.Id_Proveedor = dr.IsNull("Id_Proveedor") ? 0 : dr.Field<int>("Id_Proveedor");
                c.Numero_Fact = dr.IsNull("Numero_Fact") ? String.Empty : dr.Field<String>("Numero_Fact");
                c.Tipo_Fact = dr.IsNull("Tipo_Fact") ? String.Empty : dr.Field<String>("Tipo_Fact");
                c.Fecha_Fact = dr.IsNull("Fecha_Fact") ? DateTime.MinValue : dr.Field<DateTime>("Fecha_Fact");
                c.Total_Fact = dr.IsNull("Total_Fact") ? 0 : dr.Field<Decimal>("Total_Fact");
                
                newList.Add(c);
            }
            return newList;

        }
    }
}
