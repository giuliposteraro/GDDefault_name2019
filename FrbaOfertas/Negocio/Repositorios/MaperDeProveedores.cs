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
    public class MaperDeProveedores: MaperBase<Proveedor>
    {
        public MaperDeProveedores()
        {
            this.tabla = "Proveedor";
            this.schema = "DEFAULT_NAME";
        }
        public override List<Proveedor> mapearAEntidad(DataTable dt)
        {
            var newList = new List<Proveedor>();
            //
            foreach (DataRow dr in  dt.Rows)
            {
                var r = new Proveedor();
                r.Id_Proveedor = dr.IsNull("Id_Proveedor") ? 0 : dr.Field<int>("Id_Proveedor");
                r.Id_Cuenta = dr.IsNull("Id_Cuenta") ? 0 : dr.Field<int>("Id_Cuenta");
                r.Mail_Proveedor = dr.IsNull("Mail_Proveedor") ? String.Empty : dr.Field<String>("Mail_Proveedor");

                r.Telefono_Prov = dr.IsNull("Telefono_Prov") ? String.Empty : dr.Field<String>("Telefono_Prov");
                r.Cuit_Prov = dr.IsNull("Cuit_Prov") ? String.Empty : dr.Field<String>("Cuit_Prov");
                r.Rubro_Prov = dr.IsNull("Rubro_Prov") ? String.Empty : dr.Field<String>("Rubro_Prov");
                r.Nom_Contacto_Prov = dr.IsNull("Nom_Contacto_Prov") ? String.Empty : dr.Field<String>("Nom_Contacto_Prov");
                r.Razon_Social_Prov = dr.IsNull("Razon_Social_Prov") ? String.Empty : dr.Field<String>("Razon_Social_Prov");
                newList.Add(r);
            }
            return newList;
        }
    }
}
