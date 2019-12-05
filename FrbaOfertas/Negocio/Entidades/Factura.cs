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
    public class Factura : EntidadBase
    {
         public int Id_Factura { get; set; }
        public int Id_Proveedor {get; set;}
        public string Numero_Fact {get; set;}
        public string Tipo_Fact { get; set; }
        public decimal Total_Fact{get; set;}
        public DateTime Fecha_Fact{get; set;}

        private Proveedor _proveedor;
        public Proveedor Proveedor
        {
            get
            {
                if (_proveedor == null)
                {
                    var maper = new MaperDeProveedores();
                    var repo = new RepositorioDeProveedores(maper);
                    _proveedor = repo.ObtenerUnoPorId(Id_Proveedor);
                }
                return _proveedor;
            }
            set
            {
                _proveedor = value;
                Id_Proveedor = value.ID;
            }
        }

        public string ProveedorRazonSocial
        {
            get
            {
                return Proveedor.Razon_Social_Prov;
            }
        }

        public override string ToString()
        {
            return this.Numero_Fact + " - monto: " + this.Total_Fact;
        }

        public override int ID
        {
            get
            {
                return Id_Factura;
            }
        }

        public override bool Equals(object obj)
        {
            //pregunto si los tipos son diferentes
            if (this.GetType() != obj.GetType())
                return false;
            //si son el mismo tipo pregunto si los ids son igual a 0, 
            //si los dos son 0 (la entidad no fue guardada en la base y comparo por su padre
            if (this.ID == 0 && ((Factura)obj).ID == 0)
                return base.Equals(obj);
            //sino compara por los ids
            return this.ID == ((Factura)obj).ID;
        }
    }
}
