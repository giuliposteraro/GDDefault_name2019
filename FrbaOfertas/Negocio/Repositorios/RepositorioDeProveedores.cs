using Negocio.Base;
using Negocio.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio.Repositorios
{
    public class RepositorioDeProveedores: IPersistencia<Proveedor>
    {
        public RepositorioDeProveedores(MaperDeProveedores maper)
        {
            this.maper = maper;
        }


        /// <summary>
        /// busca el proveedor por el id provisto
        /// </summary>
        /// <param name="Id_Proveedor"></param>
        /// <returns></returns>
        internal Proveedor ObtenerUnoPorId(int Id_Proveedor)
        {
            try
            {
                return this.maper.mapearAEntidad(ObtenerPorID("Id_Proveedor", Id_Proveedor)).FirstOrDefault();
            }
            catch (Exception ex)
            {
                throw new Exception(string.Format("se produjo un error al buscar el Proveedor: {0}", ex.Message));
            }
        }

        /// <summary>
        /// busca todos los proveedores del sistema
        /// </summary>
        /// <returns></returns>
        public List<Proveedor> Buscar()
        {
            try
            {
                List<Proveedor> lista = new List<Proveedor>();
                lista = this.maper.mapearAEntidad(BuscarTodos());
                return lista;
            }
            catch (Exception ex)
            {
                throw new Exception(string.Format("se produjo un error al buscar los proveedores: {0}", ex.Message));
            }
        }

        /// <summary>
        /// obtiene un proveedor por su id_cuenta
        /// </summary>
        /// <param name="p"></param>
        /// <returns></returns>
        public Proveedor ObtenerDelUsuario(int idUsuario)
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

        /// <summary>
        /// busca los proveedores por los filtros enviandos
        /// </summary>
        /// <param name="Nombre"></param>
        /// <param name="Apellido"></param>
        /// <param name="idUsuario"></param>
        /// <returns></returns>
        public List<Proveedor> BuscarConFiltros(string razonSocial = null, int idUsuario = 0)
        {
            try
            {
                List<Proveedor> lista = new List<Proveedor>();

                Dictionary<string, object[]> parametros = new Dictionary<string, object[]>();
                if (razonSocial != string.Empty) parametros.Add("Razon_Social_Prov", new object[2] { razonSocial, TipoDeComparador.eID.Texto });
                if (idUsuario != 0) parametros.Add("Id_Cuenta", new object[2] { idUsuario, TipoDeComparador.eID.TextoExacto });

                lista = this.maper.mapearAEntidad(BuscarTodosPorFiltro(parametros));
                return lista;
            }
            catch (Exception ex)
            {
                throw new Exception(string.Format("se produjo un error al buscar los proveedores: {0}", ex.Message));
            }
        }
    }
}
