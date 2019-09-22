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
            List<Cliente> lista = new List<Cliente>();
            lista = this.maper.mapearAEntidad(BuscarTodos());
            return lista;
        }
    }
}
