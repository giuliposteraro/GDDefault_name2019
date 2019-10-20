using Negocio.Base;
using Negocio.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio.Repositorios
{
    public class RepositorioDeUsuarios : IPersistencia<Usuario>
    {
        public RepositorioDeUsuarios(MaperDeUsuarios maper)
        {
            this.maper = maper;
        }

        public Usuario ObtenerPorNombre(string nombre)
        {
            return BuscarConFiltros(nombre).FirstOrDefault();
        }

        public List<Usuario> BuscarConFiltros(string Nombre)
        {
            try
            {
                List<Usuario> lista = new List<Usuario>();

                Dictionary<string, object[]> parametros = new Dictionary<string, object[]>();
                if (Nombre != string.Empty) parametros.Add("Usuario_Cuenta", new object[2] { Nombre, TipoDeComparador.eID.Texto });

                List<string> columnas = new List<string>(new string[] { "Id_Usuario", "Usuario_Cuenta", "CONVERT(VARCHAR  (100), Contra_Cuenta) as Contra_Cuenta","Cant_Ingresos_Cuenta",   "Estado_Cuenta"  });

                lista = this.maper.mapearAEntidad(BuscarTodosPorFiltro(parametros, columnas));
                return lista;
            }
            catch (Exception ex)
            {
                throw new Exception(string.Format("se produjo un error al buscar los clientes: {0}", ex.Message));
            }
        }
    }
}
