using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio.Base
{
    public static class Extensiones
    {

        ///Funcion que devuelve un boleano especificando si el string es nulo, vacio o espacio en blanco.
        ///Verdadero si el string es nulo, vacio o espacio en blanco
        ///Falso en cualquier otro caso
        public static bool EsNuloOVacio(this string unString)
        {
            return string.IsNullOrEmpty(unString) || unString.Trim().Length == 0; 
        }
    }
}

