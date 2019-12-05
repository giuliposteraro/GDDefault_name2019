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
    public class MaperDeCompras: MaperBase<Compra>
    {
        public MaperDeCompras()
        {
            this.tabla = "Compra";
            this.schema = "DEFAULT_NAME";
        }
        public override List<Compra> mapearAEntidad(DataTable dt)
        {
            var newList = new List<Compra>();
            //
            foreach (DataRow dr in  dt.Rows)
            {
                var c = new Compra();
                c.Id_Compra = dr.IsNull("Id_Compra") ? 0 : dr.Field<int>("Id_Compra");
                c.Id_Cliente = dr.IsNull("Id_Cliente") ? 0 : dr.Field<int>("Id_Cliente");
                c.Id_Proveedor = dr.IsNull("Id_Proveedor") ? 0 : dr.Field<int>("Id_Proveedor");
                c.Id_Oferta = dr.IsNull("Id_Oferta") ? 0 : dr.Field<int>("Id_Oferta");
                c.Fecha_Compra = dr.IsNull("Fecha_Compra") ? DateTime.MinValue : dr.Field<DateTime>("Fecha_Compra");
                c.Fecha_Entrega = dr.IsNull("Fecha_Entrega") ? DateTime.MinValue : dr.Field<DateTime>("Fecha_Entrega");
                c.Codigo_Cupon = dr.IsNull("Codigo_Cupon") ? String.Empty : dr.Field<String>("Codigo_Cupon");
                c.Estado_Cupon = dr.IsNull("Estado_Cupon") ? 0 : (estadoCupon)dr.Field<int>("Estado_Cupon");
                c.Cantidad = dr.IsNull("Cantidad") ? 0 : dr.Field<int>("Cantidad");
                c.Monto = dr.IsNull("Monto") ? 0: dr.Field<Decimal>("Monto");
                c.Facturado = dr.IsNull("Facturado") ? false : dr.Field<Boolean>("Facturado");

                newList.Add(c);
            }
            return newList;
        }
    }
}
