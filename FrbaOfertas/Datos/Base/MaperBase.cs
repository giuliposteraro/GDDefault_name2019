using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace Datos.Base
{
    public class MaperBase<T>
    {
        public string tabla {get;set;}
        public string schema {get;set;}


        public List<T> mapearAEntidad(DataTable dt)
        {
            return new List<T>();
        }
 
    }
}
