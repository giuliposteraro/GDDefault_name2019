using Negocio.Base;
using Negocio.Repositorios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio.Entidades
{
    [Serializable]
    public class Proveedor : EntidadBase
    {

        public int Id_Proveedor { get; set; }
        public int Id_Cuenta { get; set; }
	    public string Mail_Proveedor{get; set;}
        public string Telefono_prov { get; set; }
        public string Cuit_Prov { get; set; }
        public string Rubro_Prov { get; set; }
        public string Nom_Contacto_Prov { get; set; }
        public string Razon_Social_Prov { get; set; }
        public string Habilitado { get; set; }

        public override int ID
        {
            get
            {
                return Id_Proveedor;
            }
        }

        public override bool Equals(object obj)
        {
            //Verifico que sea del mismo tipo
            if (obj.GetType() != this.GetType()) return false;

            //Valido que el objeto no sea null
            if (ReferenceEquals(null, obj)) return false;

            //Verifico si el objeto actual es igual al que recibo por parámetro
            if (this.Id_Proveedor != ((Rol)obj).Id_Rol) return false;

            return true;
        }

    }
}
