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
    public class Credito : EntidadBase
    {
        public int Id_Credito {get; set;}
	    public int Id_Cliente {get; set;}
	    public DateTime Carga_Fecha  {get; set;}
	    public decimal Carga_Cred {get; set;}
	    public string Tarjeta {get; set;}
	    public string Detalle  {get; set;}
        public int Tipo_Pago { get; set; }

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

        public String ClienteNombre
        {
            get {
                return _cliente.ToString();
            }
        }

        public override int ID
        {
            get
            {
                return Id_Credito;
            }
        }
    }
}
