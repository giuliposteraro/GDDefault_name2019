using Negocio.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio.Base
{
    public static class Global
    {
        private static Usuario _user = null;

        public static Usuario SessionUsuario
        {
            get { return _user; }
            set { _user = value; }
        }
    }
}
