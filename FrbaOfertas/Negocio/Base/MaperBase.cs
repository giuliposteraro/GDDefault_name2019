using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace Negocio.Base
{
    public abstract class MaperBase<T>
    {
        public string tabla {get;set;}
        public string schema {get;set;}


        public abstract List<T> mapearAEntidad(DataTable dt);
 
    }
}
