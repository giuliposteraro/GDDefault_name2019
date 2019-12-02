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
    public class MaperDeOfertas: MaperBase<Oferta>
    {
        public MaperDeOfertas()
        {
            this.tabla = "Oferta";
            this.schema = "DEFAULT_NAME";
        }

        public override List<Oferta> mapearAEntidad(System.Data.DataTable dt)
        {
            var newList = new List<Oferta>();
            //
            foreach (DataRow dr in  dt.Rows)
            {
                var c = new Oferta();
                c.Id_Oferta = dr.IsNull("Id_Oferta") ? 0 : dr.Field<int>("Id_Oferta");
                c.Id_Proveedor = dr.IsNull("Id_Proveedor") ? 0 : dr.Field<int>("Id_Proveedor");
                c.Descripcion_Of = dr.IsNull("Descripcion_Of") ? String.Empty : dr.Field<String>("Descripcion_Of");
                c.Fecha_Publi_Of = dr.IsNull("Fecha_Publi_Of") ? DateTime.MinValue : dr.Field<DateTime>("Fecha_Publi_Of");
                c.Fecha_Venc_Of = dr.IsNull("Fecha_Venc_Of") ? DateTime.MinValue : dr.Field<DateTime>("Fecha_Venc_Of");
                c.Precio_Oferta = dr.IsNull("Precio_Oferta") ? 0 : dr.Field<Decimal>("Precio_Oferta");
                c.Precio_Lista = dr.IsNull("Precio_Lista") ? 0 : dr.Field<Decimal>("Precio_Lista");
                c.Cant_Disp_Oferta = dr.IsNull("Cant_Disp_Oferta") ? 0 : dr.Field<Int32>("Cant_Disp_Oferta");
                c.Maximo_Por_Compra = dr.IsNull("Maximo_Por_Compra") ? 0 : dr.Field<Int32>("Maximo_Por_Compra");
                c.Codigo_Of = dr.IsNull("Codigo_Of") ? String.Empty : dr.Field<String>("Codigo_Of");

                newList.Add(c);
            }
            return newList;

        }
    }
}
