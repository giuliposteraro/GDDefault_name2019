using Negocio.Base;
using Negocio.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio.Repositorios
{
    public class RepositorioDeProveedor : IPersistencia<Proveedor>
    {
        public RepositorioDeProveedor(MaperDeProveedor maper)
        {
            this.maper = maper;
        }


        /// <summary>
        /// busca todos los proveedores existentes en el sistema,.
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
                throw new Exception(string.Format("se produjo un error al buscar los clientes: {0}", ex.Message));
            }
        }


        /// <summary>
        /// busca multiples proveedores por los filtros seleccionados
        /// </summary>
        /// <returns></returns>
        public List<Proveedor> BuscarConFiltros(string Nombre = null, string Razon_Social = null, string cuit = null, string mail = null)
        {
            try
            {
                List<Proveedor> lista = new List<Proveedor>();

                Dictionary<string, object[]> parametros = new Dictionary<string, object[]>();
                if (Nombre != string.Empty) parametros.Add("Nom_Contacto_Prov", new object[2] { Nombre, TipoDeComparador.eID.Texto });
                if (Razon_Social != string.Empty) parametros.Add("Razon_Social_Prov", new object[2] { Razon_Social, TipoDeComparador.eID.Texto });
                if (cuit != string.Empty) parametros.Add("Cuit_Prov", new object[2] { cuit, TipoDeComparador.eID.TextoExacto });

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
        /// <param name="Id_Cliente">id del proveedor que queremos buscar</param>
        /// <returns></returns>
        internal Proveedor ObtenerUnoPorId(int Id_Proveedor)
        {
            try
            {
                return this.maper.mapearAEntidad(ObtenerPorID("Id_Proveedor", Id_Proveedor)).FirstOrDefault();
            }
            catch (Exception ex)
            {
                throw new Exception(string.Format("se produjo un error al buscar el proveedor: {0}", ex.Message));
            }
        }


        
    }
}
