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
    public class MaperDeDireccion: MaperBase<Domicilio>
    {
        public MaperDeDireccion()
        {
            this.tabla = "Direccion";
            this.schema = "DEFAULT_NAME";
        }

        public override List<Domicilio> mapearAEntidad(System.Data.DataTable dt)
        {
            var newList = new List<Domicilio>();
            //
            foreach (DataRow dr in  dt.Rows)
            {
                var c = new Domicilio();
                c.Id_Direccion = dr.IsNull("Id_Direccion") ? 0 : dr.Field<int>("Id_Direccion");
                c.Id_Objeto = dr.IsNull("Id_Objeto") ? 0 : dr.Field<int>("Id_Objeto");
                c.Tipo_Objeto = dr.IsNull("Tipo_Objeto") ? 0 : dr.Field<int>("Tipo_Objeto");
                c.Numero_Dir = dr.IsNull("Numero_Dir") ? 0 : dr.Field<int>("Numero_Dir");
                c.Piso_Dir = dr.IsNull("Piso_Dir") ? String.Empty : dr.Field<string>("Piso_Dir");
                c.Depto_Dir = dr.IsNull("Depto_Dir") ? String.Empty : dr.Field<String>("Depto_Dir");
                c.Localidad_Dir = dr.IsNull("Localidad_Dir") ? String.Empty : dr.Field<String>("Localidad_Dir");
                c.Ciudad_Dir = dr.IsNull("Ciudad_Dir") ? String.Empty : dr.Field<String>("Ciudad_Dir");
                c.Calle_Dir = dr.IsNull("Calle_Dir") ? String.Empty : dr.Field<String>("Calle_Dir");
                c.Codigo_Postal_Dir = dr.IsNull("Codigo_Postal_Dir") ? String.Empty : dr.Field<String>("Codigo_Postal_Dir");
                
                newList.Add(c);
            }
            return newList;

        }
    }
}
