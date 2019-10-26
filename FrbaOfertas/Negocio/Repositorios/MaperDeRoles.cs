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
    public class MaperDeRoles: MaperBase<Rol>
    {
        public MaperDeRoles()
        {
            this.tabla = "Rol";
            this.schema = "DEFAULT_NAME";
        }
        public override List<Rol> mapearAEntidad(DataTable dt)
        {
            var newList = new List<Rol>();
            //
            foreach (DataRow dr in  dt.Rows)
            {
                var r = new Rol();
                r.Id_Rol = dr.IsNull("Id_Rol") ? 0 : dr.Field<int>("Id_Rol");
                r.Nombre_rol = dr.IsNull("Nombre_rol") ? String.Empty : dr.Field<String>("Nombre_rol");
                r.Estado_rol = dr.IsNull("Estado_rol") ? false : dr.Field<bool>("Estado_rol");
                newList.Add(r);
            }
            return newList;
        }
    }
}
