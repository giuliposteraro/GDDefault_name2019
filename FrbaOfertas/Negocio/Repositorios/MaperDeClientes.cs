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
            this.tabla = "Cliente";
            this.schema = "DEFAULT_NAME";
        }
        public override List<Cliente> mapearAEntidad(DataTable dt)
        {
            var newList = new List<Cliente>();
            //
            foreach (DataRow dr in  dt.Rows)
            {
                var c = new Cliente();
                c.Id_Cliente = dr.IsNull("Id_Cliente") ? 0 : dr.Field<int>("Id_Cliente");
                c.Id_Cuenta = dr.IsNull("Id_Cuenta") ? 0 : dr.Field<int>("Id_Cuenta");
                c.Id_Cliente_Dest = dr.IsNull("Id_Cliente_Dest") ? 0 : dr.Field<int>("Id_Cliente_Dest");
                c.Nombre_Clie = dr.IsNull("Nombre_Clie") ? String.Empty : dr.Field<String>("Nombre_Clie");
                c.Apellido_Clie = dr.IsNull("Apellido_Clie") ? String.Empty : dr.Field<String>("Apellido_Clie");
                c.DNI_Clie = dr.IsNull("DNI_Clie") ? 0 : dr.Field<int>("DNI_Clie");
                c.Mail_Clie = dr.IsNull("Mail_Clie") ? String.Empty : dr.Field<String>("Mail_Clie");
                c.Tel_Clie = dr.IsNull("Tel_Clie") ? String.Empty : dr.Field<String>("Tel_Clie");             
                c.Fecha_Nac_Clie = dr.IsNull("Fecha_Nac_Clie") ? DateTime.MinValue : dr.Field<DateTime>("Fecha_Nac_Clie");
                c.Monto_Total_cred_Clie = dr.IsNull("Monto_Total_cred_Clie") ? 0: dr.Field<Decimal>("Monto_Total_cred_Clie");
                c.Habilitado = dr.IsNull("Habilitado") ? false : dr.Field<Boolean>("Habilitado");

                newList.Add(c);
            }
            return newList;
        }


        
    }
}
