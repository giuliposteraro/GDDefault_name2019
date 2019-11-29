using Negocio.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio.Entidades
{
    public class TipoDePago : EntidadBase
    {
        public int Id { get; set; }
        public string Nombre { get; set; }

        public static TipoDePago TarjetaDeCredito
        {
            get
            {
                var credito = new TipoDePago(){ Id = 1, Nombre = "Tarjeta de Crédito"};
                return credito;
            }
        }

        public static TipoDePago TarjetaDeDebito
        {
            get
            {
                var credito = new TipoDePago() { Id = 2, Nombre = "Tarjeta de débito" };
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
    }
}
