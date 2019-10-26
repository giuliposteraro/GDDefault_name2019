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
     public class MaperDeFuncionalidades: MaperBase<Funcionalidad>
    {
         public MaperDeFuncionalidades()
        {
            this.tabla = "Funcionalidad";
            this.schema = "DEFAULT_NAME";
        }
         public override List<Funcionalidad> mapearAEntidad(DataTable dt)
        {
            var newList = new List<Funcionalidad>();
            //
            foreach (DataRow dr in  dt.Rows)
            {
                var f = new Funcionalidad();
                f.Id_Funcionalidad = dr.IsNull("Id_Funcionalidad") ? 0 : dr.Field<int>("Id_Funcionalidad");
                f.Detalle_func = dr.IsNull("Detalle_func") ? String.Empty : dr.Field<String>("Detalle_func");
                newList.Add(f);
            }
            return newList;
        }
    }
}
