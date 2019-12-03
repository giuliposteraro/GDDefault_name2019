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
    public class Compra : EntidadBase
    {
        public int Id_Compra{ get; set; }
        public int Id_Cliente{ get; set; }
        public int Id_Proveedor{ get; set; }
        public int Id_Oferta{ get; set; }
        public DateTime Fecha_Compra{ get; set; }
        public DateTime Fecha_Entrega{ get; set; }
        public string Codigo_Cupon{ get; set; }
        public estadoCupon Estado_Cupon { get; set; }
        public int Cantidad{ get; set; }
        public Decimal Monto{ get; set; }


        private Cliente _cliente;
        public Cliente Cliente
        {
            get
            {
                if (_cliente == null)
                {
                    var maper = new MaperDeClientes();
                    var repo = new RepositorioDeClientes(maper);
                    _cliente = repo.ObtenerUnoPorId(Id_Cliente);
                }
                return _cliente;
            }
            set
            {
                _cliente = value;
                Id_Cliente = value.ID;
            }
        }

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

        private Oferta _oferta;
        public Oferta Oferta
        {
            get
            {
                if (_oferta == null)
                {
                    var maper = new MaperDeOfertas();
                    var repo = new RepositorioDeOfertas(maper);
                    _oferta = repo.ObtenerUnoPorId(Id_Oferta);
                }
                return _oferta;
            }
            set
            {
                _oferta = value;
                Id_Oferta = value.ID;
            }
        }


        public override string ToString()
        {
            return this.Codigo_Cupon + " - " + this.Estado_Cupon;
        }

        public override int ID
        {
            get
            {
                return Id_Compra;
            }
        }

        public override bool Equals(object obj)
        {
            //pregunto si los tipos son diferentes
            if (this.GetType() != obj.GetType())
                return false;
            //si son el mismo tipo pregunto si los ids son igual a 0, 
            //si los dos son 0 (la entidad no fue guardada en la base y comparo por su padre
            if (this.ID == 0 && ((Compra)obj).ID == 0)
                return base.Equals(obj);
            //sino compara por los ids
            return this.ID == ((Compra)obj).ID;
        }
    }

    public enum estadoCupon
    {
        creado = 1,
        entregado = 2
    }
}
