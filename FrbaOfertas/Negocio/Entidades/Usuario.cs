using Negocio.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio.Entidades
{
    public class Usuario : EntidadBase
    {
        public int Cant_Ingresos_Cuenta { get;  set; }
        public string Contra_Cuenta { get; set; }
        public EstadosUsuario Estado_Cuenta { get; set; }
        public int Id_Usuario { get; set; }
        public string Usuario_Cuenta { get; set; }
    }

    public enum EstadosUsuario
    {
        creado = 1
    }
}
