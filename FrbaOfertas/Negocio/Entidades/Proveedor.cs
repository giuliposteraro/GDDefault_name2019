using Negocio.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Negocio.Entidades
{
    [Serializable]
    public class Proveedor : EntidadBase
    {
        public int Id_Proveedor { get; set; }
        public int Id_Cuenta { get; set; }

        public string Mail_Proveedor { get; set; }

        public string Telefono_Prov { get; set; }

        public string Cuit_Prov { get; set; }

        public string Rubro_Prov { get; set; }

        public string Nom_Contacto_Prov { get; set; }

        public string Razon_Social_Prov { get; set; }


        public override string ToString()
        {
            return this.Razon_Social_Prov;
        }

        public override int ID
        {
            get
            {
                return Id_Proveedor;
            }
        }

        public override bool Equals(object obj)
        {
            //pregunto si los tipos son diferentes
            if (this.GetType() != obj.GetType())
                return false;
            //si son el mismo tipo pregunto si los ids son igual a 0, 
            //si los dos son 0 (la entidad no fue guardada en la base y comparo por su padre
            if (this.ID == 0 && ((Proveedor)obj).ID == 0)
                return base.Equals(obj);
            //sino compara por los ids
            return this.ID == ((Proveedor)obj).ID;
        }


    }
}
