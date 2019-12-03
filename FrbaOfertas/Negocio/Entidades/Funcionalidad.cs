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
    public class Funcionalidad: EntidadBase
    {
        public int Id_Funcionalidad { get; set; }
	    public string Detalle_func { get; set; }

        public override int ID
        {
            get
            {
                return Id_Funcionalidad;
            }
        }

        public static Funcionalidad ABMdeRol
        {
            get
            {
                var maper = new MaperDeFuncionalidades();
                var repo = new RepositorioDeFuncionalidades(maper);
                return repo.ObtenerUnoPorId((int)Eid.ABMdeRol);
            }
        }

        public static Funcionalidad ABMdeCliente
        {
            get {
                var maper = new MaperDeFuncionalidades();
                var repo = new RepositorioDeFuncionalidades(maper);
                return repo.ObtenerUnoPorId((int)Eid.ABMdeCliente);
            }
        }

        public static Funcionalidad RegistroDeUsuarios
        {
            get
            {
                var maper = new MaperDeFuncionalidades();
                var repo = new RepositorioDeFuncionalidades(maper);
                return repo.ObtenerUnoPorId((int)Eid.RegistroDeUsuarios);
            }
        }

        public static Funcionalidad ABMdeProveedor
        {
            get
            {
                var maper = new MaperDeFuncionalidades();
                var repo = new RepositorioDeFuncionalidades(maper);
                return repo.ObtenerUnoPorId((int)Eid.ABMdeProveedor);
            }
        }

        public static Funcionalidad CargarCrédito
        {
            get
            {
                var maper = new MaperDeFuncionalidades();
                var repo = new RepositorioDeFuncionalidades(maper);
                return repo.ObtenerUnoPorId((int)Eid.CargarCrédito);
            }
        }

        public static Funcionalidad ComprarOferta
        {
            get
            {
                var maper = new MaperDeFuncionalidades();
                var repo = new RepositorioDeFuncionalidades(maper);
                return repo.ObtenerUnoPorId((int)Eid.ComprarOferta);
            }
        }
        public static Funcionalidad Confeccionypublicaciondeofertas
        {
            get
            {
                var maper = new MaperDeFuncionalidades();
                var repo = new RepositorioDeFuncionalidades(maper);
                return repo.ObtenerUnoPorId((int)Eid.Confeccionypublicaciondeofertas);
            }
        }

        public static Funcionalidad EntregaDeOfertas
        {
            get
            {
                var maper = new MaperDeFuncionalidades();
                var repo = new RepositorioDeFuncionalidades(maper);
                return repo.ObtenerUnoPorId((int)Eid.EntregaDeOfertas);
            }
        }
        public static Funcionalidad FacturacionaProveedor
        {
            get
            {
                var maper = new MaperDeFuncionalidades();
                var repo = new RepositorioDeFuncionalidades(maper);
                return repo.ObtenerUnoPorId((int)Eid.FacturacionaProveedor);
            }
        }

        public static Funcionalidad ListadoEstadistico
        {
            get
            {
                var maper = new MaperDeFuncionalidades();
                var repo = new RepositorioDeFuncionalidades(maper);
                return repo.ObtenerUnoPorId((int)Eid.ListadoEstadistico);
            }
        }

        public override bool Equals(object obj)
        {
            //Verifico que sea del mismo tipo
            if (obj.GetType() != this.GetType()) return false;

            //Valido que el objeto no sea null
            if (ReferenceEquals(null, obj)) return false;

            //Verifico si el objeto actual es igual al que recibo por parámetro
            if (this.Id_Funcionalidad != ((Funcionalidad)obj).Id_Funcionalidad) return false;
            
            return true;
        }

    }

    public enum Eid
    {       
	    ABMdeRol = 1,
	    RegistroDeUsuarios = 2,
	    ABMdeCliente = 3,
	    ABMdeProveedor = 4,
	    CargarCrédito = 5,
	    ComprarOferta = 6,
	    Confeccionypublicaciondeofertas =7,
        EntregaDeOfertas = 8,
	    FacturacionaProveedor =9,
	    ListadoEstadistico = 10
    }
}
