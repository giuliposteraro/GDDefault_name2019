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
        public bool Habilitado { get; set; }


        public string HabilitadoTexto
        {
            get 
            {
                if (Habilitado)
                    return "SI";
                else
                    return "NO";
            }
        }

        private int Id_Direccion { get; set; }
        private Domicilio _Domicilio;
        public Domicilio Direccion
        {
            get {
                if (_Domicilio == null && Id_Cliente != 0)
                {
                    var maper = new MaperDeDireccion();
                    var repo = new RepositorioDeDireccion(maper);
                    _Domicilio = repo.ObtenerPorIDYTTipo(Id_Cliente, 1);
                    Id_Direccion = _Domicilio.Id_Direccion;
                }
                return _Domicilio;
            }
            set { 
                _Domicilio = value;
                if (value == null)
                    Id_Direccion = 0;
                else if (value.Id_Direccion != Id_Direccion)
                    Id_Direccion = value.Id_Direccion;

            }
        }

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
