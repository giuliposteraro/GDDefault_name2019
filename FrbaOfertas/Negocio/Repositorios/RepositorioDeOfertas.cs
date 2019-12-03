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

        /// <summary>
        /// devuelve la oferta correspondiente al id que se pasa por parametro
        /// </summary>
        /// <param name="Id_Oferta"></param>
        /// <returns></returns>
        internal Oferta ObtenerUnoPorId(int Id_Oferta)
        {
            try
            {
                return this.maper.mapearAEntidad(ObtenerPorID("Id_Oferta", Id_Oferta)).FirstOrDefault();
            }
            catch (Exception ex)
            {
                throw new Exception(string.Format("se produjo un error al buscar la Oferta: {0}", ex.Message));
            }
        }

        public void Guardar(Oferta OfertaEnEdicion)
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
                SqlParameter param = new SqlParameter("@Id_Proveedor", OfertaEnEdicion.Id_Proveedor);
                command.Parameters.Add(param);
                param = new SqlParameter("@Descripcion_Of", OfertaEnEdicion.Descripcion_Of);
                command.Parameters.Add(param);
                param = new SqlParameter("@Fecha_Publi_Of", OfertaEnEdicion.Fecha_Publi_Of);
                command.Parameters.Add(param);
                param = new SqlParameter("@Fecha_Venc_Of", OfertaEnEdicion.Fecha_Venc_Of);
                command.Parameters.Add(param);
                param = new SqlParameter("@Precio_Oferta", OfertaEnEdicion.Precio_Oferta);
                command.Parameters.Add(param);
                param = new SqlParameter("@Precio_Lista", OfertaEnEdicion.Precio_Lista);
                command.Parameters.Add(param);
                param = new SqlParameter("@Cant_Disp_Oferta", OfertaEnEdicion.Cant_Disp_Oferta);
                command.Parameters.Add(param);
                param = new SqlParameter("@Maximo_Por_Compra", OfertaEnEdicion.Maximo_Por_Compra);
                command.Parameters.Add(param);
                param = new SqlParameter("@Codigo_Of", OfertaEnEdicion.Codigo_Of);
                command.Parameters.Add(param);

                command.CommandText = @"INSERT INTO [DEFAULT_NAME].[Oferta]
                                       ([Id_Proveedor]
                                       ,[Descripcion_Of]
                                       ,[Fecha_Publi_Of]
                                       ,[Fecha_Venc_Of]
                                       ,[Precio_Oferta]
                                       ,[Precio_Lista]
                                       ,[Cant_Disp_Oferta]
                                       ,[Maximo_Por_Compra]
                                       ,[Codigo_Of]
                                       ,[Precio_fict_Of])
                                 VALUES
                                       (@Id_Proveedor,
                                        @Descripcion_Of,
                                        convert(datetime,@Fecha_Publi_Of,121),
                                        convert(datetime,@Fecha_Venc_Of,121),
                                       @Precio_Oferta, 
                                       @Precio_Lista,
                                       @Cant_Disp_Oferta,
                                       @Maximo_Por_Compra,
                                        @Codigo_Of,
                                       null)";

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
        }
    }
}
