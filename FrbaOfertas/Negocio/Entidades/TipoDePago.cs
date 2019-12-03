using Negocio.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio.Entidades
{
    [Serializable]
    public class TipoDePago : EntidadBase
    {
        public int Id { get; set; }
        public string Nombre { get; set; }

        public override int ID
        {
            get
            {
                return Id;
            }
        }

        public static TipoDePago TarjetaDeCredito
        {
            get
            {
                var credito = new TipoDePago(){ Id = 1, Nombre = "Crédito"};
                return credito;
            }
        }

        public static TipoDePago TarjetaDeDebito
        {
            get
            {
                var credito = new TipoDePago() { Id = 2, Nombre = "Débito"};
                return credito;
            }
        }

        public static List<TipoDePago> ObtenerTodos()
        {
            List<TipoDePago> Todos = new List<TipoDePago>();
            Todos.Add(TipoDePago.TarjetaDeCredito);
            Todos.Add(TipoDePago.TarjetaDeDebito);
            return Todos;
        }

        public override bool Equals(object obj)
        {
            //pregunto si los tipos son diferentes
            if (this.GetType() != obj.GetType())
                return false;
            //si son el mismo tipo pregunto si los ids son igual a 0, 
            //si los dos son 0 (la entidad no fue guardada en la base y comparo por su padre
            if (this.ID == 0 && ((TipoDePago)obj).ID == 0)
                return base.Equals(obj);
            //sino compara por los ids
            return this.ID == ((TipoDePago)obj).ID;
        }
    }
}
