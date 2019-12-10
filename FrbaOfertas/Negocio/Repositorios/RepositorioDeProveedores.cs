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
                if (razonSocial != string.Empty) parametros.Add("Razon_Social_Prov", new object[2] { razonSocial, TipoDeComparador.eID.TextoExacto });
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
                if (mail != string.Empty) parametros.Add("Mail_Proveedor", new object[2] { mail, TipoDeComparador.eID.Texto });
                
                lista = this.maper.mapearAEntidad(BuscarTodosPorFiltro(parametros));
                return lista;
            }
            catch (Exception ex)
            {
                throw new Exception(string.Format("se produjo un error al buscar los proveedores: {0}", ex.Message));
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

        public void Modificar(Proveedor proveedor)
        {
            this.InicializarConexion();
            SqlTransaction transaction;
            transaction = conn.BeginTransaction();

            try
            {


                //si hay un proveedor lo creo aqui
                List<SqlParameter> parametros = new List<SqlParameter>();

                SqlParameter parametro = new SqlParameter("@Id_Cuenta", proveedor.Id_Cuenta);
                parametros.Add(parametro);
                parametro = new SqlParameter("@Id_Proveedor", proveedor.Id_Proveedor);
                parametros.Add(parametro);
                parametro = new SqlParameter("@Mail_Proveedor", proveedor.Mail_Proveedor);
                parametros.Add(parametro);
                parametro = new SqlParameter("@Telefono_Prov", proveedor.Telefono_Prov);
                parametros.Add(parametro);
                parametro = new SqlParameter("@Cuit_Prov", proveedor.Cuit_Prov);
                parametros.Add(parametro);
                parametro = new SqlParameter("@Rubro_Prov", proveedor.Rubro_Prov);
                parametros.Add(parametro);
                parametro = new SqlParameter("@Nom_Contacto_Prov", proveedor.Nom_Contacto_Prov);
                parametros.Add(parametro);
                parametro = new SqlParameter("@Razon_Social_Prov", proveedor.Razon_Social_Prov);
                parametros.Add(parametro);
                parametro = new SqlParameter("@Habilitado", proveedor.Habilitado);
                parametros.Add(parametro);
                parametro = new SqlParameter("@Numero_Dir", proveedor.Direccion.Numero_Dir);
                parametros.Add(parametro);
                parametro = new SqlParameter("@Piso_Dir", proveedor.Direccion.Piso_Dir);
                parametros.Add(parametro);
                parametro = new SqlParameter("@Depto_Dir", proveedor.Direccion.Depto_Dir);
                parametros.Add(parametro);
                parametro = new SqlParameter("@Localidad_Dir", proveedor.Direccion.Localidad_Dir);
                parametros.Add(parametro);
                parametro = new SqlParameter("@Ciudad_Dir", proveedor.Direccion.Ciudad_Dir);
                parametros.Add(parametro);
                parametro = new SqlParameter("@Calle_Dir", proveedor.Direccion.Calle_Dir);
                parametros.Add(parametro);
                parametro = new SqlParameter("@Codigo_Postal_Dir", proveedor.Direccion.Codigo_Postal_Dir);
                parametros.Add(parametro);
                parametro = new SqlParameter("@Id_Direccion", proveedor.Direccion.Id_Direccion);
                parametros.Add(parametro);

                string sp = "DEFAULT_NAME.SP_modificar_proveedor_con_domicilio";

                SqlCommand cmd = new SqlCommand(sp, conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Transaction = transaction;

                foreach (SqlParameter par in parametros)
                {
                    cmd.Parameters.Add(par);
                }

                int resultado = cmd.ExecuteNonQuery();
                if (resultado == 0)
                    throw new Exception("error al ejecutar el sp de modificación de proveedores");

                transaction.Commit();
            }
            catch (Exception ex)
            {
                transaction.Rollback();
                throw new Exception(string.Format("se produjo un error al modificar un proveedor: {0}", ex.Message));
            }
            finally
            {
                this.CerrarConexion();
            }
        }

        public void Agregar(Proveedor proveedor)
        {
            this.InicializarConexion();
            SqlTransaction transaction;
            transaction = conn.BeginTransaction();

            try
            {
                              

                //si hay un proveedor lo creo aqui
                    List<SqlParameter> parametros = new List<SqlParameter>();

                    SqlParameter parametro = new SqlParameter("@Id_Cuenta", null);
                    parametros.Add(parametro);
                    parametro = new SqlParameter("@Mail_Proveedor", proveedor.Mail_Proveedor);
                    parametros.Add(parametro);
                    parametro = new SqlParameter("@Telefono_Prov", proveedor.Telefono_Prov);
                    parametros.Add(parametro);
                    parametro = new SqlParameter("@Cuit_Prov", proveedor.Cuit_Prov);
                    parametros.Add(parametro);
                    parametro = new SqlParameter("@Rubro_Prov", proveedor.Rubro_Prov);
                    parametros.Add(parametro);
                    parametro = new SqlParameter("@Nom_Contacto_Prov", proveedor.Nom_Contacto_Prov);
                    parametros.Add(parametro);
                    parametro = new SqlParameter("@Razon_Social_Prov", proveedor.Razon_Social_Prov);
                    parametros.Add(parametro);
                    parametro = new SqlParameter("@Numero_Dir", proveedor.Direccion.Numero_Dir);
                    parametros.Add(parametro);
                    parametro = new SqlParameter("@Piso_Dir", proveedor.Direccion.Piso_Dir);
                    parametros.Add(parametro);
                    parametro = new SqlParameter("@Depto_Dir", proveedor.Direccion.Depto_Dir);
                    parametros.Add(parametro);
                    parametro = new SqlParameter("@Localidad_Dir", proveedor.Direccion.Localidad_Dir);
                    parametros.Add(parametro);
                    parametro = new SqlParameter("@Ciudad_Dir", proveedor.Direccion.Ciudad_Dir);
                    parametros.Add(parametro);
                    parametro = new SqlParameter("@Calle_Dir", proveedor.Direccion.Calle_Dir);
                    parametros.Add(parametro);
                    parametro = new SqlParameter("@Codigo_Postal_Dir", proveedor.Direccion.Codigo_Postal_Dir);
                    parametros.Add(parametro);

                    string sp = "DEFAULT_NAME.SP_insertar_proveedor_con_domicilio";

                    SqlCommand cmd = new SqlCommand(sp, conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Transaction = transaction;

                    foreach (SqlParameter par in parametros)
                    {
                        cmd.Parameters.Add(par);
                    }

                    int resultado = cmd.ExecuteNonQuery();
                    if (resultado == 0)
                        throw new Exception("error al ejecutar el sp de inserción de proveedores");

                transaction.Commit();
            }
            catch (Exception ex)
            {
                transaction.Rollback();
                throw new Exception(string.Format("se produjo un error al insertar un proveedor: {0}", ex.Message));
            }
            finally
            {
                this.CerrarConexion();
            }
        }
    }
}
