using Negocio.Base;
using Negocio.Entidades;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio.Repositorios
{
    public class RepositorioDeCompras: IPersistencia<Compra>
    {
        public RepositorioDeCompras(MaperDeCompras maper)
        {
            this.maper = maper;
        }

        /// <summary>
        /// obtiene la cantidad de veces que la oferta fue comprada.
        /// </summary>
        /// <param name="id_Oferta"></param>
        /// <returns></returns>
        public int ObtenerCantidadCompradas(int id_Oferta)
        {
            this.InicializarConexion();

            try
            {
                SqlCommand command = conn.CreateCommand();
                command.Connection = conn;
                SqlParameter param = new SqlParameter("@Id_Oferta", id_Oferta);
                command.Parameters.Add(param);

                var texto = @"SELECT count(*)
                            FROM [DEFAULT_NAME].[Compra] c 
                            where [Id_Oferta] = @Id_Oferta";

                command.CommandText = texto;

                int cantidad = Convert.ToInt32(command.ExecuteScalar());
                //inserto las funcionalidades asociadas al rol
                return cantidad;
            }
            catch (Exception ex)
            {
                throw new Exception(string.Format("se produjo un error al buscar la cantidad de compras para la oferta: {0}", ex.Message));
            }
            finally
            {
                this.CerrarConexion();
            }
        }


        /// <summary>
        /// devuelve true o false dependiendo de si encuentra otra oferta con el mismo codigo
        /// </summary>
        /// <param name="p"></param>
        /// <returns></returns>
        public bool ObtenerOfertasConElMismoCodigo(string Codigo)
        {
            this.InicializarConexion();

            try
            {
                SqlCommand command = conn.CreateCommand();
                command.Connection = conn;
                SqlParameter param = new SqlParameter("@Codigo_Of", Codigo);
                command.Parameters.Add(param);

                var texto = @"SELECT count(*)
                            FROM [DEFAULT_NAME].[Oferta] 
                            where [Codigo_Of] = @Codigo_Of";

                command.CommandText = texto;

                int cantidad = Convert.ToInt32(command.ExecuteScalar());
                
                return cantidad>0;
            }
            catch (Exception ex)
            {
                throw new Exception(string.Format("se produjo un error al buscar ofertas con el mismo código: {0}", ex.Message));
            }
            finally
            {
                this.CerrarConexion();
            }
        }

        public void Guardar(Compra compra)
        {
            this.InicializarConexion();
            SqlTransaction transaction;
            transaction = conn.BeginTransaction();

            try
            {

                //inserto la nueva compra

                SqlCommand command = conn.CreateCommand();
                command.Connection = conn;
                command.Transaction = transaction;
                SqlParameter param = new SqlParameter("@Id_Cliente", compra.Id_Cliente);
                command.Parameters.Add(param);
                param = new SqlParameter("@Id_Proveedor", compra.Id_Proveedor);
                command.Parameters.Add(param);
                param = new SqlParameter("@Id_Oferta", compra.Id_Oferta);
                command.Parameters.Add(param);
                param = new SqlParameter("@Fecha_Compra", compra.Fecha_Compra);
                command.Parameters.Add(param);
                param = new SqlParameter("@Codigo_Cupon", compra.Codigo_Cupon);
                command.Parameters.Add(param);
                param = new SqlParameter("@Estado_Cupon", compra.Estado_Cupon);
                command.Parameters.Add(param);
                param = new SqlParameter("@Cantidad", compra.Cantidad);
                command.Parameters.Add(param);
                param = new SqlParameter("Monto", compra.Monto);
                command.Parameters.Add(param);

                command.CommandText = @"INSERT INTO [DEFAULT_NAME].[Compra]
                                           ([Id_Cliente]
                                           ,[Id_Proveedor]
                                           ,[Id_Oferta]
                                           ,[Fecha_Compra]
                                           ,[Fecha_Entrega]
                                           ,[Codigo_Cupon]
                                           ,[Estado_Cupon]
                                           ,[Cantidad]
                                           ,[Monto])
                                     VALUES
                                           (@Id_Cliente
                                           ,@Id_Proveedor
                                           ,@Id_Oferta
                                           ,convert(datetime,@Fecha_Compra,121)
                                           ,null
                                           ,@Codigo_Cupon
                                           ,@Estado_Cupon
                                           ,@Cantidad
                                           ,@Monto)";

                command.ExecuteNonQuery();

                transaction.Commit();
            }
            catch (Exception ex)
            {
                transaction.Rollback();
                throw new Exception(string.Format("se produjo un error al guardar las compras: {0}", ex.Message));
            }
            finally
            {
                this.CerrarConexion();
            }
        }

        public Compra ObtenerCompraPorCupon(string cupon)
        {
            try
            {

                List<Compra> lista = new List<Compra>();
                List<SqlParameter> parametros = new List<SqlParameter>();
                SqlParameter param = new SqlParameter("@Codigo_Cupon", cupon);
                parametros.Add(param);

                var texto = @"SELECT  [Id_Compra]
                                      ,[Id_Cliente]
                                      ,[Id_Proveedor]
                                      ,[Id_Oferta]
                                      ,[Fecha_Compra]
                                      ,[Fecha_Entrega]
                                      ,[Codigo_Cupon]
                                      ,[Estado_Cupon]
                                      ,[Cantidad]
                                      ,[Monto]
                                        ,[Facturado]
                            FROM [DEFAULT_NAME].[Compra] 
                            where [Codigo_Cupon] = @Codigo_Cupon";

                lista = this.maper.mapearAEntidad(EjecutarConsulta(texto, parametros));
                return lista.FirstOrDefault();
            }
            catch (Exception ex)
            {
                throw new Exception(string.Format("se produjo un error al buscar compras con el mismo código: {0}", ex.Message));
                return null;
            }
        }

        public int ContarItems(Proveedor proveedor, DateTime fechaDesde, DateTime fechaHasta)
        {
            this.InicializarConexion();

            try
            {

                SqlCommand command = conn.CreateCommand();
                command.Connection = conn;
                SqlParameter param = new SqlParameter("@Id_Proveedor", proveedor.Id_Proveedor);
                command.Parameters.Add(param);
                param = new SqlParameter("@fechaDesde", fechaDesde);
                command.Parameters.Add(param);
                param = new SqlParameter("@fechaHasta", fechaHasta);
                command.Parameters.Add(param);

                var texto = @"SELECT count(*)
                              FROM [DEFAULT_NAME].[Compra]
                              where [Id_Proveedor] = @Id_Proveedor
                              and convert(datetime,[Fecha_Compra],121) between convert(datetime,@fechaDesde,121) and convert(datetime,@fechaHasta,121)
                              and facturado = 0";

                
                command.CommandText = texto;

                int cantidad = Convert.ToInt32(command.ExecuteScalar());
                //inserto las funcionalidades asociadas al rol
                return cantidad;
            }
            catch (Exception ex)
            {
                throw new Exception(string.Format("se produjo un error al buscar la cantidad de items: {0}", ex.Message));
            }
            finally
            {
                this.CerrarConexion();
            }
        }

        public List<Compra> ObtenerPaginado(Proveedor proveedor, DateTime fechaDesde, DateTime fechaHasta, int cantidadPorPagina, int paginaActual)
        {
            this.InicializarConexion();

            try
            {
                List<Compra> lista = new List<Compra>();

                List<SqlParameter> parametros = new List<SqlParameter>();
                SqlParameter param = new SqlParameter("@Id_Proveedor", proveedor.Id_Proveedor);
                parametros.Add(param);
                param = new SqlParameter("@fechaDesde", fechaDesde);
                parametros.Add(param);
                param = new SqlParameter("@fechaHasta", fechaHasta);
                parametros.Add(param);
                param = new SqlParameter("@pagesize", cantidadPorPagina);
                parametros.Add(param);
                param = new SqlParameter("@pagenum", paginaActual);
                parametros.Add(param);

                
                string consulta = @"WITH C AS
                        ( 
                            SELECT ROW_NUMBER() OVER(ORDER BY id_Compra) AS rownum,
                            *
                            FROM [DEFAULT_NAME].[Compra]
                              where [Id_Proveedor] = @Id_Proveedor
                              and convert(datetime,[Fecha_Compra],121) between convert(datetime,@fechaDesde,121) and convert(datetime,@fechaHasta,121)
                              and facturado = 0
                                       
                        )
                        SELECT *
                        FROM C
                        WHERE rownum BETWEEN (@pagenum - 1) * @pagesize + 1 AND @pagenum * @pagesize 
                        ORDER BY id_Compra;";



                lista = this.maper.mapearAEntidad(EjecutarConsulta(consulta, parametros));
                return lista;

            }
            catch (Exception ex)
            {
                throw new Exception(string.Format("se produjo un error al buscar las facturas: {0}", ex.Message));
            }
            finally
            {
                this.CerrarConexion();
            }
        }
    }
}
