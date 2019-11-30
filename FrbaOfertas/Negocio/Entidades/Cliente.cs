using Negocio.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio.Entidades
{
    [Serializable]
    public class Cliente : EntidadBase
    {

        public int Id_Cliente { get; set; }
        public int Id_Cuenta { get; set; }
        public int Id_Cliente_Dest { get; set; }
        public string Nombre_Clie { get; set; }
        public string Apellido_Clie { get; set; }
        public int DNI_Clie { get; set; }
        public string Mail_Clie { get; set; }
        public string Tel_Clie { get; set; }
        public DateTime Fecha_Nac_Clie { get; set; }
        public decimal Monto_Total_cred_Clie { get; set; }


        public override string ToString()
        {
            return this.Apellido_Clie + " - " + this.Nombre_Clie;
        }

        public override int ID
        {
            get
            {
                return Id_Cliente;
            }
        }
        
        public override bool Equals(object obj)
        {
            //pregunto si los tipos son diferentes
            if (this.GetType() != obj.GetType())
                return false;
            //si son el mismo tipo pregunto si los ids son igual a 0, 
            //si los dos son 0 (la entidad no fue guardada en la base y comparo por su padre
            if( this.ID ==0 && ((Cliente)obj).ID == 0)
                return base.Equals(obj);
            //sino compara por los ids
            return this.ID == ((Cliente)obj).ID;
        }
    }
}
