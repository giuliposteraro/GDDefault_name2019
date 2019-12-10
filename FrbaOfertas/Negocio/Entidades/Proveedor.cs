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

        public string Mail_Proveedor { get; set; }

        public string Telefono_Prov { get; set; }

        public string Cuit_Prov { get; set; }

        public string Rubro_Prov { get; set; }

        public string Nom_Contacto_Prov { get; set; }

        public string Razon_Social_Prov { get; set; }

        public bool Habilitado { get; set; }

        private int Id_Direccion { get; set; }
        private Domicilio _Domicilio;
        public Domicilio Direccion
        {
            get {
                if (_Domicilio == null && Id_Proveedor != 0)
                {
                    var maper = new MaperDeDireccion();
                    var repo = new RepositorioDeDireccion(maper);
                    _Domicilio = repo.ObtenerPorIDYTTipo(Id_Proveedor, 2);
                    Id_Direccion = _Domicilio.Id_Direccion;
                }
                return _Domicilio;
            }
            set
            {
                _Domicilio = value;
                if (value == null)
                    Id_Direccion = 0;
                else if (value.Id_Direccion != Id_Direccion)
                    Id_Direccion = value.Id_Direccion;

            }
        }

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

        public string CodigoPostalTexto
        {
            get
            {
                if (Direccion != null)
                    return Direccion.Codigo_Postal_Dir;
                else
                    return "";
            }
        }
        public string DireccionTexto
        {
            get
            {
                if (Direccion != null)
                    return Direccion.Calle_Dir;
                else
                    return "";
            }
        }

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
