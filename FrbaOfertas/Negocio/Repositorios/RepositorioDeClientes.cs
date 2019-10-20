using Negocio.Base;
using Negocio.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio.Repositorios
{
    public class RepositorioDeClientes : IPersistencia<Cliente>
    {
        public RepositorioDeClientes(MaperDeClientes maper)
        {
            this.maper = maper;
        }

        public List<Cliente> Buscar()
        {
            try
            {
                List<Cliente> lista = new List<Cliente>();
                lista = this.maper.mapearAEntidad(BuscarTodos());
                return lista;
            }
            catch (Exception ex)
            {
                throw new Exception(string.Format("se produjo un error al buscar los clientes: {0}", ex.Message));
            }
        }



        public List<Cliente> BuscarConFiltros(string Nombre, string Apellido)
        {
            try
            {
                List<Cliente> lista = new List<Cliente>();

                Dictionary<string, object[]> parametros = new Dictionary<string, object[]>();
                if (Nombre != string.Empty) parametros.Add("Cli_Nombre", new object[2] {Nombre,TipoDeComparador.eID.Texto});
                if (Apellido != string.Empty) parametros.Add("Cli_Apellido", new object[2] { Apellido, TipoDeComparador.eID.TextoExacto });

                lista = this.maper.mapearAEntidad(BuscarTodosPorFiltro(parametros));
                return lista;
            }
            catch (Exception ex)
            {
                throw new Exception(string.Format("se produjo un error al buscar los clientes: {0}", ex.Message));
            }
        }

        
    }
}
