using Negocio.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio.Entidades
{
    public class Cliente : EntidadBase
    {
        public string Nombre { get; set; }
        public string Apellido { get; set; }

        public override string ToString()
        {
            return this.Apellido + " - " + this.Nombre;
        }
    }
}
