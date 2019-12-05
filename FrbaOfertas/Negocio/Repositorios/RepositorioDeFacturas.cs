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


        public string ObteneSiguienteNroFactura()
        {
            this.InicializarConexion();

            try
            {

                SqlCommand command = conn.CreateCommand();
                command.Connection = conn;
                command.CommandText = @"select [DEFAULT_NAME].fx_Obtener_Siguiente_Nro_Factura() ";

                string numero = Convert.ToString(command.ExecuteScalar());
                
                return numero;
            }
            catch (Exception ex)
            {
                throw new Exception(string.Format("se produjo un error al buscar el siguiente número de factura: {0}", ex.Message));
            }
            finally
            {
                this.CerrarConexion();
            }
        }

        public void Guardar(Factura facturaAGuardar)
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
                SqlParameter param = new SqlParameter("@Id_Proveedor", facturaAGuardar.Id_Proveedor);
                command.Parameters.Add(param);
                param = new SqlParameter("@Numero_Fact", facturaAGuardar.Numero_Fact);
                command.Parameters.Add(param);
                param = new SqlParameter("@Tipo_Fact", facturaAGuardar.Tipo_Fact);
                command.Parameters.Add(param);
                param = new SqlParameter("@Total_Fact", facturaAGuardar.Total_Fact);
                command.Parameters.Add(param);
                param = new SqlParameter("@Fecha_Fact", facturaAGuardar.Fecha_Fact);
                command.Parameters.Add(param);

                command.CommandText = @"INSERT INTO [DEFAULT_NAME].[Factura]
                                       ([Id_Proveedor]
                                       ,[Numero_Fact]
                                       ,[Tipo_Fact]
                                       ,[Total_Fact]
                                       ,[Fecha_Fact])
                                 VALUES
                                       (@Id_Proveedor
                                       ,@Numero_Fact
                                       ,@Tipo_Fact
                                       ,@Total_Fact
                                       ,convert(datetime,@Fecha_Fact,121))
                                SELECT SCOPE_IDENTITY()";

                facturaAGuardar.Id_Factura = Convert.ToInt32(command.ExecuteScalar());
                //inserto las funcionalidades asociadas al rol



                //las consultas parametrizadas solo haceptan 2000 parametros, por lo que voy a dividir el insert del detalle en inserts de 400 items
                int ejecuciones  = 0;
                if (facturaAGuardar.Detalle.Count() < 400)
                    ejecuciones = 1;
                else
                    ejecuciones = (int)Math.Ceiling((decimal)(facturaAGuardar.Detalle.Count() / 400.00));

                for (int j = 1; j <= ejecuciones; j++)
                {
                    command.Parameters.Clear();
                    StringBuilder comando = new StringBuilder();
                    comando.AppendLine(@"INSERT INTO [DEFAULT_NAME].[Detalle]
                                    ([Id_Factura],[Id_Compra],[Monto],[Cantidad])
                                     VALUES");

                    int desde = 400 * (j - 1);
                    int hasta = 0;
                    if (j == ejecuciones)
                        hasta = facturaAGuardar.Detalle.Count();
                    else
                        hasta = 400 * j;

                    for (int i = desde; i < hasta; i++)
                    {
                        string a = ",";
                        if (i == desde) a = "";
                        param = new SqlParameter(string.Format("@Id_Factura{0}", i), facturaAGuardar.Id_Factura);
                        command.Parameters.Add(param);
                        param = new SqlParameter(string.Format("@Id_Compra{0}", i), facturaAGuardar.Detalle[i].Id_Compra);
                        command.Parameters.Add(param);
                        param = new SqlParameter(string.Format("@Monto{0}", i), facturaAGuardar.Detalle[i].Monto);
                        command.Parameters.Add(param);
                        param = new SqlParameter(string.Format("@Cantidad{0}", i), facturaAGuardar.Detalle[i].Cantidad);
                        command.Parameters.Add(param);
                        comando.AppendLine(string.Format("{1}(@Id_Factura{0} , @Id_Compra{0} ,@Monto{0}, @Cantidad{0})", i, a));
                    }
                    command.CommandText = comando.ToString();

                    command.ExecuteNonQuery();
                }
                transaction.Commit();
            }
            catch (Exception ex)
            {
                transaction.Rollback();
                throw new Exception(string.Format("se produjo un error al guardar la factura: {0}", ex.Message));
            }
            finally
            {
                this.CerrarConexion();
            }
        }
    }
}
