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
    }
}
