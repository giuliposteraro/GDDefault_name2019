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
    public class MaperDeProveedor : MaperBase<Proveedor>
    {
        public MaperDeProveedor()
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
                var c = new Proveedor();
                c.Id_Proveedor = dr.IsNull("Id_Proveedor") ? 0 : dr.Field<int>("Id_Proveedor");
                c.Id_Cuenta = dr.IsNull("Id_Cuenta") ? 0 : dr.Field<int>("Id_Cuenta");
                c.Mail_Proveedor = dr.IsNull("Mail_Proveedor") ? String.Empty : dr.Field<String>("Mail_Proveedor");
                c.Nom_Contacto_Prov = dr.IsNull("Nombre_Contacto_Prov") ? String.Empty : dr.Field<String>("Nombre_Contacto_Prov");
                c.Razon_Social_Prov = dr.IsNull("Razon_Social_Prov") ? String.Empty : dr.Field<string>("Razon_Social_Prov");
                c.Rubro_Prov = dr.IsNull("Rubro_Prov") ? String.Empty : dr.Field<String>("Rubro_Prov");
                c.Telefono_prov = dr.IsNull("Telefono_prov") ? String.Empty : dr.Field<String>("Telefono_prov");             

                newList.Add(c);
            }
            return newList;
        }


        
    }
}
