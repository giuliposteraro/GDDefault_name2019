using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Negocio.Base
{
    public class IPersistencia<T>
    {
        
        public MaperBase<T> maper;
        private SqlConnection conn;

        internal void InicializarConexion()
        {
            conn = new SqlConnection();
            conn.ConnectionString = "Server=localhost\\SQLSERVER2012;Database=GD2C2019;User Id=gdCupon2019;Password=gd2019;";
            conn.Open();
        }

        internal void CerrarConexion()
        {
            conn.Close();
        }

        public DataTable BuscarTodos()
        { 
            try
            {
                InicializarConexion();
                SqlCommand command = conn.CreateCommand();
                command.Connection = conn;
                command.CommandText = string.Format("select * from {0}.{1}", maper.schema, maper.tabla);

                SqlDataReader rd = command.ExecuteReader();

                var dataTable = new DataTable();
                dataTable.Load(rd);

                CerrarConexion();
                return dataTable;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                CerrarConexion();
            }
        }

        private static void ExecuteSqlTransaction(string connectionString)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                SqlCommand command = connection.CreateCommand();
                SqlTransaction transaction;

                // Start a local transaction.
                transaction = connection.BeginTransaction("SampleTransaction");

                // Must assign both transaction object and connection
                // to Command object for a pending local transaction
                command.Connection = connection;
                command.Transaction = transaction;

                try
                {
                    command.CommandText =
                        "Insert into Region (RegionID, RegionDescription) VALUES (100, 'Description')";
                    command.ExecuteNonQuery();
                    command.CommandText =
                        "Insert into Region (RegionID, RegionDescription) VALUES (101, 'Description')";
                    command.ExecuteNonQuery();

                    // Attempt to commit the transaction.
                    transaction.Commit();
                    Console.WriteLine("Both records are written to database.");
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Commit Exception Type: {0}", ex.GetType());
                    Console.WriteLine("  Message: {0}", ex.Message);

                    // Attempt to roll back the transaction.
                    try
                    {
                        transaction.Rollback();
                    }
                    catch (Exception ex2)
                    {
                        // This catch block will handle any errors that may have occurred
                        // on the server that would cause the rollback to fail, such as
                        // a closed connection.
                        Console.WriteLine("Rollback Exception Type: {0}", ex2.GetType());
                        Console.WriteLine("  Message: {0}", ex2.Message);
                    }
                }
            }
        }
    }
}
