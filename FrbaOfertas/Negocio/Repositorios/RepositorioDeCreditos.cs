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
    public class RepositorioDeCreditos: IPersistencia<Credito>
    {
        public RepositorioDeCreditos(MaperDeCreditos maper)
        {
            this.maper = maper;
        }



        public void InsertarNuevo(Credito credito)
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
                                       @Carga_Fecha,
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
        }
    }
}
