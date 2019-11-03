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
	    FacturacionaProveedor =8,
	    ListadoEstadistico = 9
    }
}
