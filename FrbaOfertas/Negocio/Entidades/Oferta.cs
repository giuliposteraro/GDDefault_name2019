using Negocio.Base;
using Negocio.Repositorios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio.Entidades
{
    public class Oferta : EntidadBase
    {
        public int Id_Oferta { get; set; }
        public int Id_Proveedor {get; set;}
        public string Descripcion_Of {get; set;}
        public DateTime Fecha_Publi_Of{get; set;}
        public DateTime Fecha_Venc_Of { get; set; }
        public decimal Precio_Oferta{get; set;}
        public decimal Precio_Lista{get; set;}
        public int Cant_Disp_Oferta{get; set;}
        public int Maximo_Por_Compra{get; set;}
        public string Codigo_Of{get; set;}

        private Proveedor _proveedor;
        public Proveedor Cliente
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

        public override string ToString()
        {
            return this.Codigo_Of + " - " + this.Descripcion_Of;
        }

        public override int ID
        {
            get
            {
                return Id_Oferta;
            }
        }

        public override bool Equals(object obj)
        {
            //pregunto si los tipos son diferentes
            if (this.GetType() != obj.GetType())
                return false;
            //si son el mismo tipo pregunto si los ids son igual a 0, 
            //si los dos son 0 (la entidad no fue guardada en la base y comparo por su padre
            if (this.ID == 0 && ((Oferta)obj).ID == 0)
                return base.Equals(obj);
            //sino compara por los ids
            return this.ID == ((Oferta)obj).ID;
        }
    }
}
