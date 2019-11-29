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
    public class MaperDeCreditos : MaperBase<Credito>
    {
        public MaperDeCreditos()
        {
            this.tabla = "Credito";
            this.schema = "DEFAULT_NAME";
        }

        public override List<Credito> mapearAEntidad(System.Data.DataTable dt)
        {
            var newList = new List<Credito>();
            //
            foreach (DataRow dr in  dt.Rows)
            {
                var c = new Credito();
                c.Id_Credito = dr.IsNull("Id_Credito") ? 0 : dr.Field<int>("Id_Credito");
                c.Id_Cliente = dr.IsNull("Id_Cliente") ? 0 : dr.Field<int>("Id_Cliente");
                c.Carga_Fecha = dr.IsNull("Carga_Fecha") ? DateTime.MinValue : dr.Field<DateTime>("Carga_Fecha");
                c.Carga_Cred = dr.IsNull("Carga_Cred") ? 0 : dr.Field<Decimal>("Carga_Cred");
                c.Tarjeta = dr.IsNull("Tarjeta") ? String.Empty : dr.Field<String>("Tarjeta");
                c.Detalle = dr.IsNull("Detalle") ? String.Empty : dr.Field<String>("Detalle");
                c.Tipo_Pago = dr.IsNull("Tipo_Pago") ? String.Empty : dr.Field<String>("Tipo_Pago");
                
                newList.Add(c);
            }
            return newList;

        }
    }
}
