using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;


namespace Negocio.Base
{
    public class IPersistencia<T>
    {
        
        internal MaperBase<T> maper;
        internal SqlConnection conn;

        internal void InicializarConexion()
        {
            conn = new SqlConnection();
            string connectionString = ConfigurationManager.ConnectionStrings["gdDatos"].ConnectionString;
            conn.ConnectionString = connectionString;
            conn.Open();
        }

        internal void CerrarConexion()
        {
            conn.Close();
        }

        internal DataTable BuscarTodos()
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


        internal DataTable BuscarTodosPorFiltro(Dictionary<string, object[]> parametros, List<string> columnas = null)
        {
            try
            {
                InicializarConexion();
                SqlCommand command = conn.CreateCommand();
                command.Connection = conn;

                string where = "";
                for (int i = 0; i < parametros.Count(); i++)
                {
                    var item = parametros.ElementAt(i);
                    var itemKey = item.Key;
                    var itemValue = item.Value[0];
                    var comparador = "";
                    var union = "and";

                    if (i == 0)
                        union = "where";

                    switch ((int)item.Value[1])
                    {
                        case 0:
                            comparador = "=";
                            break;
                        case 1:
                            comparador = "like ";
                            itemValue = "%" + itemValue + "%";
                            break;
                    }

                    where = string.Format("{0} {1} {2} {3}@{4}", where, union, itemKey, comparador, i);

                    command.Parameters.Add(new SqlParameter(string.Format("{0}", i), itemValue));
                }
                if (columnas == null || !columnas.Any())
                    columnas = new List<string>(new string[] {"*"});

                string columns = "";
                foreach (string col in columnas)
                {
                    if (columns != "")
                        columns = columns + ", " + col;
                    else
                        columns = col;
                }


                command.CommandText = string.Format("select {0} from {1}.{2} {3}", columns, maper.schema, maper.tabla, where);
                
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

        public DataTable ObtenerPorID(string idName, int idValue)
        {
            try
            {
                InicializarConexion();
                SqlCommand command = conn.CreateCommand();
                command.Connection = conn;

                command.Parameters.Add(new SqlParameter(string.Format("@{0}",idName), idValue));                
                command.CommandText = string.Format("select * from {0}.{1} where {2} = @{2}",  maper.schema, maper.tabla, idName);

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


        public void EjecutarSP(string sp, List<SqlParameter> parametros)
        {
            try
            {
                InicializarConexion();
                SqlCommand cmd = new SqlCommand(sp, conn);
                cmd.CommandType = CommandType.StoredProcedure;

                foreach(SqlParameter par in parametros)
                {
                    cmd.Parameters.Add(par);
                }

                int resultado = cmd.ExecuteNonQuery();
                if (resultado == 0)
                    throw new Exception("error al ejecutar el sp");
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

        internal DataTable EjecutarConsulta(string consulta, List<SqlParameter> parametros)
        {
            try
            {
                InicializarConexion();
                SqlCommand command = conn.CreateCommand();
                command.Connection = conn;

                foreach (SqlParameter param in parametros)
                    command.Parameters.Add(param);

                command.CommandText = consulta;

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

        //para insert update y delete
        internal void EjecutarStatement(string consulta, List<SqlParameter> parametros)
        {
            try
            {
                InicializarConexion();
                SqlCommand command = conn.CreateCommand();
                command.Connection = conn;

                foreach (SqlParameter param in parametros)
                    command.Parameters.Add(param);

                command.CommandText = consulta;
                command.ExecuteNonQuery();
                CerrarConexion();
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

        public bool EliminarEntidad(T unaEntidad, string propertyID)
        {
            try
            {
                List<SqlParameter> parametros = new List<SqlParameter>();


                //armo el parametro para los ids
                SqlParameter param = new SqlParameter(string.Format("@{0}", propertyID), unaEntidad.GetType().GetProperty(propertyID).GetValue(unaEntidad, null));
                parametros.Add(param);

                //armo el update en funcion de los parametros a actualizar
                StringBuilder statement = new StringBuilder();
                statement.AppendLine(string.Format("Delete from {0}.{1} where {2} = @{2}", maper.schema, maper.tabla, propertyID));

                //ejecuto la actualizacion
                EjecutarStatement(statement.ToString(), parametros);
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception(string.Format("se produjo un error al actualizar la tabla: {0} - {1}", maper.tabla, ex.Message));
                return false;
            }
        }

        public bool ActualizarEntidad (T unaEntidad, List<string> propertiesAActualizar, string propertyID)
        {
            try
            {
                List<SqlParameter> parametros = new List<SqlParameter>();


                //armo el parametro para los ids
                SqlParameter param = new SqlParameter(string.Format("@{0}", propertyID), unaEntidad.GetType().GetProperty(propertyID).GetValue(unaEntidad, null));
                parametros.Add(param);

                //armo el update en funcion de los parametros a actualizar
                StringBuilder statement = new StringBuilder();
                statement.AppendLine(string.Format("UPDATE {0}.{1}",maper.schema, maper.tabla));

                string banderaPrimeraProperty = "SET";
                foreach (string propiedad in propertiesAActualizar)
                {
                    statement.AppendLine(string.Format("{0} {1} = @{1}",banderaPrimeraProperty,propiedad));
                    param = new SqlParameter(string.Format("@{0}", propiedad), unaEntidad.GetType().GetProperty(propiedad).GetValue(unaEntidad, null));
                    parametros.Add(param);
                    banderaPrimeraProperty = ",";
                }
                //armo el where con la property que es el id
                statement.AppendLine(string.Format("WHERE {0} = @{0}",propertyID));

                //ejecuto la actualizacion
                EjecutarStatement(statement.ToString(), parametros);
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception(string.Format("se produjo un error al actualizar la tabla: {0} - {1}",maper.tabla, ex.Message));
                return false;
            }
        }

    }
}
