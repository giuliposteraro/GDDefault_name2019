using Negocio.Base;
using Negocio.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace Negocio.Repositorios
{
    public class MaperDeUsuarios : MaperBase<Usuario>
    {
        public MaperDeUsuarios()
        {
            this.tabla = "Cuenta";
            this.schema = "DEFAULT_NAME";
        }

        public override List<Usuario> mapearAEntidad(DataTable dt)
        {
            var newList = new List<Usuario>();
            //
            foreach (DataRow dr in dt.Rows)
            {
                var c = new Usuario();
                c.Id_Usuario = dr.IsNull("Id_Usuario") ? 0 : dr.Field<int>("Id_Usuario");
                c.Usuario_Cuenta = dr.IsNull("Usuario_Cuenta") ? String.Empty : dr.Field<String>("Usuario_Cuenta");
                c.Contra_Cuenta = dr.IsNull("Contra_Cuenta") ? String.Empty : dr.Field<string>("Contra_Cuenta");
                c.Cant_Ingresos_Cuenta = dr.IsNull("Cant_Ingresos_Cuenta") ? 0 : dr.Field<int>("Cant_Ingresos_Cuenta");
                c.Estado_Cuenta = dr.IsNull("Estado_Cuenta") ? 0 : (EstadosUsuario)dr.Field<int>("Estado_Cuenta");
                newList.Add(c);
            }
            return newList;
        }
    }
}
