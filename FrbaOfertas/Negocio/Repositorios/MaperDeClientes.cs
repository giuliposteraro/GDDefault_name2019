using Negocio.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Negocio.Entidades;

namespace Negocio.Repositorios
{
    public class MaperDeClientes : MaperBase<Cliente>
    {
        public MaperDeClientes()
        { 
            this.tabla = "clientesTabla";
            this.schema = "dbo";
        }
        public override List<Cliente> mapearAEntidad(DataTable dt)
        {
            var newList = new List<Cliente>();
            //
            foreach (DataRow dr in  dt.Rows)
            {
                var c = new Cliente();
                c.Nombre = dr.IsNull("Cli_Nombre") ? String.Empty : dr.Field<String>("Cli_Nombre");
                c.Apellido = dr.IsNull("Cli_Apellido") ? String.Empty : dr.Field<String>("Cli_Apellido");
                newList.Add(c);
            }
            return newList;
        }


        
    }
}
