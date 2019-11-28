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


        /// <summary>
        /// busca todos los clientes existentes en el sistema,.
        /// </summary>
        /// <returns></returns>
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


        /// <summary>
        /// busca multiples clientes por los filtros seleccionados
        /// </summary>
        /// <param name="Nombre">busca concidencias aproximadas</param>
        /// <param name="Apellido">busca concidencias aproximadas</param>
        /// <param name="idUsuario">filtro exacto</param>
        /// <returns></returns>
        public List<Cliente> BuscarConFiltros(string Nombre = null, string Apellido = null, int idUsuario = 0)
        {
            try
            {
                List<Cliente> lista = new List<Cliente>();

                Dictionary<string, object[]> parametros = new Dictionary<string, object[]>();
                if (Nombre != string.Empty) parametros.Add("Nombre_Clie", new object[2] { Nombre, TipoDeComparador.eID.Texto });
                if (Apellido != string.Empty) parametros.Add("Apellido_Clie", new object[2] { Apellido, TipoDeComparador.eID.Texto });
                if (idUsuario != 0) parametros.Add("Id_Cuenta", new object[2] { idUsuario, TipoDeComparador.eID.TextoExacto });

                lista = this.maper.mapearAEntidad(BuscarTodosPorFiltro(parametros));
                return lista;
            }
            catch (Exception ex)
            {
                throw new Exception(string.Format("se produjo un error al buscar los clientes: {0}", ex.Message));
            }
        }

        /// <summary>
        /// devuelve uno por id
        /// </summary>
        /// <param name="Id_Cliente">id del cliente que queremos buscar</param>
        /// <returns></returns>
        internal Cliente ObtenerUnoPorId(int Id_Cliente)
        {
            try
            {
                return this.maper.mapearAEntidad(ObtenerPorID("Id_Cliente", Id_Cliente)).FirstOrDefault();
            }
            catch (Exception ex)
            {
                throw new Exception(string.Format("se produjo un error al buscar el cliente: {0}", ex.Message));
            }
        }


        /// <summary>
        /// busca un cliente por su IdCuenta (idusuario)
        /// </summary>
        /// <param name="idUsuario"> id cuenta del cliente a encontrar</param>
        /// <returns></returns>
        public Cliente ObtenerDelUsuario(int idUsuario)
        {
            try
            {
                //busco por el filtro y me quedo con el primero o un nulo si la lista devuelta esta vacia.
                return this.BuscarConFiltros(idUsuario: idUsuario).FirstOrDefault();
            }
            catch (Exception ex)
            {
                throw new Exception(string.Format("se produjo un error al buscar el cliente: {0}", ex.Message));
            }
        }
    }
}
