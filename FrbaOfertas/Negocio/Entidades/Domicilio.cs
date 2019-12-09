using Negocio.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio.Entidades
{
    [Serializable]
    public class Domicilio : EntidadBase
    {
         public int Id_Direccion {get; set;}
          public int Id_Objeto {get; set;}
          public int Tipo_Objeto {get; set;}
          public string Numero_Dir {get; set;}
          public string Piso_Dir {get; set;}
          public string Depto_Dir {get; set;}
          public string Localidad_Dir {get; set;}
          public string Ciudad_Dir {get; set;}
          public string Calle_Dir {get; set;}
          public string Codigo_Postal_Dir { get; set; }
    }
}
