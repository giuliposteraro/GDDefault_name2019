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
    public class RepositorioDeFacturas: IPersistencia<Factura>
    {
        public RepositorioDeFacturas(MaperDeFacturas maper)
        {
            this.maper = maper;
        }


        public int ContarItems(Proveedor proveedor, string numero, DateTime fechaDesde, DateTime fechaHasta)
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
                              FROM [DEFAULT_NAME].[Factura]
                              where [Id_Proveedor] = @Id_Proveedor
                              and convert(datetime,[Fecha_Fact],121) between convert(datetime,@fechaDesde,121) and convert(datetime,@fechaHasta,121)";

                if (!(numero.EsNuloOVacio()))
                {
                    param = new SqlParameter("@Numero_Fact", '%' + numero + '%');
                    command.Parameters.Add(param);
                    texto = texto + " and [Numero_Fact] like @Numero_Fact";
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

        public List<Factura> ObtenerPaginado(Proveedor proveedor, string numero, DateTime fechaDesde, DateTime fechaHasta, int cantidadPorPagina, int paginaActual)
        {
            this.InicializarConexion();
            
            try
            {
                List<Factura> lista = new List<Factura>();

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
                if (!(numero.EsNuloOVacio()))
                {
                    param = new SqlParameter("@Numero_Fact", '%' + numero + '%');
                    parametros.Add(param);
                    consultaPago = " and [Numero_Fact] like @Numero_Fact";
                }
                string consulta = string.Format(@"WITH C AS
                        ( 
                            SELECT ROW_NUMBER() OVER(ORDER BY id_Factura) AS rownum,
                            *
                            FROM [DEFAULT_NAME].[Factura]
                              where [Id_Proveedor] = @Id_Proveedor
                              and convert(datetime,[Fecha_Fact],121) between convert(datetime,@fechaDesde,121) and convert(datetime,@fechaHasta,121)
                                        {0}
                        )
                        SELECT *
                        FROM C
                        WHERE rownum BETWEEN (@pagenum - 1) * @pagesize + 1 AND @pagenum * @pagesize 
                        ORDER BY id_Factura;", consultaPago);

                
                
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
