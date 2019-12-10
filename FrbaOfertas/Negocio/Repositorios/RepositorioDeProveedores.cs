using Negocio.Base;
using Negocio.Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
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

        public DataTable ObtenerReporteDescuentos(DateTime fechaDesde, DateTime fechaHasta)
        {
            try
            {
                DataTable lista = new DataTable();

                List<SqlParameter> parametros = new List<SqlParameter>();
                SqlParameter param = new SqlParameter("@fechaDesde", fechaDesde);
                parametros.Add(param);
                param = new SqlParameter("@fechaHasta", fechaHasta);
                parametros.Add(param);

                string consulta = @"select top 5 sum(Precio_Oferta) / sum (Precio_Lista) as [Porcentaje promedio de Descuento],  
p.Razon_Social_Prov as [Proveedor], p.Cuit_Prov as [Cuit Proveedor],  
  p.Rubro_Prov as [Rubro], count(o.id_oferta) as [Total de ofertas], 
  min(o.Fecha_Publi_Of) as [Fecha 1° oferta],
  max(1 - (o.Precio_Oferta/ precio_Lista)) as [Mayor descuento Ofrecido]
from Default_name.proveedor p
inner join Default_name.oferta o on o.Id_Proveedor = p.Id_Proveedor
where convert(datetime,o.fecha_Publi_OF,121) between convert(datetime,@fechaDesde,121) and convert(datetime,@fechaHasta,121)
group by p.id_proveedor ,Razon_Social_Prov, Cuit_Prov,p.Rubro_Prov
order by sum(Precio_Oferta) / sum (Precio_Lista) desc
";



                lista = EjecutarConsulta(consulta, parametros);
                return lista;

            }
            catch (Exception ex)
            {
                throw new Exception(string.Format("se produjo un error al buscar el reporte: {0}", ex.Message));
            }
        }

        public DataTable ObtenerReporteFacturacion(DateTime fechaDesde, DateTime fechaHasta)
        {
            try
            {
                DataTable lista = new DataTable();

                List<SqlParameter> parametros = new List<SqlParameter>();
                SqlParameter param = new SqlParameter("@fechaDesde", fechaDesde);
                parametros.Add(param);
                param = new SqlParameter("@fechaHasta", fechaHasta);
                parametros.Add(param);

                string consulta = @"select top 5 p.Razon_Social_Prov as [Proveedor], p.Cuit_Prov as [Cuit Proveedor],  
                        p.Cuit_Prov as [Rubro], p.Mail_Proveedor as [e-Mail], p.Telefono_Prov as [Telefono],
                        sum (f.Total_Fact) as [Total Facturado] from Default_name.Proveedor p
                        inner join Default_name.factura f on f.Id_Proveedor = p.Id_Proveedor
                        where convert(datetime,f.Fecha_Fact,121) between convert(datetime,@fechaDesde,121) and convert(datetime,@fechaHasta,121)
                        group by p.Id_Proveedor, p.Razon_Social_Prov,p.Cuit_Prov,p.Mail_Proveedor,p.Telefono_Prov
                        order by sum (f.Total_Fact) desc";



                lista = EjecutarConsulta(consulta, parametros);
                return lista;

            }
            catch (Exception ex)
            {
                throw new Exception(string.Format("se produjo un error al buscar el reporte: {0}", ex.Message));
            }
        }

        public void Modificar(Proveedor ProveedorAGuardar)
        {
            throw new NotImplementedException();
        }

        public void Agregar(Proveedor ProveedorAGuardar)
        {
            throw new NotImplementedException();
        }
    }
}
