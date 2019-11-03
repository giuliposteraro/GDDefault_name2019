using System;
using System.Collections.Generic;
using System.IO;
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


        public static T CloneObject<T>(this object source)
        {
            T result = Activator.CreateInstance<T>();

            //// **** made things

            return result;
        }

        public static T Clone<T>(this object source)
        {
            if (!typeof(T).IsSerializable)
            {
                throw new ArgumentException("The type must be serializable.", "source");
            }

            if (Object.ReferenceEquals(source, null))
            {
                return default(T);
            }

            System.Runtime.Serialization.IFormatter formatter = new System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();
            Stream stream = new MemoryStream();
            using (stream)
            {
                formatter.Serialize(stream, source);
                stream.Seek(0, SeekOrigin.Begin);
                return (T)formatter.Deserialize(stream);
            }
        }
    }
}

