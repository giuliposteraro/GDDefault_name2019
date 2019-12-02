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
    public class RepositorioDeOfertas: IPersistencia<Oferta>
    {
        public RepositorioDeOfertas(MaperDeOfertas maper)
        {
            this.maper = maper;
        }



        /*public void InsertarNuevo(Oferta oferta)
        {
            this.InicializarConexion();
            SqlTransaction transaction;
            transaction = conn.BeginTransaction();

            try
            {

                //inserto el nuevo rol

                SqlCommand command = conn.CreateCommand();
                command.Connection = conn;
                command.Transaction = transaction;
                SqlParameter param = new SqlParameter("@Id_Cliente", credito.Id_Cliente);
                command.Parameters.Add(param);
                param = new SqlParameter("@Carga_Fecha", credito.Carga_Fecha);
                command.Parameters.Add(param);
                param = new SqlParameter("@Carga_Cred", credito.Carga_Cred);
                command.Parameters.Add(param);
                param = new SqlParameter("@Tarjeta", credito.Tarjeta);
                command.Parameters.Add(param);
                param = new SqlParameter("@Detalle", credito.Detalle);
                command.Parameters.Add(param);
                param = new SqlParameter("@Tipo_Pago", credito.Tipo_Pago);
                command.Parameters.Add(param);

                command.CommandText = @"INSERT INTO [DEFAULT_NAME].[Credito]
                                       ([Id_Cliente]
                                       ,[Carga_Fecha]
                                       ,[Carga_Cred]
                                       ,[Tarjeta]
                                       ,[Detalle]
                                       ,[Tipo_Pago])
                                 VALUES
                                       (@Id_Cliente,
                                       convert(datetime,@Carga_Fecha,121),
                                       @Carga_Cred, 
                                       @Tarjeta,
                                       @Detalle,
                                       @Tipo_Pago)";

                command.ExecuteNonQuery();

                transaction.Commit();
            }
            catch (Exception ex)
            {
                transaction.Rollback();
                throw new Exception(string.Format("se produjo un error al buscar las Funcionalidades: {0}", ex.Message));
            }
            finally
            {
                this.CerrarConexion();
            }
        }*/

        public int ContarItems(Proveedor proveedor, string codigo, DateTime fechaDesde, DateTime fechaHasta)
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
                              FROM [DEFAULT_NAME].[Oferta]
                              where [Id_Proveedor] = @Id_Proveedor
                              and convert(datetime,[Fecha_Publi_Of],121) between convert(datetime,@fechaDesde,121) and convert(datetime,@fechaHasta,121)";

                if (!(codigo.EsNuloOVacio()))
                {
                    param = new SqlParameter("@Codigo_Of", '%' + codigo + '%');
                    command.Parameters.Add(param);
                    texto = texto + " and [Codigo_Of] like @Codigo_Of";
                }
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

        public List<Oferta> ObtenerPaginado(Proveedor proveedor, string codigo, DateTime fechaDesde, DateTime fechaHasta, int cantidadPorPagina, int paginaActual)
        {
            this.InicializarConexion();
            
            try
            {
                List<Oferta> lista = new List<Oferta>();

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

                string consultaPago = "";
                if (!(codigo.EsNuloOVacio()))
                {
                    param = new SqlParameter("@Codigo_Of", '%' + codigo + '%');
                    parametros.Add(param);
                    consultaPago = " and [Codigo_Of] like @Codigo_Of";
                }
                string consulta = string.Format(@"WITH C AS
                        ( 
                            SELECT ROW_NUMBER() OVER(ORDER BY id_Oferta) AS rownum,
                            *
                            FROM [DEFAULT_NAME].[Oferta]
		                        where [Id_Proveedor] = @Id_Proveedor
                                        and convert(datetime,[Fecha_Publi_Of],121) 
                                        between convert(datetime,@fechaDesde,121) 
                                        and convert(datetime,@fechaHasta,121)
                                        {0}
                        )
                        SELECT *
                        FROM C
                        WHERE rownum BETWEEN (@pagenum - 1) * @pagesize + 1 AND @pagenum * @pagesize 
                        ORDER BY id_Oferta;", consultaPago);

                
                
                lista = this.maper.mapearAEntidad(EjecutarConsulta(consulta, parametros));
                return lista;

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
    }
}
