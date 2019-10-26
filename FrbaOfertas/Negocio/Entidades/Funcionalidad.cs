using Negocio.Base;
using Negocio.Repositorios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio.Entidades
{
    public class Funcionalidad: EntidadBase
    {
        public int Id_Funcionalidad { get; set; }
	    public string Detalle_func { get; set; }

        public static Funcionalidad ABMdeCliente
        {
            get {
                var maper = new MaperDeFuncionalidades();
                var repo = new RepositorioDeFuncionalidades(maper);
                return repo.ObtenerUnoPorId((int)Eid.ABMdeCliente);
            }
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
